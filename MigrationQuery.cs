using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MigrationTool
{
  public enum MigrationQueryType { CUSTOM, DELETE, UPDATE }
  public class MigrationQuery
  {
    public int id { get; set; }
    public bool enabled { get; set; }
    public string query { get; set; }
    public string name { get; set; }
    public string company { get; set; }
    public bool hasCompany { get; set; }
    public MigrationQueryType type { get; set; }

    public MigrationQuery(int id)
    {
      this.id = id;
      enabled = true;
      query = "";
      name = "Custom " + id;
      company = "";
      hasCompany = false;
      type = MigrationQueryType.CUSTOM;
    }

    private string RemoveComment(string querytoEdit)
    {
      return Regex.Replace(querytoEdit, @"(--).+", "").Trim();
    }

    public void InitializeQuery(string newQuery)
    {
      string queryBuilder = newQuery.Trim();
      if (String.IsNullOrEmpty(queryBuilder))
        throw new Exception("Empty query");
      
      Match m = Regex.Match(queryBuilder, @"(?<=-\@\@\@Name: ).*");
      if (!m.Success)
        throw new Exception("Name not found");
      name = m.Value.Trim();

      m = Regex.Match(queryBuilder, @"(?<=-\@\@\@RunOnCompany: ).*");
      if (m.Success)
        company = m.Value.Trim();

      queryBuilder = RemoveComment(queryBuilder);
      if (String.IsNullOrEmpty(queryBuilder))
        throw new Exception("Empty query");
      
      hasCompany = Regex.IsMatch(queryBuilder, Regex.Escape(AppSettingsHelper.Config.PlaceholderCompany));
      query = queryBuilder;
    }

    public void Execute(bool runQueryOnlyWithCompany, string companyOnRun)
    {
      if (runQueryOnlyWithCompany && !hasCompany)
      {
        MigrationLog.Write("SKIP   : QUERY WITHOUT COMPANY - " + NameForLog());
        return;
      }

      if (!String.IsNullOrEmpty(this.company) && companyOnRun != this.company)
      {
        MigrationLog.Write("SKIP   : COMPANY " + companyOnRun + " QUERY - " + NameForLog(this.company));
        return;
      }
      MigrationLog.Write("EXECUTE: " + NameForLog(companyOnRun));
      
      var q = query.Replace(AppSettingsHelper.Config.PlaceholderDBBC, AppSettingsHelper.Config.DBBC);
      q = q.Replace(AppSettingsHelper.Config.PlaceholderDBNAV, AppSettingsHelper.Config.DBNAV);
      q = q.Replace(AppSettingsHelper.Config.PlaceholderCompany, companyOnRun);
      
      int row_affected;
      try
      {
        row_affected = SqlController.RunQuery(q);
        SqlController.ShrinkFile(AppSettingsHelper.Config.DBBC, AppSettingsHelper.Config.LogToShrink);
      }
      catch (Exception ex)
      {
        MigrationLog.Write("ERRORE : " + NameForLog(companyOnRun) + " - " + ex.Message);
        MigrationLog.Write(q);
        return;
      }
      
      MigrationLog.Write("DONE   : " + NameForLog(companyOnRun) + " " + 
        row_affected.ToString() + " row affected");
    }

    private string NameForLog(string company="")
    {
      if (company != "" && hasCompany)
        return id + " - " + company + " - " + name;
      else
        return id + " - " + name;
    }

    public override string ToString()
    {
      string toString = @"--@@@ID: " + id + Environment.NewLine;
      if (!String.IsNullOrEmpty(name))
        toString += @"--@@@Name: " + name + Environment.NewLine;
      if (!String.IsNullOrEmpty(company))
        toString += @"--@@@RunOnCompany: " + company + Environment.NewLine;
      toString += query;
      return toString;
    }
  }
}

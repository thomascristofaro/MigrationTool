using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MigrationTool
{
  public enum MigrationQueryType { CUSTOM, DELETE, UPDATE }
  public class MigrationQuery
  {
    private const string REGEX_COMPANY = @"(?<=\[)(?!.*\[)(.*?)(?=\$)";
    private const string REGEX_HAS_COMPANY = @"(\$.*)(?=\$)";
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

    public static MigrationQuery CreateFromRaw(int id, string rawQuery, string companyPlaceholder, Dictionary<string, string> placeholders)
    {
      if (String.IsNullOrEmpty(rawQuery))
        return null;
      var dollarSystem = new Dictionary<string, string>();
      dollarSystem.Add("[$systemId]", "[_systemId]");
      dollarSystem.Add("[$systemCreatedAt]", "[_systemCreatedAt]");
      dollarSystem.Add("[$systemCreatedBy]", "[_systemCreatedBy]");
      dollarSystem.Add("[$systemModifiedAt]", "[_systemModifiedAt]");
      dollarSystem.Add("[$systemModifiedBy]", "[_systemModifiedBy]");

      MigrationQuery q = new MigrationQuery(id);
      q.query = rawQuery.Trim();

      foreach (var entry in dollarSystem)
        q.query = Regex.Replace(q.query, Regex.Escape(entry.Key), entry.Value);

      q.CheckCompany();
      q.query = q.RemoveComment(q.query);
      if (q.query.Length <= 0)
        return null;
      q.SetTableAndTypeFromQuery();
      q.RawReplacePlaceholders(companyPlaceholder, placeholders);

      foreach (var entry in dollarSystem)
        q.query = Regex.Replace(q.query, Regex.Escape(entry.Value), entry.Key);

      return q;
    }

    private void CheckCompany()
    {
      hasCompany = Regex.IsMatch(query, REGEX_HAS_COMPANY);
      bool ignoreCompany = Regex.IsMatch(query, @"(--@@@IGNORE COMPANY@@@)");
      if (ignoreCompany)
      {
        query = Regex.Replace(query, @"(--@@@IGNORE COMPANY@@@)", "");
        
        if (!hasCompany)
          throw new Exception(message: "Query without company");

        Match m = Regex.Match(query, REGEX_COMPANY);
        if (!m.Success)
          throw new Exception(message: "Company not found");
        company = m.Value;
      }
    }
    private string RemoveComment(string querytoEdit)
    {
      return Regex.Replace(querytoEdit, @"(--).+", "").Trim();
    }

    public void SetTableAndTypeFromQuery()
    {
      if (query.Length > 0)
      {
        using var reader = new System.IO.StringReader(query);
        string first = reader.ReadLine().Trim();

        string typeStr = first.Substring(0, first.IndexOf('[')).ToUpper();
        if (typeStr.StartsWith("DELETE"))
          type = MigrationQueryType.DELETE;
        else
          if (typeStr.StartsWith("UPDATE"))
            type = MigrationQueryType.UPDATE;

        var i1 = first.LastIndexOf('[') + 1;
        first = first.Substring(i1, first.LastIndexOf(']') - i1);

        i1 = first.IndexOf('$');
        if (i1 != first.LastIndexOf('$'))
          first = first.Substring(i1 + 1);

        name = first;
      }
    }

    private void RawReplacePlaceholders(string companyPlaceholder, Dictionary<string, string> placeholders)
    {
      if (hasCompany)
        query = Regex.Replace(query, REGEX_COMPANY, companyPlaceholder);

      foreach (var placeholder in placeholders)
      {
        query = Regex.Replace(query, 
          Regex.Escape(placeholder.Key),
          placeholder.Value, 
          RegexOptions.IgnoreCase);
      }
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
        SqlController.ShrinkFile(AppSettingsHelper.Config.PlaceholderDBBC, AppSettingsHelper.Config.LogToShrink);
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

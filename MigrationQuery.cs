using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MigrationTool
{
  public enum MigrationQueryType { NOT_FOUND, DELETE, UPDATE }
  public class MigrationQuery
  {
    private const string REGEX_COMPANY = @"(?<=\[)(?!.*\[)(.*?)(?=\$)";
    private const string REGEX_HAS_COMPANY = @"(\$.*)(?=\$)";
    public int id { get; set; }
    public bool enabled { get; set; }
    public string query { get; set; }
    public string table { get; set; }
    public string company { get; set; }
    public bool hasCompany { get; set; }
    public MigrationQueryType type { get; set; }

    private Dictionary<string, string> dollarSystem;

    public MigrationQuery(int id)
    {
      this.id = id;
      enabled = true;
      query = "";
      table = "";
      company = "";
      hasCompany = false;
      type = MigrationQueryType.NOT_FOUND;

      dollarSystem = new Dictionary<string, string>();
      dollarSystem.Add("[$systemId]", "[_systemId]");
      dollarSystem.Add("[$systemCreatedAt]", "[_systemCreatedAt]");
      dollarSystem.Add("[$systemCreatedBy]", "[_systemCreatedBy]");
      dollarSystem.Add("[$systemModifiedAt]", "[_systemModifiedAt]");
      dollarSystem.Add("[$systemModifiedBy]", "[_systemModifiedBy]");
    }

    public static MigrationQuery CreateFromRaw(int id, string rawQuery, string companyPlaceholder, Dictionary<string, string> placeholders)
    {
      MigrationQuery q = new MigrationQuery(id);
      q.query = rawQuery;

      q.RemoveDollarSystem();
      q.CheckCompany();
      q.RemoveComment();
      if (q.query.Length <= 0)
        return null;
      q.SetTableAndTypeFromQuery();
      q.ReplacePlaceholders(companyPlaceholder, placeholders);
      q.InsertDollarSystem();

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
    private void RemoveComment()
    {
      query = Regex.Replace(query, @"(--).+", "");
      query = query.Trim();
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

        table = first;
      }
    }

    private void ReplacePlaceholders(string companyPlaceholder, Dictionary<string, string> placeholders)
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

    private void RemoveDollarSystem()
    {
      foreach (var entry in dollarSystem)
        query = Regex.Replace(query, Regex.Escape(entry.Key), entry.Value);
    }

    private void InsertDollarSystem()
    {
      foreach (var entry in dollarSystem)
        query = Regex.Replace(query, Regex.Escape(entry.Value), entry.Key);
    }

    public void Execute(string dbNAV, string dbBC, string company, bool runOnlyCompany)
    {
      if (runOnlyCompany && !hasCompany)
      {
        MigrationLog.Write("SKIP - NOT COMPANY: " + NameForLog());
        return;
      }

      if (this.company != "" && company != this.company)
      {
        MigrationLog.Write("SKIP - COMPANY: " + this.company + NameForLog());
        return;
      }
      MigrationLog.Write("EXECUTE: " + NameForLog(company));
      
      var q = query.Replace("{DB_BC}", '[' + dbBC+ ']');
      q = q.Replace("{DB_NAV}", '[' + dbNAV + ']');
      q = q.Replace("{COMPANY}", company);

      try
      {
        SqlController.RunQuery(q);
      }
      catch (Exception ex)
      {
        MigrationLog.Write("!!! ERRORE PER: " + NameForLog(company) + " - " + ex.Message);
        return;
      }
      
      MigrationLog.Write("DONE: " + NameForLog(company));
    }

    private string NameForLog(string company="")
    {
      if (company != "" && hasCompany)
        return id + " - " + company + "$" + table;
      else
        return id + " - " + table;
    }
  }
}

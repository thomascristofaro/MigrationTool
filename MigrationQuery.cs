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
    public int id { get; set; }
    public bool enabled { get; set; }
    public string query { get; set; }
    public string table { get; set; }
    public string company { get; set; }
    public MigrationQueryType type { get; set; }

    public MigrationQuery(int id)
    {
      this.id = id;
      enabled = true;
      query = "";
      table = "";
      company = "";
      type = MigrationQueryType.NOT_FOUND;
    }

    public static MigrationQuery CreateFromRaw(int id, string rawQuery, string companyPlaceholder, Dictionary<string, string> placeholders)
    {
      MigrationQuery q = new MigrationQuery(id);
      q.query = rawQuery;
      q.CheckCompany();
      q.RemoveComment();
      if (q.query.Length <= 0)
        return null;
      q.SetTableAndTypeFromQuery();
      q.ReplacePlaceholders(companyPlaceholder, placeholders);
      return q;
    }

    private void CheckCompany()
    {
      bool ignoreCompany = Regex.IsMatch(query, @"(--@@@IGNORE COMPANY@@@)");
      if (ignoreCompany)
      {
        query = Regex.Replace(query, @"(--@@@IGNORE COMPANY@@@)", "");
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

        // da ricontrollare, alcuni hanno ] finale e altri no
        var i1 = first.LastIndexOf('[') + 1;
        first = first.Substring(i1, first.Length - 1 - i1);

        i1 = first.IndexOf('$');
        if (i1 != first.LastIndexOf('$'))
          first = first.Substring(i1 + 1);

        table = first;
      }
    }

    private void ReplacePlaceholders(string companyPlaceholder, Dictionary<string, string> placeholders)
    {
      query = Regex.Replace(query, REGEX_COMPANY, companyPlaceholder);

      foreach (var placeholder in placeholders)
      {
        query = Regex.Replace(query, 
          Regex.Escape(placeholder.Key),
          placeholder.Value, 
          RegexOptions.IgnoreCase);
      }
    }
    public void Execute(string dbNAV, string dbBC, string company)
    {
      if (this.company != "" && company != this.company)
      {
        MigrationLog.Write("SKIP - COMPANY: " + this.company + NameForLog());
        return;
      }
      MigrationLog.Write("EXECUTE: " + NameForLog());
      System.Threading.Thread.Sleep(100);
      MigrationLog.Write("DONE: " + NameForLog());
    }

    private string NameForLog()
    {
      return id + " - " + table;
    }
  }
}

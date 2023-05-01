using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MigrationTool
{
  public class MigrationQuery
  {
    public bool enabled = true;
    public string query = "";
    public string table = "";
    public string company = "";
    private const string REGEX_COMPANY = @"(?<=\[)(?!.*\[)(.*?)(?=\$)";
    
    public MigrationQuery() => enabled = true;

    public MigrationQuery(string table, string query, string company)
    {
      this.query = query;
      this.table = table;
      this.company = company;
      enabled = true;
    }

    public static MigrationQuery CreateFromRaw(string rawQuery, string companyPlaceholder, Dictionary<string, string> placeholders)
    {
      MigrationQuery q = new MigrationQuery();
      q.query = rawQuery;
      q.CheckCompany();
      q.RemoveComment();
      q.table = q.GetTableName();
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

    public string GetTableName()
    {
      if (table != "")
        return table;

      if (query.Length > 0)
      {
        using var reader = new System.IO.StringReader(query);
        string first = reader.ReadLine().Trim();
        var i1 = first.LastIndexOf('[') + 1;
        first = first.Substring(i1, first.Length - 1 - i1);

        i1 = first.IndexOf('$');
        if (i1 != first.LastIndexOf('$'))
        {
          first = first.Substring(i1 + 1);
        }

        return first;
      }
      return "";
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
    public void Run()
    {
      MigrationLog.Write("Esportazione query: " + table);
      System.Threading.Thread.Sleep(100);
    }
  }
}

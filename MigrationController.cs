using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;


namespace MigrationTool
{
  public class MigrationController
  {
    public List<MigrationQuery> queries = new List<MigrationQuery>();
    const string SPLIT_TEXT = @"(?=DELETE FROM|UPDATE \[)";
    // Da capire dove metterli
    string companyPlaceholder = "{COMPANY}";
    Dictionary<string, string> placeholders = new Dictionary<string, string>();

    public void LoadMigrationFile(string path)
    {
      queries.Clear();
      MigrationLog.Write("Loading migration file: " + path);
      string readText = File.ReadAllText(path);
      string[] rawQueries = Regex.Split(readText, SPLIT_TEXT);
      // posso fare una progress
      foreach (var rawQuery in rawQueries)
      {
        var rawQueryTrimmed = rawQuery.Trim();
        if (rawQueryTrimmed.Length > 0)
        {
          var q = MigrationQuery.CreateFromRaw(rawQueryTrimmed, companyPlaceholder, placeholders);
          if (q.query.Length > 0)
            queries.Add(q);
        }
      }
      MigrationLog.Write("Migration file: " + path + " loaded, there are " + queries.Count.ToString() + " queries");
    }

    public void ExportMigrationFile(String Path)
    {

    }

    public void RunQuery()
    {

    }

    void ShrinkFile()
    {

    }

    // tabelle esterne?
  }
}

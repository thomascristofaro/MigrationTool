using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;


namespace MigrationTool
{
  public class MigrationController
  {
    //public static MigrationController instance;
    private const string SPLIT_TEXT = @"(?=DELETE FROM|UPDATE \[)";
    private const string companyPlaceholder = "{COMPANY}";
    private Dictionary<string, string> placeholders;

    public List<MigrationQuery> queries { get; }
    
    // SONO SETUP DA SPOSTARE
    public string dbNAV { get; set; }
    public string dbBC { get; set; }
    public string companyForQuery { get; set; }

    public MigrationController()
    {
      queries = new List<MigrationQuery>();
      placeholders = new Dictionary<string, string>();
      placeholders.Add("PropagroupOperations.", "{DB_BC}.");
      placeholders.Add("PROPACK_attuale.", "{DB_NAV}.");
      placeholders.Add("[Propack_attuale]", "{DB_NAV}");
      placeholders.Add("[PropagroupOperations]", "{DB_BC}");
    }

    public void LoadMigrationFile(string path)
    {
      int idCounter = 1;
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
          var q = MigrationQuery.CreateFromRaw(idCounter++, rawQueryTrimmed, companyPlaceholder, placeholders);
          if (q != null) queries.Add(q);
          else idCounter--;
        }
      }
      MigrationLog.Write("Migration file: " + path + " loaded, there are " + queries.Count.ToString() + " queries");
    }

    public void ExportMigrationFile(String Path)
    {

    }

    void ShrinkFile()
    {

    }

    // tabelle esterne?
  }
}

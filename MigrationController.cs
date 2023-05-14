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
    public List<MigrationQuery> queries { get; }

    public MigrationController()
    {
      queries = new List<MigrationQuery>();
    }

    public void LoadMigrationFile(string path)
    {
      var placeholders = new Dictionary<string, string>();
      placeholders.Add("PropagroupOperations.", "{DB_BC}.");
      placeholders.Add("PROPACK_attuale.", "{DB_NAV}.");
      placeholders.Add("[Propack_attuale]", "{DB_NAV}");
      placeholders.Add("[PropagroupOperations]", "{DB_BC}");

      int idCounter = 1;
      queries.Clear();
      MigrationLog.Write("Loading migration file: " + path);
      string readText = File.ReadAllText(path);
      string[] rawQueries = Regex.Split(readText, AppSettingsHelper.Config.TagSplit, RegexOptions.IgnoreCase);
      
      foreach (var rawQuery in rawQueries)
      {
        var rawQueryTrimmed = rawQuery.Trim();
        if (rawQueryTrimmed.Length > 0)
        {
          var q = MigrationQuery.CreateFromRaw(idCounter++, rawQueryTrimmed, AppSettingsHelper.Config.PlaceholderCompany, placeholders);
          if (q != null) queries.Add(q);
          else idCounter--;
        }
      }
      MigrationLog.Write("Migration file loaded");
      MigrationLog.Write("There are " + queries.Count.ToString() + " queries");
    }

    public void LoadMigrationFileNew(string path)
    {
      int idCounter = 1;
      queries.Clear();
      MigrationLog.Write("Loading migration file: " + path);

      string readText = File.ReadAllText(path);
      string[] newQueries = Regex.Split(readText, AppSettingsHelper.Config.TagSplit, RegexOptions.IgnoreCase);
      
      foreach (var newQuery in newQueries)
      {
          MigrationQuery q = new MigrationQuery(idCounter);
          try
          {
            q.InitializeQuery(newQuery);
            queries.Add(q);
            idCounter++;
          }
          catch (Exception ex)
          {
            MigrationLog.Write("ERROR: " + ex.Message);
            MigrationLog.Write("On loading: " + newQuery);
          }
      }
      
      MigrationLog.Write("Migration file loaded");
      MigrationLog.Write("There are " + queries.Count.ToString() + " queries");
    }

    public void ExportMigrationFile(string filePath)
    {
      if (queries.Count == 0)
      {
        MigrationLog.ShowError("Queries not loaded");
        return;
      }

      using (StreamWriter writer = new StreamWriter(filePath))
      {
        foreach (var query in queries)
        {
          writer.WriteLine(AppSettingsHelper.Config.TagSplit);
          writer.WriteLine(query.ToString());
        }
        writer.Close();
      }
    }
  }
}

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

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MigrationTool
{
  static class AppSettingsHelper
  {
    public static AppSettings Config { get; set; }
    public static bool RunQueryOnlyWithCompany { get; set; }
    public static bool Loaded { get; private set; }
    private static IConfiguration configuration;
    public const string AppSettingsNameFile = "appsettings.json";
    public const string AppSettingsSection = "AppSettings";

    public static void LoadFromFile()
    {
      var configurationBuilder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile(AppSettingsNameFile, optional: false);

      configuration = configurationBuilder.Build();
      Config = new AppSettings();
      configuration.GetSection(AppSettingsSection).Bind(Config);
      Loaded = true;
    }

    public static void LogAppSettings()
    {
      MigrationLog.Write("Settings loaded:" + Environment.NewLine + Config.ToString());
    }

    public static void SaveToFile()
    {
      throw new Exception("Not Implemented, edit from file");
    }
  }
  class AppSettings
  {
    public string Connection { get; set; }
    public string TagSplit { get; set; }
    public string Companies { get; set; }
    public string PlaceholderCompany { get; set; }
    public string DBNAV { get; set; }
    public string PlaceholderDBNAV { get; set; }
    public string DBBC { get; set; }
    public string PlaceholderDBBC { get; set; }
    public string LogToShrink { get; set; }
    override public string ToString()
    {
      return "Connection: " + Connection + Environment.NewLine +
              "Tag Split: " + TagSplit + Environment.NewLine +
              "DB NAV: " + DBNAV + Environment.NewLine +
              "DB BC: " + DBBC + Environment.NewLine +
              "Placeholder NAV: " + PlaceholderDBNAV + Environment.NewLine +
              "Placeholder BC: " + PlaceholderDBBC + Environment.NewLine +
              "Companies: " + Companies + Environment.NewLine +
              "Placeholder Company: " + PlaceholderCompany +Environment.NewLine +
              "Log to shrink: " + LogToShrink;
    }
  }
}

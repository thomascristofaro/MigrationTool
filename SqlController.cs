using System;
using System.Data.SqlClient;

namespace MigrationTool
{
  public class SqlController
  {
    static SqlConnection conn = new SqlConnection();

    public static void SetConnectionString(string connection)
    {
      conn = new SqlConnection();
      conn.ConnectionString = connection;
    }

    public static void Connect(string connection)
    {
      conn = new SqlConnection();
      conn.ConnectionString = connection;
      conn.Open();
    }

    public static void Connect()
    {
      conn.Open();
    }
    public static void Disconnect()
    {
      conn.Close();
    }

    public static int RunQuery(string query)
    {
      SqlCommand cmd = new SqlCommand();
      cmd.Connection = conn;
      cmd.CommandText = query;
      cmd.CommandTimeout = 999999;
      return cmd.ExecuteNonQuery();
    }

    public static void ShrinkFile(string db, string log)
    {
      if (String.IsNullOrEmpty(log)) return;
      string shrink_query = 
        @"USE {DB};
          DBCC SHRINKFILE({LOG}, 1);";
      shrink_query = shrink_query.Replace("{DB}", db);
      shrink_query = shrink_query.Replace("{LOG}", log);

      SqlCommand cmd = new SqlCommand();
      cmd.Connection = conn;
      cmd.CommandText = shrink_query;
      cmd.CommandTimeout = 999999;
      cmd.ExecuteNonQuery();
    }
  }
}

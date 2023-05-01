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
  }
}

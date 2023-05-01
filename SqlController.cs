using System;
using System.Data.SqlClient;

namespace MigrationTool
{
  public class SqlController
  {
    static SqlConnection conn = new SqlConnection();
    // static SqlDataReader reader;

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

    public static int RunQuery(string query, int timeout)
    {
      SqlCommand cmd = new SqlCommand();
      cmd.Connection = conn;
      cmd.CommandText = query;
      cmd.CommandTimeout = timeout;
      return cmd.ExecuteNonQuery();
    }
  }
}

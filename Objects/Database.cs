using System.Data;
using System.Data.SqlClient;

namespace ToDoList //replace with your desired namespace
{
  public class DB
  {
    public static SqlConnection Connection()
    {
      SqlConnection conn = new SqlConnection(DBConfiguration.ConnectionString);
      return conn;
    }
  }
}

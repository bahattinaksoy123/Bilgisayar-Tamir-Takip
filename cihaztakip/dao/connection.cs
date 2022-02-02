using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cihaztakip.dao
{
  public static class connection
    {

        public static SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-H14SHNH;Initial Catalog=cihaztakip;Integrated Security=True");

        public static void open()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();
        }

        public static void close()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open) sqlConnection.Close();
        }

    }
}

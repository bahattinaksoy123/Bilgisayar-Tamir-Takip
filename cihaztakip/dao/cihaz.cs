using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cihaztakip.dao
{
  public  class cihaz
    {
        public bool cihazturekle()
        {
            return true;
        }

        public DataTable cihazturleri()
        {
            DataTable table = new DataTable();

            try
            {
               connection.open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from malzeme_tipleri ", connection.sqlConnection);
                sqlDataAdapter.Fill(table);
                return table;
            }
            catch
            {
                return table;
            }
            finally
            {
                connection.close();
            }
        }















            /////////////////////////////////////////////////////////////
    }
}

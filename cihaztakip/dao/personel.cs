using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cihaztakip.dao
{
  public  class personel
    {
        public bool personelkontrol(string tc,string parola)
        {
            try
            {
                dao.connection.open();

                SqlCommand cmd = new SqlCommand($"select password from kisiler where tc = {tc} and personelmi=1", connection.sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr["password"].ToString() == parola) return true;
                else return false;

            }
            catch
            {
                return false;
            }
            finally
            {
                dao.connection.close();
            }
        }


    }
}

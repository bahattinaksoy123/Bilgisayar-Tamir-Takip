using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cihaztakip.dao
{
   public class yer
    {

        public DataTable iller()
        {
            DataTable table = new DataTable();

            try
            {
                connection.open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from yer_iller ", connection.sqlConnection);
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

        public DataTable binalar(string il)
        {
            DataTable table = new DataTable();

            try
            {
                connection.open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"select * from yer_bina where il_id=(select ID from yer_iller where il = '{il}') ", connection.sqlConnection);
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

        public bool subevarmi(string il,string bina_isim)
        {
            DataTable table = new DataTable();

            try
            {
                connection.open();
                SqlCommand cmd = new SqlCommand($"select altsube_varmi from yer_bina where il_id=(select ID from yer_iller where il = '{il}') and bina_isim = '{bina_isim}' ", connection.sqlConnection);
               SqlDataReader dr= cmd.ExecuteReader();
                dr.Read();
                if (dr["altsube_varmi"].ToString() == "True")

                    return true;
                else return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.close();
            }
        }

        public DataTable subeler(string il,string bina_isim)
        {
            DataTable table = new DataTable();

            try
            {
                connection.open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"select alt_sube_ad from yer_alt_sube where il_id=(select ID from yer_iller where il = '{il}') and yer_bina_id= (select ID from yer_bina where bina_isim = '{bina_isim}')", connection.sqlConnection);
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



        //////////////////////////////////////////////////////////////////////////////////////////////////

    }
}

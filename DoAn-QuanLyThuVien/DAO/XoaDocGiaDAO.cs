using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class XoaDocGiaDAO
    {
        public int XoaDocDia(string tendn)
        {
            SqlConnection connect = new SqlConnection();
            SqlConnectionString constring = new SqlConnectionString();
            connect = SqlConnectionString.HamKetNoi();
            connect.Open();
            SqlCommand cmd = new SqlCommand("sp_xoadocgia", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@hoten", SqlDbType.NVarChar);
            cmd.Parameters["@hoten"].Value = tendn;
            int k = cmd.ExecuteNonQuery();
            connect.Close();
            if (k > 0)
            {
                return k;
            }
            return 0;
        }
    }
}

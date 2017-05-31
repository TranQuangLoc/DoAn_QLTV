using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class XoaNhanVienDAO
    {
        public int XoaNhanVien(string tendn) {
            SqlConnection connect = new SqlConnection();
            SqlConnectionString constring = new SqlConnectionString();
            connect = SqlConnectionString.HamKetNoi();
            connect.Open();
            SqlCommand cmd = new SqlCommand("sp_xoanhanvien", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tendn", SqlDbType.NVarChar);
            cmd.Parameters["@tendn"].Value = tendn;
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

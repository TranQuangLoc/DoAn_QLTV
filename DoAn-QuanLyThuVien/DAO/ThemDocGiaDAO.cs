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
    public class ThemDocGiaDAO
    {
        public int ThemDocGia(TheDocGia_DTO dtonv)
        {
            int k = -1;
            SqlConnection connect = new SqlConnection();
            SqlConnectionString constring = new SqlConnectionString();
            connect = SqlConnectionString.HamKetNoi();
            connect.Open();
            SqlCommand cmd = new SqlCommand("sp_themdocgia", connect);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@hoten", SqlDbType.NVarChar);
            cmd.Parameters.Add("@tennv", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ngaysinh", SqlDbType.DateTime);
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar);
            cmd.Parameters.Add("@email", SqlDbType.NChar);
            cmd.Parameters.Add("@ngaylapthe", SqlDbType.DateTime);
            cmd.Parameters.Add("@maloai", SqlDbType.Int);
           
            cmd.Parameters["@hoten"].Value = dtonv.Hoten;
            cmd.Parameters["@tennv"].Value = dtonv.Tennv;
            cmd.Parameters["@ngaysinh"].Value = dtonv.Ngaysinh;
            cmd.Parameters["@diachi"].Value = dtonv.Diachi;
            cmd.Parameters["@email"].Value = dtonv.Email;
            cmd.Parameters["@ngaylapthe"].Value = dtonv.Ngaylapthe;
            cmd.Parameters["@maloai"].Value = dtonv.Maloai;
           
            k = cmd.ExecuteNonQuery();
            connect.Close();
            if (k > 0)
            {
                return k;
            }

            return 0;

        }
    }
}

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
    public class SuaThongTinNhanVienDAO
    {
        public int SuaNhanVien(DangNhap_DTO dtonv)
        {
            int k = -1;
            SqlConnection connect = new SqlConnection();
            SqlConnectionString constring = new SqlConnectionString();
            connect = SqlConnectionString.HamKetNoi();
            connect.Open();
            SqlCommand cmd = new SqlCommand("sp_updatethongtinnv", connect);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tendn", SqlDbType.NVarChar);
            cmd.Parameters.Add("@pass", SqlDbType.NChar);
            cmd.Parameters.Add("@permiss", SqlDbType.Int);
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar);
            cmd.Parameters.Add("@sodienthoai", SqlDbType.NChar);
            cmd.Parameters.Add("@bophan", SqlDbType.NVarChar);
            cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar);
            cmd.Parameters.Add("@bangcap", SqlDbType.NVarChar);
            cmd.Parameters.Add("@ngaysinh", SqlDbType.NChar);
            cmd.Parameters["@tendn"].Value = dtonv._tendn;
            cmd.Parameters["@pass"].Value = dtonv._pass;
            cmd.Parameters["@permiss"].Value = dtonv._permiss;
            cmd.Parameters["@diachi"].Value = dtonv._diachi;
            cmd.Parameters["@sodienthoai"].Value = dtonv._sodienthoai;
            cmd.Parameters["@bophan"].Value = dtonv._bophan;
            cmd.Parameters["@chucvu"].Value = dtonv._chucvu;
            cmd.Parameters["@bangcap"].Value = dtonv._bangcap;
            cmd.Parameters["@ngaysinh"].Value = dtonv._ngaysinh;
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

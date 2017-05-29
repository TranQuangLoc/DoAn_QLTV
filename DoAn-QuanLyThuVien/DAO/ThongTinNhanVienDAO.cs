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
    public class ThongTinNhanVienDAO
    {
        public DataTable LayTatCaNhanVien() {
            SqlConnection connect = new SqlConnection();
            SqlConnectionString constring = new SqlConnectionString();
            connect = SqlConnectionString.HamKetNoi();
            connect.Open();
            SqlCommand cmd = new SqlCommand("sp_thongtinnhanvien",connect);
            DataTable dtb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtb);
            connect.Close();
            return dtb;
        }
        
    }
}

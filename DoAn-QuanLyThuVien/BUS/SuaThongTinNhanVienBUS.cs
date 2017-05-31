using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;
namespace BUS
{
   public class SuaThongTinNhanVienBUS
    {
        public int SuaNhanVien(DangNhap_DTO dtonvbus)
        {
            SuaThongTinNhanVienDAO nv = new SuaThongTinNhanVienDAO();
            int k = nv.SuaNhanVien(dtonvbus);
            return k;
        }
    }
}

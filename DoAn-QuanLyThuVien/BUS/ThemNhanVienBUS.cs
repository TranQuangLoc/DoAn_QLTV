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
   public class ThemNhanVienBUS
    {
        public int ThemNhanVien(DangNhap_DTO dtonvbus) {
            ThemNhanVienDAO nv = new ThemNhanVienDAO();
            int k = nv.ThemNhanVien(dtonvbus);
            return k;
        }
    }
}

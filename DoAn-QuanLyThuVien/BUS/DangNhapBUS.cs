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
    public class DangNhapBUS
    {
        public DangNhap_DTO KiemtraUserBUS(string tendnbus, string passbus)
        {
            DangNhapDAO da = new DangNhapDAO();
            DangNhap_DTO dn = da.KiemtraUser(tendnbus, passbus);
            return dn;
        }
    }
}

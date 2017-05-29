using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
namespace BUS
{
    public class ThongTinNhanVienBUS
    {
        public DataTable LayThongTinNhanVien() {
            ThongTinNhanVienDAO nvd = new ThongTinNhanVienDAO();
            DataTable nv = nvd.LayTatCaNhanVien();
            return nv;
        }
    }
}

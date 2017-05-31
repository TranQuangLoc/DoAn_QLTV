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
    public class DanhSachDocGiaBUS
    {
        public DataTable LayDanhSachSach()
        {
            DanhSachDocGiaDAO nvd = new DanhSachDocGiaDAO();
            DataTable nv = nvd.LayTatCaSach();
            return nv;
        }
    }
}

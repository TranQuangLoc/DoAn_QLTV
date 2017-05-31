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
    public class ThongTinSachBUS
    {
        public DataTable LayThongTinSach()
        {
            ThongTinSachDAO nvd = new ThongTinSachDAO();
            DataTable nv = nvd.LayTatCaSach();
            return nv;
        }
    }
}

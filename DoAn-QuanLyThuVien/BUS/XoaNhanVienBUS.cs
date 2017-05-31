using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class XoaNhanVienBUS
    {
        public int XoaNhanVien(string tendn) {
            XoaNhanVienDAO dao = new XoaNhanVienDAO();
            int k = dao.XoaNhanVien(tendn);
            return k;
        }
    }
}

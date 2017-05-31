using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class XoaDocGiaBUS
    {
        public int XoaDocGia(string tendn)
        {
            XoaDocGiaDAO dao = new XoaDocGiaDAO();
            int k = dao.XoaDocDia(tendn);
            return k;
        }
    }
}

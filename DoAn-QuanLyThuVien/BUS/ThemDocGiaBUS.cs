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
    public class ThemDocGiaBUS
    {
        public int ThemDocGia(TheDocGia_DTO dto)
        {
            ThemDocGiaDAO nvd = new ThemDocGiaDAO();
            int k = nvd.ThemDocGia(dto);
            return k;
        }
    }
}

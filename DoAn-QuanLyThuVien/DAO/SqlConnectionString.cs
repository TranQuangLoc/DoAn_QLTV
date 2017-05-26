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
    public class SqlConnectionString
    {
        public static SqlConnection HamKetNoi() {
            SqlConnection connect = new SqlConnection(@"Data Source=TranQuangLoc;Initial Catalog=DoAnQLThuVien;Integrated Security=True");
            return connect;
        }


    }
}

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
    public class LaySoReCodeBUS
    {
        public DataSet LayRecoreb()
        {
            LaySoRecoreDAO da = new LaySoRecoreDAO();
            return da.LayRecore();
        }
    }
}

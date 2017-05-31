using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using VariablePaging;
using LayTongSoTrang;
using DTO;

namespace DAO
{
   public class LayTongSoDongDAO : SqlConnectionString
    {
        public int LayTongSoDong()
        {
            SqlConnection conn = new SqlConnection();
            conn = HamKetNoi();
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_LaySoDong", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            KhaiBaoBienRC.rows = Convert.ToInt32(cmd.ExecuteScalar());
            LayTongSoTrang.LaySoTrang.pageTotal();
            conn.Close();
            return KhaiBaoBienRC.rows;
        }
    }
}

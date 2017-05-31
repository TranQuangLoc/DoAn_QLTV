using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class LaySoRecoreDAO : SqlConnectionString
    {
        public DataSet LayRecore()
        {
            SqlConnection conn = new SqlConnection();
            conn = HamKetNoi();
            conn.Open();
            VariablePaging.KhaiBaoBienRC.fistRow = VariablePaging.KhaiBaoBienRC.pageSize * (VariablePaging.KhaiBaoBienRC.currentPageIndex - 1); //Dòng đầu
            VariablePaging.KhaiBaoBienRC.lastRow = VariablePaging.KhaiBaoBienRC.pageSize * (VariablePaging.KhaiBaoBienRC.currentPageIndex);//Dòng cuối cùng của trang được chọn            
            SqlCommand cmd = new SqlCommand("sp_LaySoRecode", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, VariablePaging.KhaiBaoBienRC.fistRow, VariablePaging.KhaiBaoBienRC.pageSize, "masach"); //Lấy dữ liệu về từ dòng thứ fistRow và lấy pageSize dòng           
            conn.Close();
            return ds;
        }
    }
}

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
    public class DangNhapDAO :SqlConnectionString
    {
        public DangNhap_DTO KiemtraUser(string tendn, string pass)
        {
            SqlConnection cnn = new SqlConnection();
            cnn = HamKetNoi();
            cnn.Open();

            SqlCommand cmd = new SqlCommand("sp_Kiemtrauser", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tendn", SqlDbType.NVarChar);
            cmd.Parameters["@tendn"].Value = tendn;
            cmd.Parameters.Add("@password", SqlDbType.NChar);
            cmd.Parameters["@password"].Value = pass;
            SqlDataReader re = cmd.ExecuteReader();
            DangNhap_DTO dndto = null;
            if (re.Read())
            {
                dndto = new DangNhap_DTO();
                dndto._tendn = tendn;
                dndto._pass = (string)re["PassWord"];
                dndto._permiss = (int)re["Permission"];
            }
            cnn.Close();
            return dndto;

        }

    }
}

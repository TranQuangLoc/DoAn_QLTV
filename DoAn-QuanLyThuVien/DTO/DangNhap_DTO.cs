using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangNhap_DTO
    {
        private string tendn;
        public string _tendn {
            get { return tendn; }
            set { tendn = value; }
        }

        private string pass;
        public string _pass {
            get { return pass; }
            set { pass = value; }
        }

        private int permiss;
        public int _permiss
        {
            get { return permiss; }
            set { permiss = value; }
        }

        private string diachi;
        public string _diachi {
            get { return diachi; }
            set { diachi = value; }
        }

        private string sodienthoai;
        public string _sodienthoai {
            get { return sodienthoai; }
            set { sodienthoai = value; }
        }

        private string bophan;
        public string _bophan
        {
            get { return bophan; }
            set { bophan = value; }
        }

        private string chucvu;
        public string _chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }

        private string bangcap;
        public string _bangcap
        {
            get { return bangcap; }
            set { bangcap = value; }
        }
        private string ngaysinh;
        public string _ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public DangNhap_DTO() {
        }
        public DangNhap_DTO(string s_tendn,string s_pass,int i_perrmiss, string s_diachi, string s_sodienthoai, string s_bophan, string s_chucvu,string s_bangcap,string s_ngaysinh) {
            _tendn = s_tendn;
            _pass = s_pass;
            _permiss = i_perrmiss;
            _diachi = s_diachi;
            _sodienthoai = s_sodienthoai;
            _bophan = s_bophan;
            _chucvu = s_chucvu;
            _bangcap = s_bangcap;
            _ngaysinh = s_ngaysinh;

        }
    }

   
}

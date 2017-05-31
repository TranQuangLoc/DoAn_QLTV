using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheDocGia_DTO
    {
        private string hoten;
        private string tennv;
        private int masothe;
        private string ngaysinh;
        private string diachi;
        private string email;
        private string ngaylapthe;
        private int maloai;

        public string Hoten
        {
            get
            {
                return hoten;
            }

            set
            {
                hoten = value;
            }
        }

        public string Tennv
        {
            get
            {
                return tennv;
            }

            set
            {
                tennv = value;
            }
        }

        public int Masothe
        {
            get
            {
                return masothe;
            }

            set
            {
                masothe = value;
            }
        }

        public string Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Ngaylapthe
        {
            get
            {
                return ngaylapthe;
            }

            set
            {
                ngaylapthe = value;
            }
        }

        public int Maloai
        {
            get
            {
                return maloai;
            }

            set
            {
                maloai = value;
            }
        }

        public TheDocGia_DTO(string s_hoten, string s_tennv,int i_masothe,string s_ngaysinh,string s_diachi, string s_email,string s_ngaylapthe, int i_maloai) {
            Hoten = s_hoten;
            Tennv = s_tennv;
            Masothe = i_masothe;
            Ngaysinh = s_ngaysinh;
            Diachi = s_diachi;
            Email = s_email;
            Ngaylapthe = s_ngaylapthe;
            Maloai = i_maloai;
        }

        public TheDocGia_DTO() {

        }
    }
}

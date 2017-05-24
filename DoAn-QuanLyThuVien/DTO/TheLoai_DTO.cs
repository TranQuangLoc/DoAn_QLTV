using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheLoai_DTO
    {
        private int matheloai;
        private string tentheloai;

        public int Matheloai
        {
            get
            {
                return matheloai;
            }

            set
            {
                matheloai = value;
            }
        }

        public string Tentheloai
        {
            get
            {
                return tentheloai;
            }

            set
            {
                tentheloai = value;
            }
        }

        public TheLoai_DTO(int i_matheloai, string s_tentheloai) {
            Matheloai = i_matheloai;
            Tentheloai = s_tentheloai;
        }
    }
}

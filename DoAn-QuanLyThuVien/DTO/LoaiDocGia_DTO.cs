using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiDocGia_DTO
    {
        private int maloai;
        private string tenloai;

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

        public string Tenloai
        {
            get
            {
                return tenloai;
            }

            set
            {
                tenloai = value;
            }
        }

        public LoaiDocGia_DTO(int i_maloai, string s_tenloai) {
            Maloai = i_maloai;
            Tenloai = s_tenloai;
        }
    }
}

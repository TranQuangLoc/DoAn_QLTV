using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Sach_DTO
    {
        private int masach;
        private string tensach;
        private int matheloai;
        private string tentacgia;
        private int namxuatban;
        private string nhaxuatban;
        private float giasach;
        private int soluong;
        private string tinhtrang;

        public int Masach
        {
            get
            {
                return masach;
            }

            set
            {
                masach = value;
            }
        }

        public string Tensach
        {
            get
            {
                return tensach;
            }

            set
            {
                tensach = value;
            }
        }

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

        public string Tentacgia
        {
            get
            {
                return tentacgia;
            }

            set
            {
                tentacgia = value;
            }
        }

        public int Namxuatban
        {
            get
            {
                return namxuatban;
            }

            set
            {
                namxuatban = value;
            }
        }

        public string Nhaxuatban
        {
            get
            {
                return nhaxuatban;
            }

            set
            {
                nhaxuatban = value;
            }
        }

        public float Giasach
        {
            get
            {
                return giasach;
            }

            set
            {
                giasach = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public string Tinhtrang
        {
            get
            {
                return tinhtrang;
            }

            set
            {
                tinhtrang = value;
            }
        }

        public Sach_DTO(int i_masach,string s_tensach,int i_matheloai, string s_tentacgia, int i_namxuatban, string s_nhaxuatban, float f_giasach,int i_soluong, string s_tinhtrang) {

        }
    }
}

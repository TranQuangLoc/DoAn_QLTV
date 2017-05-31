using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyThuVien
{
    public partial class GiamDoc : Form
    {
        public GiamDoc()
        {
            InitializeComponent();
        }

        private void btnthongtinnv_Click(object sender, EventArgs e)
        {
            ThongTinNhanVien ad = new ThongTinNhanVien();
            this.Visible = false;
            ad.Show();
        }

        private void btnquanlysach_Click(object sender, EventArgs e)
        {

            fr_ThongTinSach s = new fr_ThongTinSach();
            this.Visible = false;
            s.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace DoAn_QuanLyThuVien
{
    public partial class fr_ThongTinSach : Form
    {
        public fr_ThongTinSach()
        {
            InitializeComponent();
        }

        private void fr_ThongTinSach_Load(object sender, EventArgs e)
        {
            ThongTinSachBUS nvb = new ThongTinSachBUS();
            dtg_thongTinSach.DataSource = nvb.LayThongTinSach();
        }
    }
}

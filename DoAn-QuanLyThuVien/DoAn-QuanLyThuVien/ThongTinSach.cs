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
            LaySoDongBUS bus = new LaySoDongBUS();
            bus.LayTongSoDongb();
            DoduLieu();
        }

        private void DoduLieu()
        {
            int k = Int32.Parse(VariablePaging.KhaiBaoBienRC.pageNumber.ToString());
            
            
            cbbcurrentpage.Items.Clear();
            for (int i = 1; i <= k; i++)
            {
                cbbcurrentpage.Items.Add(i + "");
            }
            cbbcurrentpage.SelectedIndex = 0;
        }

        private void cbbcurrentpage_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbltotalpage.Text = cbbcurrentpage.SelectedItem.ToString();
            lbltotalpage.Text = lbltotalpage.Text+" / " + VariablePaging.KhaiBaoBienRC.pageNumber.ToString();
            VariablePaging.KhaiBaoBienRC.currentPageIndex = Convert.ToInt32(cbbcurrentpage.Text);
            LaySoReCodeBUS bus = new LaySoReCodeBUS();
            dtg_thongTinSach.DataSource = bus.LayRecoreb().Tables[0];
        }
    }
}

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
using DTO;
using Session;

namespace DoAn_QuanLyThuVien
{
    public partial class fr_dangnhap : Form
    {
        public fr_dangnhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            DangNhap_DTO dnn = new DangNhap_DTO();
            DangNhapBUS dnbus = new DangNhapBUS();
            dnn = dnbus.KiemtraUserBUS(txt_tenDangNhap.Text.ToString(), txt_pass.Text.ToString());
            if (dnn != null)
            {
                SessionLogin.SessionUsername = txt_tenDangNhap.Text.ToString();
                SessionLogin.SessionPassWord = txt_pass.Text.ToString().Trim();
                //Xử lý chuyển màn hình...   
                if (dnn._permiss == 1)
                {
                    ThongTinNhanVien ad = new ThongTinNhanVien();
                    this.Visible = false;
                    ad.Show();
                }
                else
                {
                    ThongTinNhanVien s = new ThongTinNhanVien();
                    this.Visible = false;
                    s.ShowDialog();
                }
            }
            else
            {
                txt_tenDangNhap.Focus();
            }
        }
    }
}

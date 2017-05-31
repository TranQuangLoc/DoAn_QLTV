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
namespace DoAn_QuanLyThuVien
{
    public partial class ThongTinNhanVien : Form
    {
        public ThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            ThongTinNhanVienBUS nvb = new ThongTinNhanVienBUS();
            dtg_ThongTinNhanVien.DataSource = nvb.LayThongTinNhanVien();
            dtg_ThongTinNhanVien.Columns["xoanv"].DisplayIndex = 7;
        }

        private void dtg_ThongTinNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int index = dtg_ThongTinNhanVien.CurrentCell.RowIndex;
            string tendn = dtg_ThongTinNhanVien.Rows[index].Cells["tendn"].Value.ToString().Trim();
           
            //Lấy vị trí cột
            int columnIndex = dtg_ThongTinNhanVien.CurrentCell.ColumnIndex;
            //MessageBox.Show(columnIndex.ToString());
            //Lấy tên cột
            string columnNameCellClick = dtg_ThongTinNhanVien.Columns[columnIndex].HeaderText;

            string hoten = dtg_ThongTinNhanVien.Rows[index].Cells["tendn"].Value.ToString().Trim();
            string diachi = dtg_ThongTinNhanVien.Rows[index].Cells["diachi"].Value.ToString().Trim();
            string sodienthoai = dtg_ThongTinNhanVien.Rows[index].Cells["sodienthoai"].Value.ToString().Trim();
            string ngaysinh = dtg_ThongTinNhanVien.Rows[index].Cells["ngaysinh"].Value.ToString().Trim();
            string bangcap = dtg_ThongTinNhanVien.Rows[index].Cells["bangcap"].Value.ToString().Trim();
            string chucvu = dtg_ThongTinNhanVien.Rows[index].Cells["chucvu"].Value.ToString().Trim();
            string bophan = dtg_ThongTinNhanVien.Rows[index].Cells["bophan"].Value.ToString().Trim();
            string permis = dtg_ThongTinNhanVien.Rows[index].Cells["permis"].Value.ToString().Trim();
            string pass = dtg_ThongTinNhanVien.Rows[index].Cells["pass"].Value.ToString().Trim();

            txt_hoTen.Text = hoten;
            txt_diaChi.Text = diachi;
            txt_dienThoai.Text = sodienthoai;
            txtngaysinh.Text = ngaysinh;
            txt_bangCap.Text = bangcap;


            if (e.ColumnIndex == 0)
            {
                //Xử Lý Thêm Sách                
                DialogResult rs = MessageBox.Show("Bạn Muốn Mua Xóa Nhân Viên " + tendn + " ?", "Xóa Nhân Viên", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    XoaNhanVienBUS bus = new XoaNhanVienBUS();
                    bus.XoaNhanVien(tendn);
                }
               
            }
            ThongTinNhanVien_Load(sender, e);
        }

        private void btn_themNV_Click(object sender, EventArgs e)
        {
            ThemNhanVienBUS nvbus = new ThemNhanVienBUS();
            DangNhap_DTO dtonv = new DangNhap_DTO();
            dtonv._tendn = txt_hoTen.Text;
            dtonv._pass = txtpass.Text;
            dtonv._permiss =  Int32.Parse(cbbpermis.SelectedItem.ToString());
            dtonv._diachi = txt_diaChi.Text;
            dtonv._sodienthoai = txt_dienThoai.Text;
            dtonv._bophan = cbbbophan.SelectedItem.ToString();
            dtonv._chucvu = cbbchucvu.SelectedItem.ToString();
            dtonv._bangcap = txt_bangCap.Text;
            dtonv._ngaysinh = txtngaysinh.Text;

           int k = nvbus.ThemNhanVien(dtonv);
            if (k > 0) {
                MessageBox.Show("Bạn đã thêm thành công");
            }else
            {
                MessageBox.Show("Không thể thêm nhân viên");
            }
            ThongTinNhanVien_Load(sender,e);
        }

        private void btn_suaNV_Click(object sender, EventArgs e)
        {
            SuaThongTinNhanVienBUS nvbus = new SuaThongTinNhanVienBUS();
            DangNhap_DTO dtonv = new DangNhap_DTO();

            

            if (dtonv._pass == "" || dtonv._permiss.ToString() == "" || dtonv._bophan == "" || dtonv._chucvu == "")
            {
                MessageBox.Show("Bạn Nhập Không Đủ Dữ Liệu ");
            }
            else {
                dtonv._tendn = txt_hoTen.Text;//
                dtonv._pass = txtpass.Text;
                dtonv._permiss = Int32.Parse(cbbpermis.SelectedItem.ToString());
                dtonv._diachi = txt_diaChi.Text;//
                dtonv._sodienthoai = txt_dienThoai.Text;//
                dtonv._bophan = cbbbophan.SelectedItem.ToString();
                dtonv._chucvu = cbbchucvu.SelectedItem.ToString();
                dtonv._bangcap = txt_bangCap.Text;//
                dtonv._ngaysinh = txtngaysinh.Text;//
                int k = nvbus.SuaNhanVien(dtonv);
                if (k > 0)
                {
                    MessageBox.Show("Bạn đã sửa thành công");
                }
                else
                {
                    MessageBox.Show("Không thể sửa nhân viên");
                }
            }
            
            ThongTinNhanVien_Load(sender, e);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            GiamDoc ad = new GiamDoc();
            this.Visible = false;
            ad.Show();
        }
    }
}

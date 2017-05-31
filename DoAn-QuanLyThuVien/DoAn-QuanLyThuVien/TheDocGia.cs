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
    public partial class fr_TheDocGia : Form
    {
        public fr_TheDocGia()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fr_TheDocGia_Load(object sender, EventArgs e)
        {
            DanhSachDocGiaBUS nvb = new DanhSachDocGiaBUS();
            dtg_theDocGia.DataSource = nvb.LayDanhSachSach();
            txt_nguoiLap.Text = Session.SessionLogin.SessionUsername;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ThemDocGiaBUS nvbus = new ThemDocGiaBUS();
            TheDocGia_DTO dtonv = new TheDocGia_DTO();
            dtonv.Hoten = txt_hoTen.Text;
            dtonv.Tennv = txt_nguoiLap.Text;
            dtonv.Ngaysinh = dtngaysinh.Text;
            dtonv.Diachi = txt_diaChi.Text;
            dtonv.Email = txt_email.Text;
            dtonv.Ngaylapthe = dtngaylap.Text;
            dtonv.Maloai = Int32.Parse(cbbloaidocgia.SelectedItem.ToString());
           
            int k = nvbus.ThemDocGia(dtonv);
            if (k > 0)
            {
                MessageBox.Show("Bạn đã thêm thành công");
            }
            else
            {
                MessageBox.Show("Không thể thêm nhân viên");
            }
            fr_TheDocGia_Load(sender, e);
        }

        private void dtg_theDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtg_theDocGia.CurrentCell.RowIndex;
            string tendn = dtg_theDocGia.Rows[index].Cells["hoten"].Value.ToString().Trim();

            //Lấy vị trí cột
            int columnIndex = dtg_theDocGia.CurrentCell.ColumnIndex;
            //MessageBox.Show(columnIndex.ToString());
            //Lấy tên cột
            string columnNameCellClick = dtg_theDocGia.Columns[columnIndex].HeaderText;

           
            if (e.ColumnIndex == 0)
            {
                //Xử Lý Thêm Sách                
                DialogResult rs = MessageBox.Show("Bạn Muốn Mua Xóa Độc Giả " + tendn + " ?", "Xóa Độc Giả", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    XoaDocGiaBUS bus = new XoaDocGiaBUS();
                    bus.XoaDocGia(tendn);
                }

            }
            fr_TheDocGia_Load(sender, e);
        }
    }
}

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
            int masach = Int32.Parse(dtg_ThongTinNhanVien.Rows[index].Cells["tendn"].Value.ToString().Trim());
            //Lấy vị trí cột
            int columnIndex = dtg_ThongTinNhanVien.CurrentCell.ColumnIndex;
            //Lấy tên cột
            string columnNameCellClick = dtg_ThongTinNhanVien.Columns[columnIndex].HeaderText;
            string chucvu = dtg_ThongTinNhanVien.Rows[index].Cells["chucvu"].Value.ToString().Trim();
            string bophan = dtg_ThongTinNhanVien.Rows[index].Cells["bophan"].Value.ToString().Trim();

            if (e.ColumnIndex == 7)
            {
                //Xử Lý Thêm Sách                
                DialogResult rs = MessageBox.Show("Bạn Muốn Mua Xóa Nhân Viên " + tendn + " ?", "Xóa Nhân Viên", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    
                }
                //ChiTietGioHang_Load(sender, e);
            }
        }

        private void btn_themNV_Click(object sender, EventArgs e)
        {

        }
    }
}

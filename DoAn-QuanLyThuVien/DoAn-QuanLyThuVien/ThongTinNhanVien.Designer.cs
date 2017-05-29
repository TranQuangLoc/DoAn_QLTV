namespace DoAn_QuanLyThuVien
{
    partial class ThongTinNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_ThongTinNhanVien = new System.Windows.Forms.Label();
            this.lb_HoTen = new System.Windows.Forms.Label();
            this.lb_NgaySinh = new System.Windows.Forms.Label();
            this.lb_bangCap = new System.Windows.Forms.Label();
            this.lb_chucVu = new System.Windows.Forms.Label();
            this.lb_dicChi = new System.Windows.Forms.Label();
            this.lb_dienThoai = new System.Windows.Forms.Label();
            this.lb_boPhan = new System.Windows.Forms.Label();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.txt_bangCap = new System.Windows.Forms.TextBox();
            this.txt_chucVu = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_dienThoai = new System.Windows.Forms.TextBox();
            this.txt_boPhan = new System.Windows.Forms.TextBox();
            this.dtg_ThongTinNhanVien = new System.Windows.Forms.DataGridView();
            this.btn_themNV = new System.Windows.Forms.Button();
            this.btn_suaNV = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tendn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoanv = new System.Windows.Forms.DataGridViewLinkColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bophan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bangcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ThongTinNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_ThongTinNhanVien
            // 
            this.lb_ThongTinNhanVien.AutoSize = true;
            this.lb_ThongTinNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThongTinNhanVien.ForeColor = System.Drawing.Color.Blue;
            this.lb_ThongTinNhanVien.Location = new System.Drawing.Point(396, 17);
            this.lb_ThongTinNhanVien.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_ThongTinNhanVien.Name = "lb_ThongTinNhanVien";
            this.lb_ThongTinNhanVien.Size = new System.Drawing.Size(553, 63);
            this.lb_ThongTinNhanVien.TabIndex = 0;
            this.lb_ThongTinNhanVien.Text = "Thông Tin Nhân Viên";
            // 
            // lb_HoTen
            // 
            this.lb_HoTen.AutoSize = true;
            this.lb_HoTen.Location = new System.Drawing.Point(92, 149);
            this.lb_HoTen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_HoTen.Name = "lb_HoTen";
            this.lb_HoTen.Size = new System.Drawing.Size(135, 32);
            this.lb_HoTen.TabIndex = 1;
            this.lb_HoTen.Text = "Họ và tên";
            // 
            // lb_NgaySinh
            // 
            this.lb_NgaySinh.AutoSize = true;
            this.lb_NgaySinh.Location = new System.Drawing.Point(92, 242);
            this.lb_NgaySinh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_NgaySinh.Name = "lb_NgaySinh";
            this.lb_NgaySinh.Size = new System.Drawing.Size(146, 32);
            this.lb_NgaySinh.TabIndex = 2;
            this.lb_NgaySinh.Text = "Ngày Sinh";
            // 
            // lb_bangCap
            // 
            this.lb_bangCap.AutoSize = true;
            this.lb_bangCap.Location = new System.Drawing.Point(92, 349);
            this.lb_bangCap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_bangCap.Name = "lb_bangCap";
            this.lb_bangCap.Size = new System.Drawing.Size(141, 32);
            this.lb_bangCap.TabIndex = 3;
            this.lb_bangCap.Text = "Bằng Cấp";
            // 
            // lb_chucVu
            // 
            this.lb_chucVu.AutoSize = true;
            this.lb_chucVu.Location = new System.Drawing.Point(92, 461);
            this.lb_chucVu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_chucVu.Name = "lb_chucVu";
            this.lb_chucVu.Size = new System.Drawing.Size(123, 32);
            this.lb_chucVu.TabIndex = 4;
            this.lb_chucVu.Text = "Chức Vụ";
            // 
            // lb_dicChi
            // 
            this.lb_dicChi.AutoSize = true;
            this.lb_dicChi.Location = new System.Drawing.Point(806, 151);
            this.lb_dicChi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_dicChi.Name = "lb_dicChi";
            this.lb_dicChi.Size = new System.Drawing.Size(108, 32);
            this.lb_dicChi.TabIndex = 5;
            this.lb_dicChi.Text = "Địa Chỉ";
            // 
            // lb_dienThoai
            // 
            this.lb_dienThoai.AutoSize = true;
            this.lb_dienThoai.Location = new System.Drawing.Point(806, 244);
            this.lb_dienThoai.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_dienThoai.Name = "lb_dienThoai";
            this.lb_dienThoai.Size = new System.Drawing.Size(153, 32);
            this.lb_dienThoai.TabIndex = 6;
            this.lb_dienThoai.Text = "Điện Thoại";
            // 
            // lb_boPhan
            // 
            this.lb_boPhan.AutoSize = true;
            this.lb_boPhan.Location = new System.Drawing.Point(806, 356);
            this.lb_boPhan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_boPhan.Name = "lb_boPhan";
            this.lb_boPhan.Size = new System.Drawing.Size(124, 32);
            this.lb_boPhan.TabIndex = 7;
            this.lb_boPhan.Text = "Bộ Phận";
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Location = new System.Drawing.Point(252, 143);
            this.txt_hoTen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(468, 38);
            this.txt_hoTen.TabIndex = 8;
            // 
            // txt_bangCap
            // 
            this.txt_bangCap.Location = new System.Drawing.Point(252, 349);
            this.txt_bangCap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_bangCap.Name = "txt_bangCap";
            this.txt_bangCap.Size = new System.Drawing.Size(468, 38);
            this.txt_bangCap.TabIndex = 10;
            // 
            // txt_chucVu
            // 
            this.txt_chucVu.Location = new System.Drawing.Point(252, 455);
            this.txt_chucVu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_chucVu.Name = "txt_chucVu";
            this.txt_chucVu.Size = new System.Drawing.Size(468, 38);
            this.txt_chucVu.TabIndex = 11;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(1040, 151);
            this.txt_diaChi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(478, 38);
            this.txt_diaChi.TabIndex = 12;
            // 
            // txt_dienThoai
            // 
            this.txt_dienThoai.Location = new System.Drawing.Point(1040, 244);
            this.txt_dienThoai.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_dienThoai.Name = "txt_dienThoai";
            this.txt_dienThoai.Size = new System.Drawing.Size(478, 38);
            this.txt_dienThoai.TabIndex = 13;
            // 
            // txt_boPhan
            // 
            this.txt_boPhan.Location = new System.Drawing.Point(1040, 349);
            this.txt_boPhan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_boPhan.Name = "txt_boPhan";
            this.txt_boPhan.Size = new System.Drawing.Size(478, 38);
            this.txt_boPhan.TabIndex = 14;
            // 
            // dtg_ThongTinNhanVien
            // 
            this.dtg_ThongTinNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ThongTinNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tendn,
            this.xoanv,
            this.diachi,
            this.sodienthoai,
            this.bophan,
            this.chucvu,
            this.bangcap,
            this.ngaysinh});
            this.dtg_ThongTinNhanVien.Location = new System.Drawing.Point(24, 564);
            this.dtg_ThongTinNhanVien.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtg_ThongTinNhanVien.Name = "dtg_ThongTinNhanVien";
            this.dtg_ThongTinNhanVien.RowTemplate.Height = 24;
            this.dtg_ThongTinNhanVien.Size = new System.Drawing.Size(1580, 291);
            this.dtg_ThongTinNhanVien.TabIndex = 15;
            this.dtg_ThongTinNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ThongTinNhanVien_CellContentClick);
            // 
            // btn_themNV
            // 
            this.btn_themNV.Location = new System.Drawing.Point(1040, 438);
            this.btn_themNV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_themNV.Name = "btn_themNV";
            this.btn_themNV.Size = new System.Drawing.Size(207, 70);
            this.btn_themNV.TabIndex = 16;
            this.btn_themNV.Text = "Thêm";
            this.btn_themNV.UseVisualStyleBackColor = true;
            this.btn_themNV.Click += new System.EventHandler(this.btn_themNV_Click);
            // 
            // btn_suaNV
            // 
            this.btn_suaNV.Location = new System.Drawing.Point(1329, 438);
            this.btn_suaNV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_suaNV.Name = "btn_suaNV";
            this.btn_suaNV.Size = new System.Drawing.Size(189, 70);
            this.btn_suaNV.TabIndex = 17;
            this.btn_suaNV.Text = "Sửa";
            this.btn_suaNV.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(252, 231);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(468, 38);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // tendn
            // 
            this.tendn.DataPropertyName = "tendn";
            this.tendn.HeaderText = "Tên";
            this.tendn.Name = "tendn";
            // 
            // xoanv
            // 
            this.xoanv.HeaderText = "Xóa";
            this.xoanv.Name = "xoanv";
            this.xoanv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xoanv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xoanv.Text = "Xóa Nhân Viên";
            this.xoanv.UseColumnTextForLinkValue = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            // 
            // sodienthoai
            // 
            this.sodienthoai.DataPropertyName = "sodienthoai";
            this.sodienthoai.HeaderText = "Số Điện Thoại";
            this.sodienthoai.Name = "sodienthoai";
            // 
            // bophan
            // 
            this.bophan.DataPropertyName = "bophan";
            this.bophan.HeaderText = "Bộ Phận";
            this.bophan.Name = "bophan";
            // 
            // chucvu
            // 
            this.chucvu.DataPropertyName = "chucvu";
            this.chucvu.HeaderText = "Chức Vụ";
            this.chucvu.Name = "chucvu";
            // 
            // bangcap
            // 
            this.bangcap.DataPropertyName = "bangcap";
            this.bangcap.HeaderText = "Bằng Cấp";
            this.bangcap.Name = "bangcap";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // ThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 1008);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_suaNV);
            this.Controls.Add(this.btn_themNV);
            this.Controls.Add(this.dtg_ThongTinNhanVien);
            this.Controls.Add(this.txt_boPhan);
            this.Controls.Add(this.txt_dienThoai);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.txt_chucVu);
            this.Controls.Add(this.txt_bangCap);
            this.Controls.Add(this.txt_hoTen);
            this.Controls.Add(this.lb_boPhan);
            this.Controls.Add(this.lb_dienThoai);
            this.Controls.Add(this.lb_dicChi);
            this.Controls.Add(this.lb_chucVu);
            this.Controls.Add(this.lb_bangCap);
            this.Controls.Add(this.lb_NgaySinh);
            this.Controls.Add(this.lb_HoTen);
            this.Controls.Add(this.lb_ThongTinNhanVien);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ThongTinNhanVien";
            this.Text = "ThongTinNhanVien";
            this.Load += new System.EventHandler(this.ThongTinNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ThongTinNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ThongTinNhanVien;
        private System.Windows.Forms.Label lb_HoTen;
        private System.Windows.Forms.Label lb_NgaySinh;
        private System.Windows.Forms.Label lb_bangCap;
        private System.Windows.Forms.Label lb_chucVu;
        private System.Windows.Forms.Label lb_dicChi;
        private System.Windows.Forms.Label lb_dienThoai;
        private System.Windows.Forms.Label lb_boPhan;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.TextBox txt_bangCap;
        private System.Windows.Forms.TextBox txt_chucVu;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_dienThoai;
        private System.Windows.Forms.TextBox txt_boPhan;
        private System.Windows.Forms.DataGridView dtg_ThongTinNhanVien;
        private System.Windows.Forms.Button btn_themNV;
        private System.Windows.Forms.Button btn_suaNV;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendn;
        private System.Windows.Forms.DataGridViewLinkColumn xoanv;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn bophan;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn bangcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
    }
}
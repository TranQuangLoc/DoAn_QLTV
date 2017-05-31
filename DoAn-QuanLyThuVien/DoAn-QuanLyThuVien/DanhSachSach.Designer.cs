namespace DoAn_QuanLyThuVien
{
    partial class fr_DanhSachSach
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
            this.dtg_danhSachSach = new System.Windows.Forms.DataGridView();
            this.lb_danhSachSach = new System.Windows.Forms.Label();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namxuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaxuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giasach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoitiepnhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhSachSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_danhSachSach
            // 
            this.dtg_danhSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_danhSachSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tensach,
            this.theloai,
            this.tacgia,
            this.namxuatban,
            this.nhaxuatban,
            this.ngaynhap,
            this.giasach,
            this.nguoitiepnhan});
            this.dtg_danhSachSach.Location = new System.Drawing.Point(26, 151);
            this.dtg_danhSachSach.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtg_danhSachSach.Name = "dtg_danhSachSach";
            this.dtg_danhSachSach.RowTemplate.Height = 24;
            this.dtg_danhSachSach.Size = new System.Drawing.Size(1936, 837);
            this.dtg_danhSachSach.TabIndex = 0;
            // 
            // lb_danhSachSach
            // 
            this.lb_danhSachSach.AutoSize = true;
            this.lb_danhSachSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_danhSachSach.ForeColor = System.Drawing.Color.Blue;
            this.lb_danhSachSach.Location = new System.Drawing.Point(444, 17);
            this.lb_danhSachSach.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_danhSachSach.Name = "lb_danhSachSach";
            this.lb_danhSachSach.Size = new System.Drawing.Size(444, 63);
            this.lb_danhSachSach.TabIndex = 1;
            this.lb_danhSachSach.Text = "Danh Sách Sách";
            // 
            // tensach
            // 
            this.tensach.DataPropertyName = "tensach";
            this.tensach.HeaderText = "Tên Sách";
            this.tensach.Name = "tensach";
            // 
            // theloai
            // 
            this.theloai.DataPropertyName = "tentheloai";
            this.theloai.HeaderText = "Thể Loại";
            this.theloai.Name = "theloai";
            // 
            // tacgia
            // 
            this.tacgia.DataPropertyName = "tacgia";
            this.tacgia.HeaderText = "Tác Giả";
            this.tacgia.Name = "tacgia";
            // 
            // namxuatban
            // 
            this.namxuatban.DataPropertyName = "namxuatban";
            this.namxuatban.HeaderText = "Năm Xuất Bản";
            this.namxuatban.Name = "namxuatban";
            // 
            // nhaxuatban
            // 
            this.nhaxuatban.DataPropertyName = "nhaxuatban";
            this.nhaxuatban.HeaderText = "Nhà Xuất Bản";
            this.nhaxuatban.Name = "nhaxuatban";
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "Ngày Nhập";
            this.ngaynhap.Name = "ngaynhap";
            // 
            // giasach
            // 
            this.giasach.DataPropertyName = "giasach";
            this.giasach.HeaderText = "Trị Giá";
            this.giasach.Name = "giasach";
            // 
            // nguoitiepnhan
            // 
            this.nguoitiepnhan.DataPropertyName = "tennv";
            this.nguoitiepnhan.HeaderText = "Người Tiếp Nhận";
            this.nguoitiepnhan.Name = "nguoitiepnhan";
            // 
            // fr_DanhSachSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1977, 1011);
            this.Controls.Add(this.lb_danhSachSach);
            this.Controls.Add(this.dtg_danhSachSach);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "fr_DanhSachSach";
            this.Text = "Danh Sách Sách";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhSachSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_danhSachSach;
        private System.Windows.Forms.Label lb_danhSachSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn namxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giasach;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoitiepnhan;
    }
}
namespace DoAn_QuanLyThuVien
{
    partial class fr_ThongTinSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_tenSach = new System.Windows.Forms.Label();
            this.lb_theLoai = new System.Windows.Forms.Label();
            this.lb_tacGia = new System.Windows.Forms.Label();
            this.lb_namXuatBan = new System.Windows.Forms.Label();
            this.lb_ngayNhap = new System.Windows.Forms.Label();
            this.lb_triGia = new System.Windows.Forms.Label();
            this.lb_nguoiTiepNhan = new System.Windows.Forms.Label();
            this.txt_tenSach = new System.Windows.Forms.TextBox();
            this.txt_tacGia = new System.Windows.Forms.TextBox();
            this.txt_nguoiTiepNhan = new System.Windows.Forms.TextBox();
            this.txt_namXuatBan = new System.Windows.Forms.TextBox();
            this.txt_triGia = new System.Windows.Forms.TextBox();
            this.dtg_thongTinSach = new System.Windows.Forms.DataGridView();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentheloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namxuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaxuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giasach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txtngaynhap = new System.Windows.Forms.TextBox();
            this.cbbtheloai = new System.Windows.Forms.ComboBox();
            this.lbltotalpage = new System.Windows.Forms.Label();
            this.cbbcurrentpage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongTinSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(616, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Sách";
            // 
            // lb_tenSach
            // 
            this.lb_tenSach.AutoSize = true;
            this.lb_tenSach.Location = new System.Drawing.Point(72, 157);
            this.lb_tenSach.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_tenSach.Name = "lb_tenSach";
            this.lb_tenSach.Size = new System.Drawing.Size(136, 32);
            this.lb_tenSach.TabIndex = 1;
            this.lb_tenSach.Text = "Tên Sách";
            // 
            // lb_theLoai
            // 
            this.lb_theLoai.AutoSize = true;
            this.lb_theLoai.Location = new System.Drawing.Point(848, 157);
            this.lb_theLoai.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_theLoai.Name = "lb_theLoai";
            this.lb_theLoai.Size = new System.Drawing.Size(126, 32);
            this.lb_theLoai.TabIndex = 2;
            this.lb_theLoai.Text = "Thể Loại";
            // 
            // lb_tacGia
            // 
            this.lb_tacGia.AutoSize = true;
            this.lb_tacGia.Location = new System.Drawing.Point(72, 246);
            this.lb_tacGia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_tacGia.Name = "lb_tacGia";
            this.lb_tacGia.Size = new System.Drawing.Size(114, 32);
            this.lb_tacGia.TabIndex = 3;
            this.lb_tacGia.Text = "Tác Giả";
            // 
            // lb_namXuatBan
            // 
            this.lb_namXuatBan.AutoSize = true;
            this.lb_namXuatBan.Location = new System.Drawing.Point(848, 246);
            this.lb_namXuatBan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_namXuatBan.Name = "lb_namXuatBan";
            this.lb_namXuatBan.Size = new System.Drawing.Size(198, 32);
            this.lb_namXuatBan.TabIndex = 4;
            this.lb_namXuatBan.Text = "Năm Xuất Bản";
            // 
            // lb_ngayNhap
            // 
            this.lb_ngayNhap.AutoSize = true;
            this.lb_ngayNhap.Location = new System.Drawing.Point(72, 345);
            this.lb_ngayNhap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_ngayNhap.Name = "lb_ngayNhap";
            this.lb_ngayNhap.Size = new System.Drawing.Size(156, 32);
            this.lb_ngayNhap.TabIndex = 5;
            this.lb_ngayNhap.Text = "Ngày Nhập";
            // 
            // lb_triGia
            // 
            this.lb_triGia.AutoSize = true;
            this.lb_triGia.Location = new System.Drawing.Point(848, 345);
            this.lb_triGia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_triGia.Name = "lb_triGia";
            this.lb_triGia.Size = new System.Drawing.Size(100, 32);
            this.lb_triGia.TabIndex = 6;
            this.lb_triGia.Text = "Trị Giá";
            // 
            // lb_nguoiTiepNhan
            // 
            this.lb_nguoiTiepNhan.AutoSize = true;
            this.lb_nguoiTiepNhan.Location = new System.Drawing.Point(72, 436);
            this.lb_nguoiTiepNhan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_nguoiTiepNhan.Name = "lb_nguoiTiepNhan";
            this.lb_nguoiTiepNhan.Size = new System.Drawing.Size(228, 32);
            this.lb_nguoiTiepNhan.TabIndex = 7;
            this.lb_nguoiTiepNhan.Text = "Người Tiếp Nhận";
            // 
            // txt_tenSach
            // 
            this.txt_tenSach.Location = new System.Drawing.Point(356, 147);
            this.txt_tenSach.Margin = new System.Windows.Forms.Padding(6);
            this.txt_tenSach.Name = "txt_tenSach";
            this.txt_tenSach.Size = new System.Drawing.Size(404, 38);
            this.txt_tenSach.TabIndex = 8;
            // 
            // txt_tacGia
            // 
            this.txt_tacGia.Location = new System.Drawing.Point(356, 236);
            this.txt_tacGia.Margin = new System.Windows.Forms.Padding(6);
            this.txt_tacGia.Name = "txt_tacGia";
            this.txt_tacGia.Size = new System.Drawing.Size(404, 38);
            this.txt_tacGia.TabIndex = 9;
            // 
            // txt_nguoiTiepNhan
            // 
            this.txt_nguoiTiepNhan.Location = new System.Drawing.Point(356, 426);
            this.txt_nguoiTiepNhan.Margin = new System.Windows.Forms.Padding(6);
            this.txt_nguoiTiepNhan.Name = "txt_nguoiTiepNhan";
            this.txt_nguoiTiepNhan.Size = new System.Drawing.Size(404, 38);
            this.txt_nguoiTiepNhan.TabIndex = 11;
            // 
            // txt_namXuatBan
            // 
            this.txt_namXuatBan.Location = new System.Drawing.Point(1086, 246);
            this.txt_namXuatBan.Margin = new System.Windows.Forms.Padding(6);
            this.txt_namXuatBan.Name = "txt_namXuatBan";
            this.txt_namXuatBan.Size = new System.Drawing.Size(434, 38);
            this.txt_namXuatBan.TabIndex = 13;
            // 
            // txt_triGia
            // 
            this.txt_triGia.Location = new System.Drawing.Point(1086, 345);
            this.txt_triGia.Margin = new System.Windows.Forms.Padding(6);
            this.txt_triGia.Name = "txt_triGia";
            this.txt_triGia.Size = new System.Drawing.Size(434, 38);
            this.txt_triGia.TabIndex = 14;
            // 
            // dtg_thongTinSach
            // 
            this.dtg_thongTinSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_thongTinSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tensach,
            this.tentheloai,
            this.tacgia,
            this.namxuatban,
            this.nhaxuatban,
            this.ngaynhap,
            this.giasach,
            this.tennv,
            this.xoa});
            this.dtg_thongTinSach.Location = new System.Drawing.Point(26, 535);
            this.dtg_thongTinSach.Margin = new System.Windows.Forms.Padding(6);
            this.dtg_thongTinSach.Name = "dtg_thongTinSach";
            this.dtg_thongTinSach.RowTemplate.Height = 24;
            this.dtg_thongTinSach.Size = new System.Drawing.Size(1588, 353);
            this.dtg_thongTinSach.TabIndex = 16;
            // 
            // tensach
            // 
            this.tensach.DataPropertyName = "tensach";
            this.tensach.HeaderText = "Tên Sách";
            this.tensach.Name = "tensach";
            // 
            // tentheloai
            // 
            this.tentheloai.DataPropertyName = "tentheloai";
            this.tentheloai.HeaderText = "Thể Loại";
            this.tentheloai.Name = "tentheloai";
            // 
            // tacgia
            // 
            this.tacgia.DataPropertyName = "tentacgia";
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
            this.giasach.HeaderText = "Giá Sách";
            this.giasach.Name = "giasach";
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Người Tiếp Nhận";
            this.tennv.Name = "tennv";
            // 
            // xoa
            // 
            this.xoa.DataPropertyName = "xoa";
            this.xoa.HeaderText = "Xóa";
            this.xoa.Name = "xoa";
            this.xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xoa.Text = "Xóa Sách";
            this.xoa.UseColumnTextForLinkValue = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(85, 959);
            this.btn_them.Margin = new System.Windows.Forms.Padding(6);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(150, 58);
            this.btn_them.TabIndex = 17;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(719, 959);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(6);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(150, 56);
            this.btn_sua.TabIndex = 18;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(1363, 957);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(6);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(150, 58);
            this.btn_xoa.TabIndex = 19;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // txtngaynhap
            // 
            this.txtngaynhap.Location = new System.Drawing.Point(356, 338);
            this.txtngaynhap.Name = "txtngaynhap";
            this.txtngaynhap.Size = new System.Drawing.Size(404, 38);
            this.txtngaynhap.TabIndex = 20;
            // 
            // cbbtheloai
            // 
            this.cbbtheloai.FormattingEnabled = true;
            this.cbbtheloai.Items.AddRange(new object[] {
            "Giáo Khoa",
            "Tham Khảo",
            "Truyện Tranh"});
            this.cbbtheloai.Location = new System.Drawing.Point(1086, 134);
            this.cbbtheloai.Name = "cbbtheloai";
            this.cbbtheloai.Size = new System.Drawing.Size(434, 39);
            this.cbbtheloai.TabIndex = 21;
            // 
            // lbltotalpage
            // 
            this.lbltotalpage.AutoSize = true;
            this.lbltotalpage.Location = new System.Drawing.Point(848, 462);
            this.lbltotalpage.Name = "lbltotalpage";
            this.lbltotalpage.Size = new System.Drawing.Size(93, 32);
            this.lbltotalpage.TabIndex = 22;
            this.lbltotalpage.Text = "label2";
            // 
            // cbbcurrentpage
            // 
            this.cbbcurrentpage.FormattingEnabled = true;
            this.cbbcurrentpage.Location = new System.Drawing.Point(1086, 455);
            this.cbbcurrentpage.Name = "cbbcurrentpage";
            this.cbbcurrentpage.Size = new System.Drawing.Size(228, 39);
            this.cbbcurrentpage.TabIndex = 23;
            this.cbbcurrentpage.SelectedIndexChanged += new System.EventHandler(this.cbbcurrentpage_SelectedIndexChanged);
            // 
            // fr_ThongTinSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 1054);
            this.Controls.Add(this.cbbcurrentpage);
            this.Controls.Add(this.lbltotalpage);
            this.Controls.Add(this.cbbtheloai);
            this.Controls.Add(this.txtngaynhap);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtg_thongTinSach);
            this.Controls.Add(this.txt_triGia);
            this.Controls.Add(this.txt_namXuatBan);
            this.Controls.Add(this.txt_nguoiTiepNhan);
            this.Controls.Add(this.txt_tacGia);
            this.Controls.Add(this.txt_tenSach);
            this.Controls.Add(this.lb_nguoiTiepNhan);
            this.Controls.Add(this.lb_triGia);
            this.Controls.Add(this.lb_ngayNhap);
            this.Controls.Add(this.lb_namXuatBan);
            this.Controls.Add(this.lb_tacGia);
            this.Controls.Add(this.lb_theLoai);
            this.Controls.Add(this.lb_tenSach);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "fr_ThongTinSach";
            this.Text = "Thông Tin Sách";
            this.Load += new System.EventHandler(this.fr_ThongTinSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongTinSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_tenSach;
        private System.Windows.Forms.Label lb_theLoai;
        private System.Windows.Forms.Label lb_tacGia;
        private System.Windows.Forms.Label lb_namXuatBan;
        private System.Windows.Forms.Label lb_ngayNhap;
        private System.Windows.Forms.Label lb_triGia;
        private System.Windows.Forms.Label lb_nguoiTiepNhan;
        private System.Windows.Forms.TextBox txt_tenSach;
        private System.Windows.Forms.TextBox txt_tacGia;
        private System.Windows.Forms.TextBox txt_nguoiTiepNhan;
        private System.Windows.Forms.TextBox txt_namXuatBan;
        private System.Windows.Forms.TextBox txt_triGia;
        private System.Windows.Forms.DataGridView dtg_thongTinSach;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TextBox txtngaynhap;
        private System.Windows.Forms.ComboBox cbbtheloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentheloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn namxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giasach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewLinkColumn xoa;
        private System.Windows.Forms.Label lbltotalpage;
        private System.Windows.Forms.ComboBox cbbcurrentpage;
    }
}
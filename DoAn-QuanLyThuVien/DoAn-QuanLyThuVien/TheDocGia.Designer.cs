namespace DoAn_QuanLyThuVien
{
    partial class fr_TheDocGia
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
            this.lb_theDocGia = new System.Windows.Forms.Label();
            this.lb_hoTen = new System.Windows.Forms.Label();
            this.lb_diaChi = new System.Windows.Forms.Label();
            this.lb_loaiDocGia = new System.Windows.Forms.Label();
            this.lb_ngaySinh = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_ngayLapThe = new System.Windows.Forms.Label();
            this.lb_nguoiLap = new System.Windows.Forms.Label();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_nguoiLap = new System.Windows.Forms.TextBox();
            this.dtg_theDocGia = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.dtngaylap = new System.Windows.Forms.DateTimePicker();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylapthe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbbloaidocgia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_theDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_theDocGia
            // 
            this.lb_theDocGia.AutoSize = true;
            this.lb_theDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_theDocGia.ForeColor = System.Drawing.Color.Blue;
            this.lb_theDocGia.Location = new System.Drawing.Point(564, 17);
            this.lb_theDocGia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_theDocGia.Name = "lb_theDocGia";
            this.lb_theDocGia.Size = new System.Drawing.Size(339, 63);
            this.lb_theDocGia.TabIndex = 0;
            this.lb_theDocGia.Text = "Thẻ Độc Giả";
            // 
            // lb_hoTen
            // 
            this.lb_hoTen.AutoSize = true;
            this.lb_hoTen.Location = new System.Drawing.Point(42, 141);
            this.lb_hoTen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_hoTen.Name = "lb_hoTen";
            this.lb_hoTen.Size = new System.Drawing.Size(135, 32);
            this.lb_hoTen.TabIndex = 1;
            this.lb_hoTen.Text = "Họ và tên";
            // 
            // lb_diaChi
            // 
            this.lb_diaChi.AutoSize = true;
            this.lb_diaChi.Location = new System.Drawing.Point(42, 232);
            this.lb_diaChi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_diaChi.Name = "lb_diaChi";
            this.lb_diaChi.Size = new System.Drawing.Size(102, 32);
            this.lb_diaChi.TabIndex = 2;
            this.lb_diaChi.Text = "Địa chỉ";
            // 
            // lb_loaiDocGia
            // 
            this.lb_loaiDocGia.AutoSize = true;
            this.lb_loaiDocGia.Location = new System.Drawing.Point(754, 141);
            this.lb_loaiDocGia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_loaiDocGia.Name = "lb_loaiDocGia";
            this.lb_loaiDocGia.Size = new System.Drawing.Size(179, 32);
            this.lb_loaiDocGia.TabIndex = 3;
            this.lb_loaiDocGia.Text = "Loại Độc Giả";
            // 
            // lb_ngaySinh
            // 
            this.lb_ngaySinh.AutoSize = true;
            this.lb_ngaySinh.Location = new System.Drawing.Point(754, 232);
            this.lb_ngaySinh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_ngaySinh.Name = "lb_ngaySinh";
            this.lb_ngaySinh.Size = new System.Drawing.Size(146, 32);
            this.lb_ngaySinh.TabIndex = 4;
            this.lb_ngaySinh.Text = "Ngày Sinh";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(42, 318);
            this.lb_email.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(87, 32);
            this.lb_email.TabIndex = 5;
            this.lb_email.Text = "Email";
            // 
            // lb_ngayLapThe
            // 
            this.lb_ngayLapThe.AutoSize = true;
            this.lb_ngayLapThe.Location = new System.Drawing.Point(754, 344);
            this.lb_ngayLapThe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_ngayLapThe.Name = "lb_ngayLapThe";
            this.lb_ngayLapThe.Size = new System.Drawing.Size(192, 32);
            this.lb_ngayLapThe.TabIndex = 6;
            this.lb_ngayLapThe.Text = "Ngày Lập Thẻ";
            // 
            // lb_nguoiLap
            // 
            this.lb_nguoiLap.AutoSize = true;
            this.lb_nguoiLap.Location = new System.Drawing.Point(42, 413);
            this.lb_nguoiLap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_nguoiLap.Name = "lb_nguoiLap";
            this.lb_nguoiLap.Size = new System.Drawing.Size(145, 32);
            this.lb_nguoiLap.TabIndex = 7;
            this.lb_nguoiLap.Text = "Người Lập";
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Location = new System.Drawing.Point(242, 132);
            this.txt_hoTen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(410, 38);
            this.txt_hoTen.TabIndex = 8;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(242, 223);
            this.txt_diaChi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(410, 38);
            this.txt_diaChi.TabIndex = 9;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(242, 308);
            this.txt_email.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(410, 38);
            this.txt_email.TabIndex = 10;
            // 
            // txt_nguoiLap
            // 
            this.txt_nguoiLap.Enabled = false;
            this.txt_nguoiLap.Location = new System.Drawing.Point(242, 407);
            this.txt_nguoiLap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_nguoiLap.Name = "txt_nguoiLap";
            this.txt_nguoiLap.Size = new System.Drawing.Size(410, 38);
            this.txt_nguoiLap.TabIndex = 11;
            // 
            // dtg_theDocGia
            // 
            this.dtg_theDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_theDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hoten,
            this.tenloai,
            this.ngaysinh,
            this.diachi,
            this.email,
            this.ngaylapthe,
            this.tennv,
            this.xoa});
            this.dtg_theDocGia.Location = new System.Drawing.Point(24, 515);
            this.dtg_theDocGia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtg_theDocGia.Name = "dtg_theDocGia";
            this.dtg_theDocGia.RowTemplate.Height = 24;
            this.dtg_theDocGia.Size = new System.Drawing.Size(1436, 291);
            this.dtg_theDocGia.TabIndex = 17;
            this.dtg_theDocGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_theDocGia_CellContentClick);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(410, 887);
            this.btn_them.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(150, 64);
            this.btn_them.TabIndex = 18;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(783, 887);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(150, 64);
            this.btn_sua.TabIndex = 19;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // dtngaylap
            // 
            this.dtngaylap.Location = new System.Drawing.Point(988, 344);
            this.dtngaylap.Name = "dtngaylap";
            this.dtngaylap.Size = new System.Drawing.Size(422, 38);
            this.dtngaylap.TabIndex = 22;
            this.dtngaylap.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ Tên";
            this.hoten.Name = "hoten";
            // 
            // tenloai
            // 
            this.tenloai.DataPropertyName = "tenloai";
            this.tenloai.HeaderText = "Loại Độc Giả";
            this.tenloai.Name = "tenloai";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // ngaylapthe
            // 
            this.ngaylapthe.DataPropertyName = "ngaylapthe";
            this.ngaylapthe.HeaderText = "Ngày Lập Thẻ";
            this.ngaylapthe.Name = "ngaylapthe";
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Người Lập";
            this.tennv.Name = "tennv";
            // 
            // xoa
            // 
            this.xoa.HeaderText = "Xóa Độc Giả";
            this.xoa.Name = "xoa";
            this.xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xoa.Text = "Xóa Độc Giả";
            this.xoa.UseColumnTextForLinkValue = true;
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.Location = new System.Drawing.Point(988, 241);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Size = new System.Drawing.Size(422, 38);
            this.dtngaysinh.TabIndex = 23;
            // 
            // cbbloaidocgia
            // 
            this.cbbloaidocgia.FormattingEnabled = true;
            this.cbbloaidocgia.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbloaidocgia.Location = new System.Drawing.Point(988, 131);
            this.cbbloaidocgia.Name = "cbbloaidocgia";
            this.cbbloaidocgia.Size = new System.Drawing.Size(422, 39);
            this.cbbloaidocgia.TabIndex = 25;
            // 
            // fr_TheDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 996);
            this.Controls.Add(this.cbbloaidocgia);
            this.Controls.Add(this.dtngaysinh);
            this.Controls.Add(this.dtngaylap);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dtg_theDocGia);
            this.Controls.Add(this.txt_nguoiLap);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_diaChi);
            this.Controls.Add(this.txt_hoTen);
            this.Controls.Add(this.lb_nguoiLap);
            this.Controls.Add(this.lb_ngayLapThe);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_ngaySinh);
            this.Controls.Add(this.lb_loaiDocGia);
            this.Controls.Add(this.lb_diaChi);
            this.Controls.Add(this.lb_hoTen);
            this.Controls.Add(this.lb_theDocGia);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "fr_TheDocGia";
            this.Text = "Thẻ Độc Giả";
            this.Load += new System.EventHandler(this.fr_TheDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_theDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_theDocGia;
        private System.Windows.Forms.Label lb_hoTen;
        private System.Windows.Forms.Label lb_diaChi;
        private System.Windows.Forms.Label lb_loaiDocGia;
        private System.Windows.Forms.Label lb_ngaySinh;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_ngayLapThe;
        private System.Windows.Forms.Label lb_nguoiLap;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_nguoiLap;
        private System.Windows.Forms.DataGridView dtg_theDocGia;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.DateTimePicker dtngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylapthe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewLinkColumn xoa;
        private System.Windows.Forms.DateTimePicker dtngaysinh;
        private System.Windows.Forms.ComboBox cbbloaidocgia;
    }
}
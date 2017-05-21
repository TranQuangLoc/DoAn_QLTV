namespace DoAn_QuanLyThuVien
{
    partial class fr_PhieuMuonSach
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
            this.tt_phieuMuonSach = new System.Windows.Forms.Label();
            this.lb_ngayMuon = new System.Windows.Forms.Label();
            this.lb_hoTenDocGia = new System.Windows.Forms.Label();
            this.txt_hoTenDocGia = new System.Windows.Forms.TextBox();
            this.dtp_ngayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtg_phieuMuonSach = new System.Windows.Forms.DataGridView();
            this.btn_chonSach = new System.Windows.Forms.Button();
            this.btn_hoanTat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_phieuMuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // tt_phieuMuonSach
            // 
            this.tt_phieuMuonSach.AutoSize = true;
            this.tt_phieuMuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_phieuMuonSach.ForeColor = System.Drawing.Color.Blue;
            this.tt_phieuMuonSach.Location = new System.Drawing.Point(231, 9);
            this.tt_phieuMuonSach.Name = "tt_phieuMuonSach";
            this.tt_phieuMuonSach.Size = new System.Drawing.Size(239, 32);
            this.tt_phieuMuonSach.TabIndex = 0;
            this.tt_phieuMuonSach.Text = "Phiếu Mượn Sách";
            // 
            // lb_ngayMuon
            // 
            this.lb_ngayMuon.AutoSize = true;
            this.lb_ngayMuon.Location = new System.Drawing.Point(356, 86);
            this.lb_ngayMuon.Name = "lb_ngayMuon";
            this.lb_ngayMuon.Size = new System.Drawing.Size(80, 17);
            this.lb_ngayMuon.TabIndex = 1;
            this.lb_ngayMuon.Text = "Ngày Mượn";
            // 
            // lb_hoTenDocGia
            // 
            this.lb_hoTenDocGia.AutoSize = true;
            this.lb_hoTenDocGia.Location = new System.Drawing.Point(30, 86);
            this.lb_hoTenDocGia.Name = "lb_hoTenDocGia";
            this.lb_hoTenDocGia.Size = new System.Drawing.Size(110, 17);
            this.lb_hoTenDocGia.TabIndex = 2;
            this.lb_hoTenDocGia.Text = "Họ Tên Độc Giả";
            // 
            // txt_hoTenDocGia
            // 
            this.txt_hoTenDocGia.Location = new System.Drawing.Point(155, 83);
            this.txt_hoTenDocGia.Name = "txt_hoTenDocGia";
            this.txt_hoTenDocGia.Size = new System.Drawing.Size(171, 22);
            this.txt_hoTenDocGia.TabIndex = 3;
            // 
            // dtp_ngayMuon
            // 
            this.dtp_ngayMuon.Location = new System.Drawing.Point(461, 81);
            this.dtp_ngayMuon.Name = "dtp_ngayMuon";
            this.dtp_ngayMuon.Size = new System.Drawing.Size(200, 22);
            this.dtp_ngayMuon.TabIndex = 4;
            // 
            // dtg_phieuMuonSach
            // 
            this.dtg_phieuMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_phieuMuonSach.Location = new System.Drawing.Point(13, 148);
            this.dtg_phieuMuonSach.Name = "dtg_phieuMuonSach";
            this.dtg_phieuMuonSach.RowTemplate.Height = 24;
            this.dtg_phieuMuonSach.Size = new System.Drawing.Size(666, 234);
            this.dtg_phieuMuonSach.TabIndex = 5;
            // 
            // btn_chonSach
            // 
            this.btn_chonSach.Location = new System.Drawing.Point(98, 429);
            this.btn_chonSach.Name = "btn_chonSach";
            this.btn_chonSach.Size = new System.Drawing.Size(89, 38);
            this.btn_chonSach.TabIndex = 6;
            this.btn_chonSach.Text = "Chọn Sách";
            this.btn_chonSach.UseVisualStyleBackColor = true;
            // 
            // btn_hoanTat
            // 
            this.btn_hoanTat.Location = new System.Drawing.Point(477, 429);
            this.btn_hoanTat.Name = "btn_hoanTat";
            this.btn_hoanTat.Size = new System.Drawing.Size(81, 38);
            this.btn_hoanTat.TabIndex = 7;
            this.btn_hoanTat.Text = "Hoàn Tất";
            this.btn_hoanTat.UseVisualStyleBackColor = true;
            // 
            // fr_PhieuMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 494);
            this.Controls.Add(this.btn_hoanTat);
            this.Controls.Add(this.btn_chonSach);
            this.Controls.Add(this.dtg_phieuMuonSach);
            this.Controls.Add(this.dtp_ngayMuon);
            this.Controls.Add(this.txt_hoTenDocGia);
            this.Controls.Add(this.lb_hoTenDocGia);
            this.Controls.Add(this.lb_ngayMuon);
            this.Controls.Add(this.tt_phieuMuonSach);
            this.Name = "fr_PhieuMuonSach";
            this.Text = "Phiếu Mượn Sách";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_phieuMuonSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tt_phieuMuonSach;
        private System.Windows.Forms.Label lb_ngayMuon;
        private System.Windows.Forms.Label lb_hoTenDocGia;
        private System.Windows.Forms.TextBox txt_hoTenDocGia;
        private System.Windows.Forms.DateTimePicker dtp_ngayMuon;
        private System.Windows.Forms.DataGridView dtg_phieuMuonSach;
        private System.Windows.Forms.Button btn_chonSach;
        private System.Windows.Forms.Button btn_hoanTat;
    }
}
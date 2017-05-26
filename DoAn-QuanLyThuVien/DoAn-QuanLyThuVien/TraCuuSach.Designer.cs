namespace DoAn_QuanLyThuVien
{
    partial class fr_TraCuuSach
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
            this.tt_traCuuSach = new System.Windows.Forms.Label();
            this.lb_sachCanTraCuu = new System.Windows.Forms.Label();
            this.txt_sachCanTraCuu = new System.Windows.Forms.TextBox();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.dtg_sachCanTraCuu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sachCanTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // tt_traCuuSach
            // 
            this.tt_traCuuSach.AutoSize = true;
            this.tt_traCuuSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt_traCuuSach.ForeColor = System.Drawing.Color.Blue;
            this.tt_traCuuSach.Location = new System.Drawing.Point(222, 9);
            this.tt_traCuuSach.Name = "tt_traCuuSach";
            this.tt_traCuuSach.Size = new System.Drawing.Size(188, 32);
            this.tt_traCuuSach.TabIndex = 0;
            this.tt_traCuuSach.Text = "Tra Cứu Sách";
            // 
            // lb_sachCanTraCuu
            // 
            this.lb_sachCanTraCuu.AutoSize = true;
            this.lb_sachCanTraCuu.Location = new System.Drawing.Point(13, 65);
            this.lb_sachCanTraCuu.Name = "lb_sachCanTraCuu";
            this.lb_sachCanTraCuu.Size = new System.Drawing.Size(124, 17);
            this.lb_sachCanTraCuu.TabIndex = 1;
            this.lb_sachCanTraCuu.Text = "Sách Cần Tra Cứu";
            // 
            // txt_sachCanTraCuu
            // 
            this.txt_sachCanTraCuu.Location = new System.Drawing.Point(185, 65);
            this.txt_sachCanTraCuu.Name = "txt_sachCanTraCuu";
            this.txt_sachCanTraCuu.Size = new System.Drawing.Size(231, 22);
            this.txt_sachCanTraCuu.TabIndex = 2;
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.Location = new System.Drawing.Point(486, 52);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(102, 34);
            this.btn_timKiem.TabIndex = 3;
            this.btn_timKiem.Text = "Tìm Kiếm";
            this.btn_timKiem.UseVisualStyleBackColor = true;
            // 
            // dtg_sachCanTraCuu
            // 
            this.dtg_sachCanTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_sachCanTraCuu.Location = new System.Drawing.Point(13, 114);
            this.dtg_sachCanTraCuu.Name = "dtg_sachCanTraCuu";
            this.dtg_sachCanTraCuu.RowTemplate.Height = 24;
            this.dtg_sachCanTraCuu.Size = new System.Drawing.Size(622, 382);
            this.dtg_sachCanTraCuu.TabIndex = 4;
            // 
            // fr_TraCuuSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 508);
            this.Controls.Add(this.dtg_sachCanTraCuu);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.txt_sachCanTraCuu);
            this.Controls.Add(this.lb_sachCanTraCuu);
            this.Controls.Add(this.tt_traCuuSach);
            this.Name = "fr_TraCuuSach";
            this.Text = "Tra Cứu Sách";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sachCanTraCuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tt_traCuuSach;
        private System.Windows.Forms.Label lb_sachCanTraCuu;
        private System.Windows.Forms.TextBox txt_sachCanTraCuu;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.DataGridView dtg_sachCanTraCuu;
    }
}
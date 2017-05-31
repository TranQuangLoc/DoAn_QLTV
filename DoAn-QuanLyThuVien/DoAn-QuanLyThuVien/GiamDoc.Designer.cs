namespace DoAn_QuanLyThuVien
{
    partial class GiamDoc
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnthongtinnv = new System.Windows.Forms.Button();
            this.btnquanlysach = new System.Windows.Forms.Button();
            this.btndoanhthu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2199, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnthongtinnv
            // 
            this.btnthongtinnv.Location = new System.Drawing.Point(38, 28);
            this.btnthongtinnv.Name = "btnthongtinnv";
            this.btnthongtinnv.Size = new System.Drawing.Size(335, 59);
            this.btnthongtinnv.TabIndex = 1;
            this.btnthongtinnv.Text = "Thông Tin Nhân Viên";
            this.btnthongtinnv.UseVisualStyleBackColor = true;
            this.btnthongtinnv.Click += new System.EventHandler(this.btnthongtinnv_Click);
            // 
            // btnquanlysach
            // 
            this.btnquanlysach.Location = new System.Drawing.Point(481, 28);
            this.btnquanlysach.Name = "btnquanlysach";
            this.btnquanlysach.Size = new System.Drawing.Size(373, 59);
            this.btnquanlysach.TabIndex = 2;
            this.btnquanlysach.Text = "Quản Lý Sách";
            this.btnquanlysach.UseVisualStyleBackColor = true;
            this.btnquanlysach.Click += new System.EventHandler(this.btnquanlysach_Click);
            // 
            // btndoanhthu
            // 
            this.btndoanhthu.Location = new System.Drawing.Point(935, 28);
            this.btndoanhthu.Name = "btndoanhthu";
            this.btndoanhthu.Size = new System.Drawing.Size(482, 58);
            this.btndoanhthu.TabIndex = 3;
            this.btndoanhthu.Text = "Doanh Thu";
            this.btndoanhthu.UseVisualStyleBackColor = true;
            // 
            // GiamDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2199, 810);
            this.Controls.Add(this.btndoanhthu);
            this.Controls.Add(this.btnquanlysach);
            this.Controls.Add(this.btnthongtinnv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GiamDoc";
            this.Text = "GianDoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnthongtinnv;
        private System.Windows.Forms.Button btnquanlysach;
        private System.Windows.Forms.Button btndoanhthu;
    }
}
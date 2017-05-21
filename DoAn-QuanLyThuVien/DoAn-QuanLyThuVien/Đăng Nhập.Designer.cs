namespace DoAn_QuanLyThuVien
{
    partial class fr_dangnhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(410, 159);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(480, 38);
            this.txtuser.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(410, 244);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(480, 38);
            this.txtpass.TabIndex = 4;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Location = new System.Drawing.Point(700, 423);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(189, 66);
            this.btn_dangnhap.TabIndex = 5;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            // 
            // fr_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 792);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fr_dangnhap";
            this.Text = "Đăng_Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btn_dangnhap;
    }
}
﻿namespace DoAn_QuanLyThuVien
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
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhSachSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_danhSachSach
            // 
            this.dtg_danhSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_danhSachSach.Location = new System.Drawing.Point(13, 13);
            this.dtg_danhSachSach.Name = "dtg_danhSachSach";
            this.dtg_danhSachSach.RowTemplate.Height = 24;
            this.dtg_danhSachSach.Size = new System.Drawing.Size(632, 497);
            this.dtg_danhSachSach.TabIndex = 0;
            // 
            // fr_DanhSachSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 522);
            this.Controls.Add(this.dtg_danhSachSach);
            this.Name = "fr_DanhSachSach";
            this.Text = "Danh Sách Sách";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhSachSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_danhSachSach;
    }
}
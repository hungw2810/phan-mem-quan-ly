﻿
namespace Quanly.Danh_mục
{
    partial class Thuemay
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
            this.btnThue = new System.Windows.Forms.Button();
            this.btnTinhtien = new System.Windows.Forms.Button();
            this.dtgv1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtMamay = new System.Windows.Forms.TextBox();
            this.txtTenkhach = new System.Windows.Forms.TextBox();
            this.cboNhanvien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThue
            // 
            this.btnThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThue.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThue.ImageKey = "(none)";
            this.btnThue.Location = new System.Drawing.Point(588, 48);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(87, 28);
            this.btnThue.TabIndex = 0;
            this.btnThue.Text = "Thuê";
            this.btnThue.UseVisualStyleBackColor = true;
            this.btnThue.Click += new System.EventHandler(this.btnThue_Click);
            // 
            // btnTinhtien
            // 
            this.btnTinhtien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTinhtien.Location = new System.Drawing.Point(698, 49);
            this.btnTinhtien.Name = "btnTinhtien";
            this.btnTinhtien.Size = new System.Drawing.Size(87, 27);
            this.btnTinhtien.TabIndex = 1;
            this.btnTinhtien.Text = "Tính tiền";
            this.btnTinhtien.UseVisualStyleBackColor = true;
            this.btnTinhtien.Click += new System.EventHandler(this.btnTinhtien_Click);
            // 
            // dtgv1
            // 
            this.dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv1.Location = new System.Drawing.Point(14, 88);
            this.dtgv1.Name = "dtgv1";
            this.dtgv1.Size = new System.Drawing.Size(905, 417);
            this.dtgv1.TabIndex = 2;
            this.dtgv1.Click += new System.EventHandler(this.dtgv1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRefresh.Location = new System.Drawing.Point(815, 49);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 27);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cboPhong
            // 
            this.cboPhong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(119, 12);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(178, 25);
            this.cboPhong.TabIndex = 4;
            this.cboPhong.Text = "--Phòng ";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.White;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(315, 10);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(74, 27);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtMamay
            // 
            this.txtMamay.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMamay.Location = new System.Drawing.Point(36, 49);
            this.txtMamay.Name = "txtMamay";
            this.txtMamay.Size = new System.Drawing.Size(156, 25);
            this.txtMamay.TabIndex = 6;
            // 
            // txtTenkhach
            // 
            this.txtTenkhach.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenkhach.Location = new System.Drawing.Point(218, 49);
            this.txtTenkhach.Name = "txtTenkhach";
            this.txtTenkhach.Size = new System.Drawing.Size(156, 25);
            this.txtTenkhach.TabIndex = 7;
            this.txtTenkhach.Text = "--Tên khách";
            this.txtTenkhach.Click += new System.EventHandler(this.txtTenkhach_Click);
            // 
            // cboNhanvien
            // 
            this.cboNhanvien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhanvien.FormattingEnabled = true;
            this.cboNhanvien.Location = new System.Drawing.Point(399, 49);
            this.cboNhanvien.Name = "cboNhanvien";
            this.cboNhanvien.Size = new System.Drawing.Size(153, 25);
            this.cboNhanvien.TabIndex = 8;
            this.cboNhanvien.Text = "--Nhân viên";
            // 
            // Thuemay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.cboNhanvien);
            this.Controls.Add(this.txtTenkhach);
            this.Controls.Add(this.txtMamay);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cboPhong);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dtgv1);
            this.Controls.Add(this.btnTinhtien);
            this.Controls.Add(this.btnThue);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Thuemay";
            this.Text = "Thuê máy";
            this.Load += new System.EventHandler(this.Thuemay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThue;
        private System.Windows.Forms.Button btnTinhtien;
        private System.Windows.Forms.DataGridView dtgv1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtMamay;
        private System.Windows.Forms.TextBox txtTenkhach;
        private System.Windows.Forms.ComboBox cboNhanvien;
    }
}
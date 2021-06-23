
namespace Quanly.Dữ_liệu.Bảo_trì
{
    partial class Nguyennhan
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
            this.lblManguyennhan = new System.Windows.Forms.Label();
            this.lblTennguyennhan = new System.Windows.Forms.Label();
            this.lblNguyennhan = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.txtManguyennhan = new System.Windows.Forms.TextBox();
            this.txtTennguyennhan = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManguyennhan
            // 
            this.lblManguyennhan.AutoSize = true;
            this.lblManguyennhan.Location = new System.Drawing.Point(121, 116);
            this.lblManguyennhan.Name = "lblManguyennhan";
            this.lblManguyennhan.Size = new System.Drawing.Size(114, 17);
            this.lblManguyennhan.TabIndex = 0;
            this.lblManguyennhan.Text = "Mã nguyên nhân";
            // 
            // lblTennguyennhan
            // 
            this.lblTennguyennhan.AutoSize = true;
            this.lblTennguyennhan.Location = new System.Drawing.Point(121, 175);
            this.lblTennguyennhan.Name = "lblTennguyennhan";
            this.lblTennguyennhan.Size = new System.Drawing.Size(120, 17);
            this.lblTennguyennhan.TabIndex = 1;
            this.lblTennguyennhan.Text = "Tên nguyên nhân";
            // 
            // lblNguyennhan
            // 
            this.lblNguyennhan.AutoSize = true;
            this.lblNguyennhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguyennhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNguyennhan.Location = new System.Drawing.Point(280, 32);
            this.lblNguyennhan.Name = "lblNguyennhan";
            this.lblNguyennhan.Size = new System.Drawing.Size(230, 33);
            this.lblNguyennhan.TabIndex = 2;
            this.lblNguyennhan.Text = "NGUYÊN NHÂN";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(124, 233);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(601, 150);
            this.DataGridView.TabIndex = 4;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // txtManguyennhan
            // 
            this.txtManguyennhan.Location = new System.Drawing.Point(286, 110);
            this.txtManguyennhan.Name = "txtManguyennhan";
            this.txtManguyennhan.Size = new System.Drawing.Size(100, 22);
            this.txtManguyennhan.TabIndex = 5;
            // 
            // txtTennguyennhan
            // 
            this.txtTennguyennhan.Location = new System.Drawing.Point(286, 175);
            this.txtTennguyennhan.Name = "txtTennguyennhan";
            this.txtTennguyennhan.Size = new System.Drawing.Size(100, 22);
            this.txtTennguyennhan.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(141, 415);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 36);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(236, 415);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(77, 36);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(332, 415);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(74, 36);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(435, 415);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 36);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(629, 415);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(81, 36);
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(536, 415);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(78, 36);
            this.btnBoqua.TabIndex = 13;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // Nguyennhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTennguyennhan);
            this.Controls.Add(this.txtManguyennhan);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.lblNguyennhan);
            this.Controls.Add(this.lblTennguyennhan);
            this.Controls.Add(this.lblManguyennhan);
            this.Name = "Nguyennhan";
            this.Text = "Nguyennhan";
            this.Load += new System.EventHandler(this.Nguyennhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManguyennhan;
        private System.Windows.Forms.Label lblTennguyennhan;
        private System.Windows.Forms.Label lblNguyennhan;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox txtManguyennhan;
        private System.Windows.Forms.TextBox txtTennguyennhan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
    }
}

namespace Quanly.Báo_cáo
{
    partial class Tienthue
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
            this.btnTim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cbxThang = new System.Windows.Forms.ComboBox();
            this.cbxNam = new System.Windows.Forms.ComboBox();
            this.radZoneA = new System.Windows.Forms.RadioButton();
            this.radZoneB = new System.Windows.Forms.RadioButton();
            this.radZoneC = new System.Windows.Forms.RadioButton();
            this.cboQuy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(287, 106);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(82, 51);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Năm";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(24, -4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(344, 26);
            this.dataGridView2.TabIndex = 6;
            // 
            // cbxThang
            // 
            this.cbxThang.FormattingEnabled = true;
            this.cbxThang.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbxThang.Location = new System.Drawing.Point(76, 28);
            this.cbxThang.Name = "cbxThang";
            this.cbxThang.Size = new System.Drawing.Size(52, 24);
            this.cbxThang.TabIndex = 9;
            this.cbxThang.SelectedIndexChanged += new System.EventHandler(this.cbxThang_SelectedIndexChanged);
            // 
            // cbxNam
            // 
            this.cbxNam.FormattingEnabled = true;
            this.cbxNam.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022"});
            this.cbxNam.Location = new System.Drawing.Point(177, 28);
            this.cbxNam.Name = "cbxNam";
            this.cbxNam.Size = new System.Drawing.Size(76, 24);
            this.cbxNam.TabIndex = 9;
            // 
            // radZoneA
            // 
            this.radZoneA.AutoSize = true;
            this.radZoneA.Location = new System.Drawing.Point(24, 72);
            this.radZoneA.Name = "radZoneA";
            this.radZoneA.Size = new System.Drawing.Size(75, 21);
            this.radZoneA.TabIndex = 10;
            this.radZoneA.TabStop = true;
            this.radZoneA.Text = "Zone A";
            this.radZoneA.UseVisualStyleBackColor = true;
            // 
            // radZoneB
            // 
            this.radZoneB.AutoSize = true;
            this.radZoneB.Location = new System.Drawing.Point(104, 72);
            this.radZoneB.Name = "radZoneB";
            this.radZoneB.Size = new System.Drawing.Size(75, 21);
            this.radZoneB.TabIndex = 10;
            this.radZoneB.TabStop = true;
            this.radZoneB.Text = "Zone B";
            this.radZoneB.UseVisualStyleBackColor = true;
            // 
            // radZoneC
            // 
            this.radZoneC.AutoSize = true;
            this.radZoneC.Location = new System.Drawing.Point(181, 72);
            this.radZoneC.Name = "radZoneC";
            this.radZoneC.Size = new System.Drawing.Size(75, 21);
            this.radZoneC.TabIndex = 10;
            this.radZoneC.TabStop = true;
            this.radZoneC.Text = "Zone C";
            this.radZoneC.UseVisualStyleBackColor = true;
            // 
            // cboQuy
            // 
            this.cboQuy.FormattingEnabled = true;
            this.cboQuy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboQuy.Location = new System.Drawing.Point(311, 28);
            this.cboQuy.Name = "cboQuy";
            this.cboQuy.Size = new System.Drawing.Size(58, 24);
            this.cboQuy.TabIndex = 11;
            this.cboQuy.SelectedIndexChanged += new System.EventHandler(this.cboQuy_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quy";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(25, 106);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(74, 51);
            this.btnrefresh.TabIndex = 13;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tổng Doanh Thu :";
            // 
            // Tienthue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 221);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboQuy);
            this.Controls.Add(this.radZoneC);
            this.Controls.Add(this.radZoneB);
            this.Controls.Add(this.radZoneA);
            this.Controls.Add(this.cbxNam);
            this.Controls.Add(this.cbxThang);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTim);
            this.Name = "Tienthue";
            this.Text = "Tienthue";
            this.Load += new System.EventHandler(this.Tienthue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cbxThang;
        private System.Windows.Forms.ComboBox cbxNam;
        private System.Windows.Forms.RadioButton radZoneA;
        private System.Windows.Forms.RadioButton radZoneB;
        private System.Windows.Forms.RadioButton radZoneC;
        private System.Windows.Forms.ComboBox cboQuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Label label3;
    }
}
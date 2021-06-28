
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
            this.components = new System.ComponentModel.Container();
            this.btnTim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.radZoneA = new System.Windows.Forms.RadioButton();
            this.radZoneB = new System.Windows.Forms.RadioButton();
            this.radZoneC = new System.Windows.Forms.RadioButton();
            this.cboQuy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnRP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(29, 261);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(91, 37);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Find";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(35, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Năm";
            // 
            // cboThang
            // 
            this.cboThang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
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
            this.cboThang.Location = new System.Drawing.Point(101, 28);
            this.cboThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(125, 27);
            this.cboThang.TabIndex = 9;
            this.cboThang.SelectedIndexChanged += new System.EventHandler(this.cbxThang_SelectedIndexChanged);
            // 
            // cboNam
            // 
            this.cboNam.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022"});
            this.cboNam.Location = new System.Drawing.Point(101, 127);
            this.cboNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(125, 27);
            this.cboNam.TabIndex = 9;
            // 
            // radZoneA
            // 
            this.radZoneA.AutoSize = true;
            this.radZoneA.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radZoneA.ForeColor = System.Drawing.Color.SlateGray;
            this.radZoneA.Location = new System.Drawing.Point(293, 31);
            this.radZoneA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radZoneA.Name = "radZoneA";
            this.radZoneA.Size = new System.Drawing.Size(86, 25);
            this.radZoneA.TabIndex = 10;
            this.radZoneA.TabStop = true;
            this.radZoneA.Text = "Zone A";
            this.radZoneA.UseVisualStyleBackColor = true;
            // 
            // radZoneB
            // 
            this.radZoneB.AutoSize = true;
            this.radZoneB.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radZoneB.ForeColor = System.Drawing.Color.SlateGray;
            this.radZoneB.Location = new System.Drawing.Point(293, 79);
            this.radZoneB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radZoneB.Name = "radZoneB";
            this.radZoneB.Size = new System.Drawing.Size(86, 25);
            this.radZoneB.TabIndex = 10;
            this.radZoneB.TabStop = true;
            this.radZoneB.Text = "Zone B";
            this.radZoneB.UseVisualStyleBackColor = true;
            // 
            // radZoneC
            // 
            this.radZoneC.AutoSize = true;
            this.radZoneC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radZoneC.ForeColor = System.Drawing.Color.SlateGray;
            this.radZoneC.Location = new System.Drawing.Point(292, 129);
            this.radZoneC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radZoneC.Name = "radZoneC";
            this.radZoneC.Size = new System.Drawing.Size(87, 25);
            this.radZoneC.TabIndex = 10;
            this.radZoneC.TabStop = true;
            this.radZoneC.Text = "Zone C";
            this.radZoneC.UseVisualStyleBackColor = true;
            // 
            // cboQuy
            // 
            this.cboQuy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuy.FormattingEnabled = true;
            this.cboQuy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboQuy.Location = new System.Drawing.Point(101, 76);
            this.cboQuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboQuy.Name = "cboQuy";
            this.cboQuy.Size = new System.Drawing.Size(125, 27);
            this.cboQuy.TabIndex = 11;
            this.cboQuy.SelectedIndexChanged += new System.EventHandler(this.cboQuy_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SlateGray;
            this.label4.Location = new System.Drawing.Point(40, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quý";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Location = new System.Drawing.Point(126, 261);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(99, 37);
            this.btnrefresh.TabIndex = 13;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(64, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tổng tiền ";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(232, 261);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 37);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboThang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboNam);
            this.groupBox1.Controls.Add(this.cboQuy);
            this.groupBox1.Controls.Add(this.radZoneA);
            this.groupBox1.Controls.Add(this.radZoneC);
            this.groupBox1.Controls.Add(this.radZoneB);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(29, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(411, 185);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN";
            // 
            // timer1
            // 
           
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 17;
            // 
            // btnRP
            // 
            this.btnRP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRP.Location = new System.Drawing.Point(340, 261);
            this.btnRP.Margin = new System.Windows.Forms.Padding(4);
            this.btnRP.Name = "btnRP";
            this.btnRP.Size = new System.Drawing.Size(100, 37);
            this.btnRP.TabIndex = 15;
            this.btnRP.Text = "Export";
            this.btnRP.UseVisualStyleBackColor = true;
            this.btnRP.Click += new System.EventHandler(this.btn_RP_Click);
            // 
            // Tienthue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 314);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRP);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tienthue";
            this.Text = "Báo cáo tiền thuê";
            this.Load += new System.EventHandler(this.Tienthue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.RadioButton radZoneA;
        private System.Windows.Forms.RadioButton radZoneB;
        private System.Windows.Forms.RadioButton radZoneC;
        private System.Windows.Forms.ComboBox cboQuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRP;
    }
}
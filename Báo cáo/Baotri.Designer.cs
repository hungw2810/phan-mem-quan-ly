
namespace Quanly.Báo_cáo
{
    partial class Baotri
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
            this.btnBaocao = new System.Windows.Forms.Button();
            this.btnTimlai = new System.Windows.Forms.Button();
            this.btnInbaocao = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMaphong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongCP = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtQuy = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(301, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI PHÍ BẢO TRÌ";
            // 
            // btnBaocao
            // 
            this.btnBaocao.Location = new System.Drawing.Point(56, 520);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(160, 42);
            this.btnBaocao.TabIndex = 2;
            this.btnBaocao.Text = "Báo Cáo";
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btnTimlai
            // 
            this.btnTimlai.Location = new System.Drawing.Point(293, 520);
            this.btnTimlai.Name = "btnTimlai";
            this.btnTimlai.Size = new System.Drawing.Size(160, 42);
            this.btnTimlai.TabIndex = 3;
            this.btnTimlai.Text = "Tìm Lại";
            this.btnTimlai.UseVisualStyleBackColor = true;
            this.btnTimlai.Click += new System.EventHandler(this.btnTimlai_Click);
            // 
            // btnInbaocao
            // 
            this.btnInbaocao.Location = new System.Drawing.Point(552, 520);
            this.btnInbaocao.Name = "btnInbaocao";
            this.btnInbaocao.Size = new System.Drawing.Size(160, 42);
            this.btnInbaocao.TabIndex = 4;
            this.btnInbaocao.Text = "In Báo Cáo";
            this.btnInbaocao.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(801, 520);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(160, 42);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tháng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quý:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(654, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Năm:";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 249);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(980, 209);
            this.DataGridView.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã phòng:";
            // 
            // cboMaphong
            // 
            this.cboMaphong.FormattingEnabled = true;
            this.cboMaphong.Location = new System.Drawing.Point(147, 182);
            this.cboMaphong.Name = "cboMaphong";
            this.cboMaphong.Size = new System.Drawing.Size(215, 24);
            this.cboMaphong.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(592, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tổng chi phí:";
            // 
            // txtTongCP
            // 
            this.txtTongCP.Location = new System.Drawing.Point(723, 180);
            this.txtTongCP.Name = "txtTongCP";
            this.txtTongCP.Size = new System.Drawing.Size(238, 22);
            this.txtTongCP.TabIndex = 18;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(114, 108);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(209, 22);
            this.txtThang.TabIndex = 19;
            // 
            // txtQuy
            // 
            this.txtQuy.Location = new System.Drawing.Point(402, 108);
            this.txtQuy.Name = "txtQuy";
            this.txtQuy.Size = new System.Drawing.Size(238, 22);
            this.txtQuy.TabIndex = 20;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(723, 108);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(238, 22);
            this.txtNam.TabIndex = 21;
            // 
            // Baotri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 598);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtQuy);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtTongCP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboMaphong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnInbaocao);
            this.Controls.Add(this.btnTimlai);
            this.Controls.Add(this.btnBaocao);
            this.Controls.Add(this.label1);
            this.Name = "Baotri";
            this.Text = "Baotri";
            this.Load += new System.EventHandler(this.Baotri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnTimlai;
        private System.Windows.Forms.Button btnInbaocao;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMaphong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongCP;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtQuy;
        private System.Windows.Forms.TextBox txtNam;
    }
}
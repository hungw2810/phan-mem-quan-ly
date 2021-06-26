
namespace Quanly.Danh_mục
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
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDay_start = new System.Windows.Forms.TextBox();
            this.cboGiaiphap = new System.Windows.Forms.ComboBox();
            this.cboNguyennhan = new System.Windows.Forms.ComboBox();
            this.cboNBT = new System.Windows.Forms.ComboBox();
            this.cboMay = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChiphi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDay_end = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(21, 24);
            this.dtgv.Name = "dtgv";
            this.dtgv.Size = new System.Drawing.Size(431, 324);
            this.dtgv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 366);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MÁY ĐANG BẢO TRÌ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDay_start);
            this.groupBox2.Controls.Add(this.cboGiaiphap);
            this.groupBox2.Controls.Add(this.cboNguyennhan);
            this.groupBox2.Controls.Add(this.cboNBT);
            this.groupBox2.Controls.Add(this.cboMay);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(534, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 215);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(62, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // txtDay_start
            // 
            this.txtDay_start.Location = new System.Drawing.Point(200, 162);
            this.txtDay_start.Name = "txtDay_start";
            this.txtDay_start.Size = new System.Drawing.Size(121, 25);
            this.txtDay_start.TabIndex = 5;
            // 
            // cboGiaiphap
            // 
            this.cboGiaiphap.FormattingEnabled = true;
            this.cboGiaiphap.Location = new System.Drawing.Point(200, 103);
            this.cboGiaiphap.Name = "cboGiaiphap";
            this.cboGiaiphap.Size = new System.Drawing.Size(121, 25);
            this.cboGiaiphap.TabIndex = 3;
            this.cboGiaiphap.Text = "--Giải pháp";
            // 
            // cboNguyennhan
            // 
            this.cboNguyennhan.FormattingEnabled = true;
            this.cboNguyennhan.Location = new System.Drawing.Point(40, 103);
            this.cboNguyennhan.Name = "cboNguyennhan";
            this.cboNguyennhan.Size = new System.Drawing.Size(121, 25);
            this.cboNguyennhan.TabIndex = 2;
            this.cboNguyennhan.Text = "--Nguyên nhân";
            // 
            // cboNBT
            // 
            this.cboNBT.FormattingEnabled = true;
            this.cboNBT.Location = new System.Drawing.Point(200, 38);
            this.cboNBT.Name = "cboNBT";
            this.cboNBT.Size = new System.Drawing.Size(121, 25);
            this.cboNBT.TabIndex = 1;
            this.cboNBT.Text = "--Nhà bảo trì";
            // 
            // cboMay
            // 
            this.cboMay.FormattingEnabled = true;
            this.cboMay.Location = new System.Drawing.Point(40, 38);
            this.cboMay.Name = "cboMay";
            this.cboMay.Size = new System.Drawing.Size(121, 25);
            this.cboMay.TabIndex = 0;
            this.cboMay.Text = "--Máy bảo trì";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(629, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(725, 366);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(819, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(626, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chi phí";
            // 
            // txtChiphi
            // 
            this.txtChiphi.Location = new System.Drawing.Point(707, 306);
            this.txtChiphi.Name = "txtChiphi";
            this.txtChiphi.Size = new System.Drawing.Size(164, 22);
            this.txtChiphi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(584, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày kết thúc";
            // 
            // txtDay_end
            // 
            this.txtDay_end.Location = new System.Drawing.Point(707, 266);
            this.txtDay_end.Name = "txtDay_end";
            this.txtDay_end.Size = new System.Drawing.Size(164, 22);
            this.txtDay_end.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(534, 366);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Baotri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 416);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDay_end);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChiphi);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Baotri";
            this.Text = "Bảo trì";
            this.Load += new System.EventHandler(this.Baotri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboGiaiphap;
        private System.Windows.Forms.ComboBox cboNguyennhan;
        private System.Windows.Forms.ComboBox cboNBT;
        private System.Windows.Forms.ComboBox cboMay;
        private System.Windows.Forms.TextBox txtDay_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChiphi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDay_end;
        private System.Windows.Forms.Button btnAdd;
    }
}
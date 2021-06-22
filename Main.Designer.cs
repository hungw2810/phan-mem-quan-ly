
namespace Quanly
{
    partial class Main
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
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.máyTínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảoTrìToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thuêToolStripMenuItem,
            this.máyTínhToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // thuêToolStripMenuItem
            // 
            this.thuêToolStripMenuItem.Name = "thuêToolStripMenuItem";
            this.thuêToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thuêToolStripMenuItem.Text = "Thuê";
            // 
            // máyTínhToolStripMenuItem
            // 
            this.máyTínhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phòngToolStripMenuItem,
            this.bảoTrìToolStripMenuItem});
            this.máyTínhToolStripMenuItem.Name = "máyTínhToolStripMenuItem";
            this.máyTínhToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.máyTínhToolStripMenuItem.Text = "Thông tin";
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phòngToolStripMenuItem.Text = "Phòng";
            // 
            // bảoTrìToolStripMenuItem
            // 
            this.bảoTrìToolStripMenuItem.Name = "bảoTrìToolStripMenuItem";
            this.bảoTrìToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bảoTrìToolStripMenuItem.Text = "Bảo trì";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Quản lý quán internet";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem máyTínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảoTrìToolStripMenuItem;
    }
}


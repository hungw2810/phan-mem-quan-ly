using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quanly
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            Main f = new Main();
            f.StartPosition = FormStartPosition.CenterScreen;
        }
        private void mnu_dm_thuemay_Click(object sender, EventArgs e)
        {
            Danh_mục.Thuemay f = new Danh_mục.Thuemay();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_dm_Baotri_Click(object sender, EventArgs e)
        {
            Danh_mục.Baotri f = new Danh_mục.Baotri();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_tk_May_Click(object sender, EventArgs e)
        {
            Tìm_kiếm.May f = new Tìm_kiếm.May();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_tk_Nhanvien_Click(object sender, EventArgs e)
        {
            Tìm_kiếm.Nhanvien f = new Tìm_kiếm.Nhanvien();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_bc_Baotri_Click(object sender, EventArgs e)
        {
            Báo_cáo.Baotri f = new Báo_cáo.Baotri();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_bc_Tienthuemay_Click(object sender, EventArgs e)
        {
            Báo_cáo.Tienthue f = new Báo_cáo.Tienthue();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_dl_Room_Click(object sender, EventArgs e)
        {
            Dữ_liệu.Room f = new Dữ_liệu.Room();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_dl_Nhanvien_Click(object sender, EventArgs e)
        {
            Dữ_liệu.Nhanvien f = new Dữ_liệu.Nhanvien();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_dl_Maytinh_Click(object sender, EventArgs e)
        {
            Dữ_liệu.Maytinh f = new Dữ_liệu.Maytinh();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_dl_pcOcung_Click(object sender, EventArgs e)
        {
            Dữ_liệu.Phần_cứng.Ocung f = new Dữ_liệu.Phần_cứng.Ocung();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_dl_pcChip_Click(object sender, EventArgs e)
        {
            Dữ_liệu.Phần_cứng.Chip f = new Dữ_liệu.Phần_cứng.Chip();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_dl_pcRam_Click(object sender, EventArgs e)
        {
            Dữ_liệu.Phần_cứng.Ram f = new Dữ_liệu.Phần_cứng.Ram();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_dl_pcManhinh_Click(object sender, EventArgs e)
        {
            Dữ_liệu.Phần_cứng.Manhinh f = new Dữ_liệu.Phần_cứng.Manhinh();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_dl_pcTainghe_Click(object sender, EventArgs e)
        {
            Dữ_liệu.Phần_cứng.Tainghe f = new Dữ_liệu.Phần_cứng.Tainghe();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_dl_pcBanphim_Click(object sender, EventArgs e)
        {
            Dữ_liệu.Phần_cứng.Banphim f = new Dữ_liệu.Phần_cứng.Banphim();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_dl_pcChuot_Click(object sender, EventArgs e)
        {
            Dữ_liệu.Phần_cứng.CHUỘT f = new Dữ_liệu.Phần_cứng.CHUỘT();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_dl_btNhabt_Click(object sender, EventArgs e)
        {
            Dữ_liệu.Bảo_trì.Nhabaotri f = new Dữ_liệu.Bảo_trì.Nhabaotri();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_dl_btGiaiphap_Click(object sender, EventArgs e)
        {
            Dữ_liệu.Bảo_trì.Giaiphap f = new Dữ_liệu.Bảo_trì.Giaiphap();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnu_dl_btNguyennhan_Click(object sender, EventArgs e)
        {
            Dữ_liệu.Bảo_trì.Nguyennhan f = new Dữ_liệu.Bảo_trì.Nguyennhan();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuTinhtien_Click(object sender, EventArgs e)
        {
            Danh_mục.Tinhtien f = new Danh_mục.Tinhtien();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}

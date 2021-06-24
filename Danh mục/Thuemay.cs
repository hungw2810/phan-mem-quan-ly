using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;


namespace Quanly.Danh_mục
{
    public partial class Thuemay : Form
    {
        DataTable tblMay;
        public Thuemay()
        {
            InitializeComponent();
        }

        private void Thuemay_Load(object sender, EventArgs e)
        {
            btnThue.Enabled = false;
            btnTinhtien.Enabled = false;
            Functions.FillCombo("SELECT id_phong FROM Phong ", cboPhong, "id_phong", "id_phong");
            cboPhong.SelectedIndex = -1;
            cboPhong.Text = "--Phòng";
        }
        private void Load_dtgv1()
        {
            dtgv1.DataSource = tblMay;
            dtgv1.Columns[0].HeaderText = "Mã máy";
            dtgv1.Columns[1].HeaderText = "Ổ cứng";
            dtgv1.Columns[2].HeaderText = "Chip";
            dtgv1.Columns[3].HeaderText = "Ram";
            dtgv1.Columns[4].HeaderText = "Màn hình";
            dtgv1.Columns[5].HeaderText = "Tai nghe";
            dtgv1.Columns[6].HeaderText = "Chuột";
            dtgv1.Columns[7].HeaderText = "Bàn phím";
            dtgv1.Columns[8].HeaderText = "Đơn giá";
            dtgv1.Columns[9].HeaderText = "Tình trạng";
            dtgv1.AllowUserToAddRows = false;
            dtgv1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void dtgv1_Click(object sender, EventArgs e)
        {
            if (dtgv1.Rows.Count == 0)
            {
                 MessageBox.Show("Hãy chọn phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 return;
            }
            txtMamay.Text = dtgv1.CurrentRow.Cells["id_may"].Value.ToString();
            btnThue.Enabled = true;
        }
        private void btnThue_Click(object sender, EventArgs e)
        {
            if (txtMamay.Text.Trim() == "")
            {
                MessageBox.Show("Chọn máy để thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Thongtinthue f = new Thongtinthue();
            f.Show();
        }

        private void btnTinhtien_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT a.id_may,a.id_ocung,a.id_chip,a.id_ram,a.id_man,a.id_tainghe,a.id_chuot,a.id_banphim,b.DonGia,a.GhiChu FROM MayTinh a JOIN Phong b ON a.id_phong=b.id_phong WHERE a.TinhTrang= '' AND a.id_phong='" + cboPhong.Text.Trim() + "'";
            tblMay = Functions.GetDataToTable(sql);
            Load_dtgv1();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboPhong.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "SELECT a.id_may,a.id_ocung,a.id_chip,a.id_ram,a.id_man,a.id_tainghe,a.id_chuot,a.id_banphim,b.DonGia,a.GhiChu FROM MayTinh a JOIN Phong b ON a.id_phong=b.id_phong WHERE a.TinhTrang= '' AND a.id_phong='"+cboPhong.Text.Trim()+"'";
            tblMay= Functions.GetDataToTable(sql);
            Load_dtgv1();
        }
    }
}

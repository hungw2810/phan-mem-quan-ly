using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanly.Tìm_kiếm
{
    public partial class Nhanvien : Form
    {
        DataTable tblTKNV;
        public Nhanvien()
        {
            InitializeComponent();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            DataGridView.DataSource = null;
            resetvalues();
            Functions.FillCombo("SELECT id_ca FROM CaLam", cboMaca, "id_ca", "id_ca");
            cboMaca.SelectedIndex = -1;
        }
        private void resetvalues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtTennhanvien.Focus();
            cboMaca.Text = "";
            txtGioitinh.Text = "";
            txtTennhanvien.Enabled = true;
            txtGioitinh.Enabled = true;
            cboMaca.Enabled = true;
            btnTimkiem.Enabled = true;


        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtTennhanvien.Text == "") && (txtGioitinh.Text == "") && (cboMaca.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM NhanVien WHERE 1=1";
            if (txtTennhanvien.Text != "")
                sql = sql + " AND TenNV Like N'%" + txtTennhanvien.Text + "%'";
            if (txtGioitinh.Text != "")
                sql = sql + " AND GioiTinh Like N'%" + txtGioitinh.Text + "%'";
            if (cboMaca.Text != "")
                sql = sql + " AND id_ca Like N'%" + cboMaca.SelectedValue + "%'";
            tblTKNV = Functions.GetDataToTable(sql);
            if (tblTKNV.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblTKNV.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            DataGridView.DataSource = tblTKNV;
            Load_DataGridView();
            btnTimkiem.Enabled = false;
            txtGioitinh.Enabled = false;
            txtTennhanvien.Enabled = false;
            cboMaca.Enabled = false;
        }
        private void Load_DataGridView()
        {
            DataGridView.Columns[0].HeaderText = "Mã nhân viên";
            DataGridView.Columns[1].HeaderText = "Tên nhân viên";
            DataGridView.Columns[2].HeaderText = "Mã ca";
            DataGridView.Columns[3].HeaderText = "Năm sinh";
            DataGridView.Columns[4].HeaderText = "Giới tính";
            DataGridView.Columns[5].HeaderText = "Địa chỉ";
            DataGridView.Columns[6].HeaderText = "Điện thoại";
            DataGridView.Columns[0].Width = 50;
            DataGridView.Columns[1].Width = 100;
            DataGridView.Columns[2].Width = 50;
            DataGridView.Columns[3].Width = 50;
            DataGridView.Columns[4].Width = 50;
            DataGridView.Columns[5].Width = 100;
            DataGridView.Columns[6].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            resetvalues();
            DataGridView.DataSource = null;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


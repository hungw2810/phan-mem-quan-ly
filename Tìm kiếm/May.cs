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
    public partial class May : Form
    {
        DataTable tblTKMT;
        public May()
        {
            InitializeComponent();
        }

        private void May_Load(object sender, EventArgs e)
        {
            DataGridView.DataSource = null;
            resetvalues();
            Functions.FillCombo("SELECT id_phong FROM Phong", cboPhong, "id_phong", "id_phong");
            cboPhong.SelectedIndex = -1;            
        }
        private void resetvalues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            cboPhong.Text = "";
            txtTinhtrang.Text = "";
            cboPhong.Enabled = true;
            txtTinhtrang.Enabled = true;
            btnTimkiem.Enabled = true;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cboPhong.Text == "") && (txtTinhtrang.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM MayTinh WHERE 1=1";
            if (cboPhong.Text != "")
                sql = sql + " AND id_phong Like N'%" + cboPhong.Text + "%'";
            if (txtTinhtrang.Text != "")
                sql = sql + " AND TinhTrang Like N'%" + txtTinhtrang.Text + "%'";
            tblTKMT = Functions.GetDataToTable(sql);
            if (tblTKMT.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblTKMT.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            DataGridView.DataSource = tblTKMT;
            Load_DataGridView();
            btnTimkiem.Enabled = false;
            cboPhong.Enabled = false;
            txtTinhtrang.Enabled = false;
        }
        private void Load_DataGridView()
        {

            DataGridView.Columns[0].HeaderText = "Mã máy";
            DataGridView.Columns[1].HeaderText = "Mã phòng";
            DataGridView.Columns[2].HeaderText = "Mã ổ cứng";
            DataGridView.Columns[3].HeaderText = "Mã chip";
            DataGridView.Columns[4].HeaderText = "Mã ram";
            DataGridView.Columns[5].HeaderText = "Mã màn";
            DataGridView.Columns[6].HeaderText = "Mã tai nghe";
            DataGridView.Columns[7].HeaderText = "Mã chuột";
            DataGridView.Columns[8].HeaderText = "Mã bàn phím";
            DataGridView.Columns[9].HeaderText = "Tình trạng";
            DataGridView.Columns[10].HeaderText = "Ghi chú";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 100;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[3].Width = 100;
            DataGridView.Columns[4].Width = 100;
            DataGridView.Columns[5].Width = 100;
            DataGridView.Columns[6].Width = 100;
            DataGridView.Columns[7].Width = 100;
            DataGridView.Columns[8].Width = 100;
            DataGridView.Columns[9].Width = 100;
            DataGridView.Columns[10].Width = 100;
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

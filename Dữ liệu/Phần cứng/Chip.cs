using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanly.Dữ_liệu.Phần_cứng
{
    public partial class Chip : Form
    {
        DataTable C;
        public Chip()
        {
            InitializeComponent();
        }

        private void Chip_Load(object sender, EventArgs e)
        {
            txtMachip.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT id_chip, TenChip , Tocdo FROM Chip";
            C = Functions.GetDataToTable(sql);
            DataGridView.DataSource = C;
            DataGridView.Columns[0].HeaderText = "Mã chip";
            DataGridView.Columns[1].HeaderText = "Tên chip";
            DataGridView.Columns[2].HeaderText = "Tốc độ chip";
            DataGridView.Columns[0].Width = 200;
            DataGridView.Columns[1].Width = 200;
            DataGridView.Columns[2].Width = 200;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            DataGridView.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMachip.Focus();
                return;
            }
            if (C.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMachip.Text = DataGridView.CurrentRow.Cells["id_chip"].Value.ToString();
            txtTenchip.Text = DataGridView.CurrentRow.Cells["TenChip"].Value.ToString();
            txtTocdo.Text = DataGridView.CurrentRow.Cells["TocDo"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
        private void ResetValues()
        {
            txtMachip.Text = "";
            txtTenchip.Text = "";
            txtTocdo.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMachip.Enabled = true;
            txtMachip.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMachip.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã chip ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMachip.Focus();
                return;
            }
            if (txtTenchip.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chip", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenchip.Focus();
                return;
            }
            if (txtTocdo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chip", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTocdo.Focus();
                return;
            }
            sql = "SELECT id_chip FROM Chip WHERE id_chip=N'" + txtMachip.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã chip này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMachip.Focus();
                txtMachip.Text = "";
                return;
            }
            sql = "INSERT INTO Chip(id_chip,TenChip,TocDo) VALUES(N'" + txtMachip.Text + "',N'" + txtTenchip.Text + "',N'" +txtTocdo.Text +"')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMachip.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (C.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMachip.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenchip.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chip", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenchip.Focus();
                return;
            }
            if (txtTocdo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tốc độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTocdo.Focus();
                return;
            }
            sql = "UPDATE Chip SET  TenChip=N'" + txtTenchip.Text.Trim().ToString()
                  + "',TocDo=N'" + txtTocdo.Text.Trim().ToString() + "' WHERE id_chip=N'" + txtMachip.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (C.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMachip.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE Chip WHERE id_chip=N'" + txtMachip.Text + "'";
                Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMachip.Enabled = false;
        }
    }
}

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
    public partial class Ram : Form
    {
        DataTable R;
        public Ram()
        {
            InitializeComponent();
        }

        private void Ram_Load(object sender, EventArgs e)
        {
            txtMaram.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT id_ram, TenRam FROM Ram";
            R = Functions.GetDataToTable(sql);
            DataGridView.DataSource = R;
            DataGridView.Columns[0].HeaderText = "Mã Ram";
            DataGridView.Columns[1].HeaderText = "Tên Ram";
            DataGridView.Columns[0].Width = 200;
            DataGridView.Columns[1].Width = 300;
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
                txtMaram.Focus();
                return;
            }
            if (R.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaram.Text = DataGridView.CurrentRow.Cells["id_ram"].Value.ToString();
            txtTenram.Text = DataGridView.CurrentRow.Cells["TenRam"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;

        }
        private void ResetValues()
        {
            txtMaram.Text = "";
            txtTenram.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaram.Enabled = true;
            txtMaram.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaram.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã ram ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaram.Focus();
                return;
            }
            if (txtTenram.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ram ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenram.Focus();
                return;
            }
            sql = "SELECT id_ram FROM Ram WHERE id_ram=N'" + txtMaram.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã ram này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaram.Focus();
                txtMaram.Text = "";
                return;
            }
            sql = "INSERT INTO Ram(id_ram,TenRam) VALUES(N'" + txtMaram.Text + "',N'" + txtTenram.Text + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaram.Enabled = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (R.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaram.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenram.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nguyên nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenram.Focus();
                return;
            }
            sql = "UPDATE Ram SET TenRam=N'" + txtTenram.Text.ToString() + "' WHERE id_ram=N'" + txtMaram.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (R.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaram.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE Ram WHERE id_ram=N'" + txtMaram.Text + "'";
                Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }

        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaram.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }  
}

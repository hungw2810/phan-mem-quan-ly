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
    public partial class CHUỘT : Form
    {
        DataTable CT;
        public CHUỘT()
        {
            InitializeComponent();
        }

        private void Chuot_Load(object sender, EventArgs e)
        {
            txtMachuot.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT id_chuot, TenChuat FROM Chuot";
             CT = Functions.GetDataToTable(sql);
            DataGridView.DataSource = CT;
            DataGridView.Columns[0].HeaderText = "Mã chuột";
            DataGridView.Columns[1].HeaderText = "Tên chuột";
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
                txtMachuot.Focus();
                return;
            }
            if (CT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMachuot.Text = DataGridView.CurrentRow.Cells["id_chuot"].Value.ToString();
            txtTenchuot.Text = DataGridView.CurrentRow.Cells["TenChuat"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
        private void ResetValues()
        {
            txtMachuot.Text = "";
            txtTenchuot.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMachuot.Enabled = true;
            txtMachuot.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMachuot.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã chuột ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMachuot.Focus();
                return;
            }
            if (txtTenchuot.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chuột", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenchuot.Focus();
                return;
            }
            sql = "SELECT id_chuot FROM Chuot WHERE id_chuot=N'" + txtMachuot.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã bàn phím này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMachuot.Focus();
                txtMachuot.Text = "";
                return;
            }
            sql = "INSERT INTO Chuot(id_chuot,TenChuat) VALUES(N'" + txtMachuot.Text + "',N'" + txtTenchuot.Text + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMachuot.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (CT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMachuot.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenchuot.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chuột", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenchuot.Focus();
                return;
            }
            sql = "UPDATE Chuot SET TenChuat=N'" + txtTenchuot.Text.ToString() + "' WHERE id_chuot=N'" + txtMachuot.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (CT.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMachuot.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE Chuot WHERE id_chuot=N'" + txtMachuot.Text + "'";
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
            txtMachuot.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

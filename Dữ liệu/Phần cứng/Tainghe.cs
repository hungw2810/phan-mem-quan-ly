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
    public partial class Tainghe : Form
    {
        DataTable TN;
        public Tainghe()
        {
            InitializeComponent();
        }

        private void Tainghe_Load(object sender, EventArgs e)
        {
            txtMatainghe.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT id_tainghe, TenTaiNghe FROM TaiNghe";
            TN = Functions.GetDataToTable(sql);
            DataGridView.DataSource = TN;
            DataGridView.Columns[0].HeaderText = "Mã tai nghe";
            DataGridView.Columns[1].HeaderText = "Tên tai nghe";
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
                txtMatainghe.Focus();
                return;
            }
            if (TN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMatainghe.Text = DataGridView.CurrentRow.Cells["id_tainghe"].Value.ToString();
            txtTentainghe.Text = DataGridView.CurrentRow.Cells["TenTaiNghe"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
        private void ResetValues()
        {
            txtMatainghe.Text = "";
            txtTentainghe.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMatainghe.Enabled = true;
            txtMatainghe.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMatainghe.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã tai nghe ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatainghe.Focus();
                return;
            }
            if (txtTentainghe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên tai nghe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTentainghe.Focus();
                return;
            }
            sql = "SELECT id_tainghe FROM TaiNghe WHERE id_tainghe=N'" + txtMatainghe.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã tai nghe này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatainghe.Focus();
                txtMatainghe.Text = "";
                return;
            }
            sql = "INSERT INTO TaiNghe(id_tainghe,TenTaiNghe) VALUES(N'" + txtMatainghe.Text + "',N'" + txtTentainghe.Text + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMatainghe.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (TN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMatainghe.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTentainghe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên tai nghe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTentainghe.Focus();
                return;
            }
            sql = "UPDATE TaiNghe SET TenTaiNghe=N'" + txtTentainghe.Text.ToString() + "' WHERE id_tainghe=N'" + txtMatainghe.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (TN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMatainghe.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE TaiNghe WHERE id_tainghe=N'" + txtMatainghe.Text + "'";
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
            txtMatainghe.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Manhinh : Form
    {
        DataTable MH;
        public Manhinh()
        {
            InitializeComponent();
        }

        private void Manhinh_Load(object sender, EventArgs e)
        {
            txtMamanhinh.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT id_man, TenMan, CoMan FROM ManHinh";
            MH = Functions.GetDataToTable(sql);
            DataGridView.DataSource = MH;
            DataGridView.Columns[0].HeaderText = "Mã màn hình ";
            DataGridView.Columns[1].HeaderText = "Tên màn hình";
            DataGridView.Columns[2].HeaderText = "Cỡ màn hình";
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
                txtMamanhinh.Focus();
                return;
            }
            if (MH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMamanhinh.Text = DataGridView.CurrentRow.Cells["id_man"].Value.ToString();
            txtTenmanhinh.Text = DataGridView.CurrentRow.Cells["TenMan"].Value.ToString();
            txtComan.Text = DataGridView.CurrentRow.Cells["CoMan"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
        private void ResetValues()
        {
            txtMamanhinh.Text = "";
            txtTenmanhinh.Text = "";
            txtComan.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMamanhinh.Enabled = true;
            txtMamanhinh.Focus();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMamanhinh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã màn hình ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMamanhinh.Focus();
                return;
            }
            if (txtTenmanhinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên màn hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenmanhinh.Focus();
                return;
            }
            if (txtComan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập cỡ màn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtComan.Focus();
                return;
            }
            sql = "SELECT id_man FROM ManHinh WHERE id_man=N'" + txtMamanhinh.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã màn hình này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMamanhinh.Focus();
                txtMamanhinh.Text = "";
                return;
            }
            sql = "INSERT INTO ManHinh(id_man,TenMan,CoMan) VALUES(N'" + txtMamanhinh.Text + "',N'" + txtTenmanhinh.Text + "',N'" + txtComan.Text + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMamanhinh.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (MH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMamanhinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenmanhinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên màn hình ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenmanhinh.Focus();
                return;
            }
            if (txtComan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập cỡ màn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtComan.Focus();
                return;
            }
            sql = "UPDATE ManHinh SET  TenMan=N'" + txtTenmanhinh.Text.Trim().ToString()
                  + "',CoMan=N'" + txtComan.Text.Trim().ToString() + "' WHERE id_man=N'" + txtMamanhinh.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (MH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMamanhinh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE ManHinh WHERE id_man=N'" + txtMamanhinh.Text + "'";
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
            txtMamanhinh.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Quanly.Dữ_liệu.Bảo_trì
{
    public partial class Nguyennhan : Form
    {
        DataTable NN;
        public Nguyennhan()
        {
            InitializeComponent();
        }

        private void Nguyennhan_Load(object sender, EventArgs e)
        {
            txtManguyennhan.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }

        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT id_nn, TenNN FROM NguyenNhan";
            NN = Functions.GetDataToTable(sql);
            DataGridView.DataSource = NN;
            DataGridView.Columns[0].HeaderText = "Mã nguyên nhân";
            DataGridView.Columns[1].HeaderText = "Tên nguyên nhân";
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManguyennhan.Focus();
                return;
            }
            if (NN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            txtManguyennhan.Text = DataGridView.CurrentRow.Cells["id_nn"].Value.ToString();
            txtTennguyennhan.Text = DataGridView.CurrentRow.Cells["TenNN"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
        private void ResetValues()
        {
            txtManguyennhan.Text = "";
            txtTennguyennhan.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtManguyennhan.Text =="")
            {
                MessageBox.Show("Bạn phải nhập mã nguyên nhân", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManguyennhan.Focus();
                return;
            }
            if (txtTennguyennhan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nguyên nhân", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennguyennhan.Focus();
                return;
            }
            sql = "SELECT id_nn FROM NguyenNhan WHERE id_nn=N'" + txtManguyennhan.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nguyên nhân này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManguyennhan.Focus();
                txtManguyennhan.Text = "";
                return;
            }
            sql = "INSERT INTO NguyenNhan(id_nn,TenNN) VALUES(N'" + txtManguyennhan.Text + "',N'" + txtTennguyennhan.Text + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManguyennhan.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (NN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtManguyennhan.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTennguyennhan.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nguyên nhân", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennguyennhan.Focus();
                return;
            }
            sql = "UPDATE NguyenNhan SET TenNN=N'" + txtTennguyennhan.Text.ToString() + "' WHERE id_nn=N'" + txtManguyennhan.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (NN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtManguyennhan.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NguyenNhan WHERE id_nn=N'" + txtManguyennhan.Text + "'";
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
            txtManguyennhan.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtManguyennhan.Enabled = true;
            txtManguyennhan.Focus();
        }
    }
}


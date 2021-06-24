using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanly.Dữ_liệu.Bảo_trì
{
    public partial class Giaiphap : Form
    {
        DataTable GP;
        public Giaiphap()
        {
            InitializeComponent();
        }

        private void Giaiphap_Load(object sender, EventArgs e)
        {
            txtMagiaiphap.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT id_giaiphap, TenGiaiPhap, ChiPhi, ThoiGian FROM GiaiPhap";
            GP = Functions.GetDataToTable(sql);
            DataGridView.DataSource = GP;
            DataGridView.Columns[0].HeaderText = "Mã giải pháp";
            DataGridView.Columns[1].HeaderText = "Tên Giải Pháp";
            DataGridView.Columns[2].HeaderText = "Chi Phí";
            DataGridView.Columns[3].HeaderText = "Thời Gian";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 150;
            DataGridView.Columns[2].Width = 150;
            DataGridView.Columns[3].Width = 150;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMagiaiphap.Enabled = true;
            txtMagiaiphap.Focus();

        }
        private void Reset()
        {
            txtMagiaiphap.Text = "";
            txtChiphi.Text = "";
            txtThoigian.Text = "";
            txtThoigian.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (GP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtMagiaiphap.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE GiaiPhap WHERE id_giaiphap=N'" + txtMagiaiphap.Text + "'";
                Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMagiaiphap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã giải pháp", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtMagiaiphap.Focus();
                return;
            }
            if (txtTengiaiphap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên giải pháp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMagiaiphap.Focus();
                return;
            }
            if (txtChiphi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Chi phí", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChiphi.Focus();
                return;
            }
            if (txtThoigian.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thời gian", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtThoigian.Focus();
                return;
            }
            
            sql = "SELECT id_giaiphap FROM GiaiPhap WHERE id_giaiphap=N'" + txtMagiaiphap.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách này đã có, bạn phải nhập mã khác", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMagiaiphap.Focus();
                txtMagiaiphap.Text = "";
                return;
            }
            sql = "INSERT INTO GiaiPhap(id_giaiphap,TenGiaiPhap,ChiPhi,ThoiGian) VALUES (N'" + txtMagiaiphap.Text.Trim() + "',N'" + txtTengiaiphap.Text.Trim() + "',N'" + txtChiphi.Text.Trim() + "',N'" + txtThoigian.Text.Trim() + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMagiaiphap.Enabled = false;
        }

        private void ResetValues()
        {
            txtMagiaiphap.Text = "";
            txtTengiaiphap.Text = "";
            txtChiphi.Text = "";
            txtThoigian.Text = "";
        }


        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMagiaiphap.Focus();
                return;
            }
            if (GP.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            txtMagiaiphap.Text = DataGridView.CurrentRow.Cells["id_giaiphap"].Value.ToString();
            txtTengiaiphap.Text = DataGridView.CurrentRow.Cells["Tengiaiphap"].Value.ToString();
            txtChiphi.Text = DataGridView.CurrentRow.Cells["ChiPhi"].Value.ToString();
            txtThoigian.Text = DataGridView.CurrentRow.Cells["ThoiGian"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (GP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtMagiaiphap.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTengiaiphap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ten giải pháp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTengiaiphap.Focus();
                return;
            }
            if (txtChiphi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Chi phí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChiphi.Focus();
                return;
            }
            if (txtThoigian.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThoigian.Focus();
                return;
            }
            sql = "UPDATE GiaiPhap SET TenGiaiPhap=N'" + txtTengiaiphap.Text.Trim() +"', ChiPhi='" +txtChiphi.Text + "',Thoigian=N'" + txtThoigian.Text.Trim() + "' WHERE id_giaiphap=N'" + txtMagiaiphap.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMagiaiphap.Enabled = false;
        }
    }
}

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
    public partial class Ocung : Form
    {
        DataTable OC;
        public Ocung()
        {
            InitializeComponent();
        }

        private void Ocung_Load(object sender, EventArgs e)
        {
            txtMaocung.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT id_oc, TenOC , DungLuong FROM OCung";
            OC = Functions.GetDataToTable(sql);
            DataGridView.DataSource = OC;
            DataGridView.Columns[0].HeaderText = "Mã Ổ Cứng";
            DataGridView.Columns[1].HeaderText = "Tên Ổ Cứng";
            DataGridView.Columns[2].HeaderText = "Dung lượng ";
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
                txtMaocung.Focus();
                return;
            }
            if (OC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaocung.Text = DataGridView.CurrentRow.Cells["id_oc"].Value.ToString();
            txtTenocung.Text = DataGridView.CurrentRow.Cells["TenOC"].Value.ToString();
            txtDungluong.Text = DataGridView.CurrentRow.Cells["DungLuong"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
        private void ResetValues()
        {
            txtMaocung.Text = "";
            txtTenocung.Text = "";
            txtDungluong.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaocung.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã ổ cứng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaocung.Focus();
                return;
            }
            if (txtTenocung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ổ cứng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenocung.Focus();
                return;
            }
            if (txtDungluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập dung lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDungluong.Focus();
                return;
            }
            sql = "SELECT id_oc FROM OCung WHERE id_oc=N'" + txtMaocung.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã ổ cứng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaocung.Focus();
                txtMaocung.Text = "";
                return;
            }
            sql = "INSERT INTO OCung(id_oc,TenOC,DungLuong) VALUES(N'" + txtMaocung.Text + "',N'" + txtTenocung.Text + "',N'" + txtDungluong.Text + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaocung.Enabled = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaocung.Enabled = true;
            txtMaocung.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (OC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaocung.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenocung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên ổ cứng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenocung.Focus();
                return;
            }
            if (txtDungluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập dung lượng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDungluong.Focus();
                return;
            }
            sql = "UPDATE OCung SET  TenOC=N'" + txtTenocung.Text.Trim().ToString()
                  + "',DungLuong=N'" + txtDungluong.Text.Trim().ToString() + "' WHERE id_oc=N'" + txtMaocung.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (OC.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaocung.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE OCung WHERE id_oc=N'" + txtMaocung.Text + "'";
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
            txtMaocung.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

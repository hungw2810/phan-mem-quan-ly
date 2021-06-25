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
    public partial class Banphim : Form
    {

        DataTable BP;
        public Banphim()
        {
            InitializeComponent();
        }

        private void Banphim_Load(object sender, EventArgs e)
        {
            txtMabanphim.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT id_banphim, TenBanPhim FROM BanPhim";
            BP = Functions.GetDataToTable(sql);
            DataGridView.DataSource = BP;
            DataGridView.Columns[0].HeaderText = "Mã bàn phím";
            DataGridView.Columns[1].HeaderText = "Tên bản phím";
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
                txtMabanphim.Focus();
                return;
            }
            if (BP.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMabanphim.Text = DataGridView.CurrentRow.Cells["id_banphim"].Value.ToString();
            txtTenbanphim.Text = DataGridView.CurrentRow.Cells["TenBanPhim"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
        private void ResetValues()
        {
            txtMabanphim.Text = "";
            txtTenbanphim.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMabanphim.Enabled = true;
            txtMabanphim.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMabanphim.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã bàn phím ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMabanphim.Focus();
                return;
            }
            if (txtTenbanphim.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên bàn phím", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenbanphim.Focus();
                return;
            }
            sql = "SELECT id_banphim FROM BanPhim WHERE id_banphim=N'" + txtMabanphim.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã bàn phím này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMabanphim.Focus();
                txtMabanphim.Text = "";
                return;
            }
            sql = "INSERT INTO BanPhim(id_banphim,TenBanPhim) VALUES(N'" + txtMabanphim.Text + "',N'" + txtTenbanphim.Text + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMabanphim.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (BP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMabanphim.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenbanphim.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên bàn phím ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenbanphim.Focus();
                return;
            }
            sql = "UPDATE BanPhim SET TenBanPhim=N'" + txtTenbanphim.Text.ToString() + "' WHERE id_banphim=N'" + txtMabanphim.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (BP.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMabanphim.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE BanPhim WHERE id_banphim=N'" + txtMabanphim.Text + "'";
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
            txtMabanphim.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

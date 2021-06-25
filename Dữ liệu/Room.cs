using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanly.Dữ_liệu
{
    public partial class Room : Form
    {
        DataTable P;
        public Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            txtMaphong.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();

        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT id_phong, SoMay , DonGia FROM Phong";
            P = Functions.GetDataToTable(sql);
            DataGridView.DataSource = P;
            DataGridView.Columns[0].HeaderText = "Mã phòng";
            DataGridView.Columns[1].HeaderText = "Số máy";
            DataGridView.Columns[2].HeaderText = "Đơn giá ";
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
                txtMaphong.Focus();
                return;
            }
            if (P.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaphong.Text = DataGridView.CurrentRow.Cells["id_phong"].Value.ToString();
            txtSomay.Text = DataGridView.CurrentRow.Cells["SoMay"].Value.ToString();
            txtDonGia.Text = DataGridView.CurrentRow.Cells["DonGia"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
        private void ResetValues()
        {
            txtMaphong.Text = "";
            txtSomay.Text = "";
            txtDonGia.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaphong.Enabled = true;
            txtMaphong.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaphong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã phòng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaphong.Focus();
                return;
            }
            if (txtSomay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSomay.Focus();
                return;
            }
            if (txtDonGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }
            sql = "SELECT id_phong FROM Phong WHERE id_phong=N'" + txtMaphong.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã phòng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaphong.Focus();
                txtMaphong.Text = "";
                return;
            }
            sql = "INSERT INTO Phong(id_phong,SoMay,DonGia) VALUES(N'" + txtMaphong.Text + "',N'" + txtSomay.Text + "',N'" + txtDonGia.Text + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaphong.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            string sql;
            if (P.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaphong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSomay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số máy ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSomay.Focus();
                return;
            }
            if (txtDonGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }
            sql = "UPDATE Phong SET  SoMay=N'" + txtSomay.Text.Trim().ToString()
                  + "',DonGia=N'" + txtDonGia.Text.Trim().ToString() + "' WHERE id_phong=N'" + txtMaphong.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string sql;
            if (P.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaphong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE Phong WHERE id_phong=N'" + txtMaphong.Text + "'";
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
            txtMaphong.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

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
    public partial class Nhanvien : Form
    {
        DataTable tblNV;
        public Nhanvien()
        {
            InitializeComponent();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            txtManhanvien.Enabled = false;
            Functions.FillCombo("SELECT id_ca FROM CaLam", cboMaca, "id_ca", "id_ca");
            cboMaca.SelectedIndex = -1;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT id_nv,TenNV,id_ca,NamSinh,GioiTinh,DiaChi,SDT FROM NhanVien";
            tblNV = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblNV;
            DataGridView.Columns[0].HeaderText = "Mã nhân viên";
            DataGridView.Columns[1].HeaderText = "Tên nhân viên";
            DataGridView.Columns[2].HeaderText = "Mã ca";
            DataGridView.Columns[3].HeaderText = "Năm sinh";
            DataGridView.Columns[4].HeaderText = "Giới tính";
            DataGridView.Columns[5].HeaderText = "Địa chỉ";
            DataGridView.Columns[6].HeaderText = "Điện thoại";
            DataGridView.Columns[0].Width = 50;
            DataGridView.Columns[1].Width = 100;
            DataGridView.Columns[2].Width = 50;
            DataGridView.Columns[3].Width = 50;
            DataGridView.Columns[4].Width = 50;
            DataGridView.Columns[5].Width = 100;
            DataGridView.Columns[6].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManhanvien.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DataGridView.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam")
                chkGioitinh.Checked = true;
            else
                chkGioitinh.Checked = false;

            txtManhanvien.Text = DataGridView.CurrentRow.Cells["id_nv"].Value.ToString();
            txtTennhanvien.Text = DataGridView.CurrentRow.Cells["TenNV"].Value.ToString();
            ma = DataGridView.CurrentRow.Cells["id_ca"].Value.ToString();
            cboMaca.Text = Functions.GetFieldValues("SELECT id_ca FROM CaLam WHERE id_ca =N'" + ma + "'");
            txtNamsinh.Text = DataGridView.CurrentRow.Cells["NamSinh"].Value.ToString();
            txtDiachi.Text = DataGridView.CurrentRow.Cells["DiaChi"].Value.ToString();
            mskDienthoai.Text = DataGridView.CurrentRow.Cells["SDT"].Value.ToString();
            btnBoqua.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        private void resetvalues()
        {
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            txtNamsinh.Text = "";
            txtDiachi.Text = "";
            cboMaca.Text = "";
            mskDienthoai.Text = "";
            chkGioitinh.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            txtManhanvien.Focus();
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            resetvalues();
            txtManhanvien.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "( )  ")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            if (txtNamsinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập năm sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamsinh.Focus();
                return;

            }
            if (cboMaca.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã ca", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaca.Focus();
                return;
            }
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT id_nv FROM NhanVien WHERE id_nv=N'" + txtManhanvien.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                txtManhanvien.Text = "";
                return;
            }
            sql = "INSERT INTO NhanVien(id_nv,TenNV,id_ca,NamSinh,GioiTinh,DiaChi,SDT) VALUES(N'" + txtManhanvien.Text.Trim() + "',N'" + txtTennhanvien.Text.Trim() + "',N'" + cboMaca.SelectedValue.ToString() + "','" + txtNamsinh.Text.Trim() + "',N'" + gt + "',N'" + txtDiachi.Text.Trim() + "','" + mskDienthoai.Text + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            resetvalues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            txtManhanvien.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE NhanVien WHERE id_nv=N'" + txtManhanvien.Text + "'";
                Functions.RunSqlDel(sql);
                Load_DataGridView();
                resetvalues();
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTennhanvien.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTennhanvien.Focus();
                return;
            }
            if (cboMaca.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã ca", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaca.Focus();
                return;
            }
            if (txtDiachi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(  )     ")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskDienthoai.Focus();
                return;
            }
            if (txtNamsinh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập năm sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNamsinh.Focus();
                return;
            }
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "UPDATE NhanVien SET TenNV =N'" + txtTennhanvien.Text.Trim().ToString() + "',DiaChi=N'" + txtDiachi.Text.Trim().ToString() + "',SDT='" + mskDienthoai.Text.ToString() + "',id_ca=N'" + cboMaca.SelectedValue.ToString() + "',GioiTinh=N'" + gt + "',NamSinh='" + txtNamsinh.Text.ToString() + "'Where id_nv=N'" + txtManhanvien.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            resetvalues();
            btnBoqua.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            resetvalues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtManhanvien.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;


namespace Quanly.Danh_mục
{
    public partial class Thuemay : Form
    {
        DataTable tblMay;
        public Thuemay()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Thuemay_Load(object sender, EventArgs e)
        {
            txtMamay.Enabled = false;
            btnThue.Enabled = false;
            Functions.FillCombo("SELECT id_phong FROM Phong ", cboPhong, "id_phong", "id_phong");
            Functions.FillCombo("SELECT id_NV,TenNV FROM NhanVien a INNER JOIN CaLam b on a.id_ca=b.id_ca WHERE (SELECT CONVERT(char(7),CURRENT_TIMESTAMP,108)) BETWEEN time_start AND time_end", cboNhanvien, "id_NV", "TenNV");
            ResetValues();
        }
        private void Load_dtgv1()
        {
            dtgv1.DataSource = tblMay;
            dtgv1.Columns[0].HeaderText = "Mã máy";
            dtgv1.Columns[1].HeaderText = "Ổ cứng";
            dtgv1.Columns[2].HeaderText = "Chip";
            dtgv1.Columns[3].HeaderText = "Ram";
            dtgv1.Columns[4].HeaderText = "Màn hình";
            dtgv1.Columns[5].HeaderText = "Tai nghe";
            dtgv1.Columns[6].HeaderText = "Chuột";
            dtgv1.Columns[7].HeaderText = "Bàn phím";
            dtgv1.Columns[8].HeaderText = "Đơn giá";
            dtgv1.Columns[9].HeaderText = "Tình trạng";
            dtgv1.AllowUserToAddRows = false;
            dtgv1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void dtgv1_Click(object sender, EventArgs e)
        {
            if (dtgv1.Rows.Count == 0)
            {
                 MessageBox.Show("Hãy chọn phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 return;
            }
            txtMamay.Text = dtgv1.CurrentRow.Cells["id_may"].Value.ToString();
            btnThue.Enabled = true;
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            if (txtMamay.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chọn máy để thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenkhach.Focus();
                return;
            }
            if (cboNhanvien.SelectedIndex == -1)
            {
                MessageBox.Show("Nhân viên trực ca", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string tennv = cboNhanvien.Text.ToString();           
            string sql = "INSERT INTO ThueMay(id_may,id_phong,TenKhach,NgayThue,GioVao,id_nv) VALUES ('" + txtMamay.Text.ToString() + "','" + cboPhong.Text.ToString() + "',N'" + txtTenkhach.Text.ToString() + "',CAST(GETDATE() AS DATE)," + "CONVERT(CHAR(7),CURRENT_TIMESTAMP,108),'" + Functions.GetFieldValues("SELECT id_NV FROM NhanVien WHERE TenNV=N'" + tennv + "'") + "')";
            Functions.RunSql(sql);
            sql = "UPDATE MayTinh SET TinhTrang= N'Đang Thuê' WHERE id_may='" + txtMamay.Text + "'";
            Functions.RunSql(sql);
            ResetValues();
            btnThue.Enabled = false;
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboPhong.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "SELECT a.id_may,a.id_ocung,a.id_chip,a.id_ram,a.id_man,a.id_tainghe,a.id_chuot,a.id_banphim,b.DonGia,a.GhiChu FROM MayTinh a JOIN Phong b ON a.id_phong=b.id_phong WHERE a.TinhTrang= '' AND a.id_phong='"+cboPhong.Text.Trim()+"'";
            tblMay= Functions.GetDataToTable(sql);
            Load_dtgv1();
        }

        private void txtTenkhach_Click(object sender, EventArgs e)
        {
            txtTenkhach.Text = "";
        }

        private void ResetValues()
        {
            txtMamay.Text = "";
            txtTenkhach.Text = "--Tên khách";
            cboPhong.SelectedIndex = -1;
            cboPhong.Text = "--Phòng";                  
            cboNhanvien.SelectedIndex = -1;
            cboNhanvien.Text = "--Nhân viên";
            dtgv1.DataSource = null;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblTime.Text = time.ToString("HH:mm:ss");
        }
    }
}

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
using System.Data.SqlClient;

namespace Quanly.Danh_mục
{
    public partial class Baotri : Form
    {
        DataTable tbla;
        public Baotri()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetValues()
        {
            cboMay.Text = "--Máy bảo trì";
            cboNBT.Text = "--Nhà bảo trì";
            cboNguyennhan.Text = "--Nguyên nhân";
            cboGiaiphap.Text = "--Giải pháp";
            txtDay_start.Text = DateTime.Today.ToString("yyyy'/'MM'/'dd");
            txtThoigian.Text = "";
            txtChiphi.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnSave.Enabled = false;
            cboMay.Enabled = false;
            cboNBT.Enabled = false;
            cboNguyennhan.Enabled = false;
            cboGiaiphap.Enabled = false;
            txtDay_start.Enabled = false;
            txtThoigian.Enabled = false;
            txtChiphi.Enabled = false;
        }

        private void Load_dtgv()
        {
            string timeht = DateTime.Today.ToString("yyyy/MM/dd");
            string sql = "select b.id_may,a.day_start,a.day_end from baotri a inner join ctbt b on a.id_baotri=b.id_baotri where convert(varchar(20),a.day_end,111) >= convert(varchar(20),getdate(),111)";
            tbla=Functions.GetDataToTable(sql);
            dtgv.DataSource = tbla;
            dtgv.Columns[0].HeaderText = "Mã máy";
            dtgv.Columns[1].HeaderText = "Ngày bắt đầu";
            dtgv.Columns[2].HeaderText = "Ngày kết thúc";
            dtgv.Columns[0].Width = 130;
            dtgv.Columns[1].Width = 130;
            dtgv.Columns[2].Width = 130;

            dtgv.AllowUserToOrderColumns = false;
            dtgv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void Baotri_Load(object sender, EventArgs e)
        {       
            btnSave.Enabled = false;
            cboMay.Enabled = false;
            cboNBT.Enabled = false;
            cboNguyennhan.Enabled = false;
            cboGiaiphap.Enabled = false;
            txtDay_start.Enabled = false;
            txtThoigian.Enabled = false;
            txtChiphi.Enabled = false;
            Load_dtgv();
            Functions.FillCombo("SELECT id_may FROM MayTinh", cboMay, "id_may", "id_may");
            Functions.FillCombo("SELECT id_nbt FROM NhaBaoTri", cboNBT, "id_nbt", "id_nbt");
            Functions.FillCombo("SELECT id_nn,TenNN FROM NguyenNhan", cboNguyennhan, "id_nn", "TenNN");
            Functions.FillCombo("SELECT id_giaiphap,TenGiaiPhap FROM GiaiPhap", cboGiaiphap, "id_giaiphap", "TenGiaiPhap");
            ResetValues();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            cboMay.Enabled = true;
            cboNBT.Enabled = true;
            cboNguyennhan.Enabled = true;
            cboGiaiphap.Enabled = true;
            txtDay_start.Enabled = true;
            btnSave.Enabled = true;
        }

        private void cboGiaiphap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT ThoiGian FROM GiaiPhap WHERE TenGiaiPhap=N'" + cboGiaiphap.Text + "'";
            string ngay = Functions.GetFieldValues(sql);
            if (ngay=="0")
            {
                txtThoigian.Text = "Trong ngày";
            }
            else
            {
                txtThoigian.Text = ngay + " ngày";
            }
            string sql2 = "SELECT ChiPhi FROM GiaiPhap WHERE TenGiaiPhap=N'" + cboGiaiphap.Text + "'";
            txtChiphi.Text = Functions.GetFieldValues(sql2);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboMay.Text == "")
            {
                MessageBox.Show("Hãy chọn máy!!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboNBT.Text == "")
            {
                MessageBox.Show("Hãy chọn nhà bảo trì!!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboNguyennhan.Text == "")
            {
                MessageBox.Show("Hãy chọn nguyên nhân!!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboGiaiphap.Text == "")
            {
                MessageBox.Show("Hãy chọn giải pháp!!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDay_start.Text == "")
            {
                MessageBox.Show("Điền ngày bắt đầu!!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string mann = Functions.GetFieldValues("SELECT id_nn FROM NguyenNhan WHERE TenNN=N'" + cboNguyennhan.Text + "'");
            string magp = Functions.GetFieldValues("SELECT id_giaiphap FROM GiaiPhap WHERE TenGiaiPhap=N'" + cboGiaiphap.Text + "'");
            int thoigian =Convert.ToInt32( Functions.GetFieldValues("SELECT ThoiGian FROM GiaiPhap WHERE id_giaiphap='" + magp + "'"));
            DateTime daystart= Convert.ToDateTime(txtDay_start.Text);
            DateTime dayend = daystart.AddDays(thoigian);
            string strdaystart = daystart.ToString("yyyy'/'MM'/'dd");
            string strdayend = dayend.ToString("yyyy'/'MM'/'dd");
            string sql = "insert into baotri(id_nbt,day_start,day_end,TongChiPhi) values('"+cboNBT.Text+"','"+strdaystart+"','"+strdayend+"',"+txtChiphi.Text+")";
            Functions.RunSql(sql);
            sql = "INSERT into ctbt (id_may,id_giaiphap,id_nn) values('"+cboMay.Text+"','"+magp+"','"+mann+"')";
            Functions.RunSql(sql);
            Load_dtgv();
            ResetValues();
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            cboMay.Enabled = false;
            cboNBT.Enabled = false;
            cboGiaiphap.Enabled = false;
            cboNguyennhan.Enabled = false;
            txtDay_start.Enabled = false;
        }
    }
}

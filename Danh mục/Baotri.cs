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
            txtDay_start.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtDay_end.Text = "";
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
            txtDay_end.Enabled = false;
            txtChiphi.Enabled = false;
        }

        private void Load_dtgv()
        {
            string sql = "SELECT b.id_may,a.day_start,a.day_end FROM BaoTri a join CTBT b ON a.id_baotri=b.id_baotri WHERE DATEDIFF(DAY,CONVERT(varchar(10),GETDATE(),111),a.day_end) >=0";
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
            ResetValues();
            btnSave.Enabled = false;
            cboMay.Enabled = false;
            cboNBT.Enabled = false;
            cboNguyennhan.Enabled = false;
            cboGiaiphap.Enabled = false;
            txtDay_start.Enabled = false;
            txtDay_end.Enabled = false;
            txtChiphi.Enabled = false;
            Load_dtgv();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //cbo
        }
    }
}

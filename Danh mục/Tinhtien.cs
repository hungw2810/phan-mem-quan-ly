using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data ;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace Quanly.Danh_mục
{
    public partial class Tinhtien : Form
    {
        DataTable tbla;
        public Tinhtien()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Tinhtien_Load(object sender, EventArgs e)
        {
            btnThanhtoan.Enabled = false;;
            txtTongtien.Enabled = false;
            txtMathue.Enabled = false;
            txtTenkhach.Enabled = false;
            txtMamay.Enabled = false;
            Load_dtgv();
            ResetValues();
        }
        private void ResetValues()
        {
            txtMathue.Text = "--Mã thuê";
            txtTenkhach.Text = "--Tên khách";
            txtMamay.Text = "--Mã máy";
            txtTongtien.Text = "";
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_dtgv();
            ResetValues();
            btnThanhtoan.Enabled = false;
        }
        private void Load_dtgv()
        {
            string sql="SELECT id_stt,id_may,id_phong,TenKhach,GioVao,id_nv FROM ThueMay WHERE GioRa is NULL";
            tbla = Functions.GetDataToTable(sql);
            dtgv.DataSource = tbla;
            dtgv.Columns[0].HeaderText = "Mã Thuê";
            dtgv.Columns[1].HeaderText = "Máy";
            dtgv.Columns[2].HeaderText = "Phòng";
            dtgv.Columns[3].HeaderText = "Tên khách";
            dtgv.Columns[4].HeaderText = "Giờ vào";
            dtgv.Columns[5].HeaderText = "Nhân viên";
            dtgv.AllowUserToAddRows = false;
            dtgv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.lblTime.Text = time.ToString("HH:mm:ss");
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE ThueMay SET GioRa=CONVERT(CHAR(7),CURRENT_TIMESTAMP,108),TongTien=DATEDIFF(minute,(SELECT GioVao FROM ThueMay WHERE id_stt=" + int.Parse(txtMathue.Text) + "),CONVERT(CHAR(7),CURRENT_TIMESTAMP,108)) * (SELECT DonGia/60 FROM Phong JOIN ThueMay on Phong.id_phong=ThueMay.id_phong WHERE id_stt=" + int.Parse(txtMathue.Text) + ") WHERE id_stt="+int.Parse(txtMathue.Text);
            Functions.RunSql(sql);
            txtTongtien.Text = Functions.GetFieldValues("SELECT TongTien FROM ThueMay WHERE id_stt=" + int.Parse(txtMathue.Text)).ToString();
            sql = "UPDATE MayTinh SET TinhTrang='' WHERE id_may='" + txtMamay.Text + "'";
            Functions.RunSql(sql);
            btnThanhtoan.Enabled = false;
        }

        private void dtgv_Click(object sender, EventArgs e)
        {
            txtMathue.Text = dtgv.CurrentRow.Cells["id_stt"].Value.ToString();
            txtTenkhach.Text = dtgv.CurrentRow.Cells["TenKhach"].Value.ToString();
            txtMamay.Text = dtgv.CurrentRow.Cells["id_may"].Value.ToString();
            btnThanhtoan.Enabled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

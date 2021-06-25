using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanly.Báo_cáo
{
    public partial class Baotri : Form
    {
        DataTable tblBCBT;
        public Baotri()
        {
            InitializeComponent();
        }

        private void Baotri_Load(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT id_phong FROM Phong", cboMaphong, "id_phong", "id_phong");
            cboMaphong.SelectedIndex = -1;
            DataGridView.DataSource = null;
            resetvalues();

        }
        private void resetvalues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            cboMaphong.Text = "";
            

        }
           private void Load_DataGridView()
        {
            DataGridView.Columns[0].HeaderText = "Mã bảo trì";
            DataGridView.Columns[1].HeaderText = "Mã máy";
            DataGridView.Columns[2].HeaderText = "Mã phòng";
            DataGridView.Columns[3].HeaderText = "Mã nhà bảo trì";
            DataGridView.Columns[4].HeaderText = "Ngày bắt đầu";
            DataGridView.Columns[5].HeaderText = "Ngày kết thúc";
            DataGridView.Columns[6].HeaderText = "Tổng chi phí";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 100;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[3].Width = 100;
            DataGridView.Columns[4].Width = 100;
            DataGridView.Columns[5].Width = 100;
            DataGridView.Columns[6].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        
               
            

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtThang.Text == "") && (txtQuy.Text == "") && (txtNam.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboMaphong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã phòng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT a.id_baotri,b.id_may,b.id_phong,c.id_nbt,c.day_start,c.day_end,c.TongChiPhi FROM CTBT a INNER JOIN MayTinh b ON a.id_may=b.id_may INNER JOIN BaoTri c ON a.id_baotri=c.id_baotri WHERE 1=1";
            if (cboMaphong.Text != "")
                sql = sql + " AND id_phong Like N'%" + cboMaphong.Text +"%'";
            if (txtThang.Text != "")
                sql = sql + " AND MONTH(day_start) Like N'%" + txtThang.Text + "%'";
            if (txtNam.Text != "")
                sql = sql + " AND YEAR(day_start) Like N'%" + txtNam.Text + "%'";

            tblBCBT = Functions.GetDataToTable(sql);
            if (tblBCBT.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblBCBT.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DataGridView.DataSource = tblBCBT;
            TongChiPhi();
           Load_DataGridView();
            
            
           
        }
        private void TongChiPhi()
        {
            //string sql;
            double Chiphi;
            //sql = "SELECT a.id_baotri,b.id_may,b.id_phong,c.id_nbt,c.day_start,c.day_end,c.TongChiPhi FROM CTBT a INNER JOIN MayTinh b ON a.id_may=b.id_may INNER JOIN BaoTri c ON a.id_baotri=c.id_baotri WHERE b.id_phong=N'"+cboMaphong.SelectedValue+"'";
            if (txtThang.Text != "")
            {
                Chiphi = Convert.ToDouble(Functions.GetFieldValues("SELECT SUM(c.TongChiPhi) FROM CTBT a INNER JOIN MayTinh b ON a.id_may=b.id_may INNER JOIN BaoTri c ON a.id_baotri=c.id_baotri WHERE b.id_phong=N'" + cboMaphong.Text.ToString() + " AND (SELECT MONTH(c.day_start) AS char)='"+txtThang.Text.ToString()+"'" ));
                txtTongCP.Text = Chiphi.ToString();
            }
                
            
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            resetvalues();
            DataGridView.DataSource = null;
        }

    }
}

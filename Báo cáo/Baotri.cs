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
        DataTable tbla;
        public Baotri()
        {
            InitializeComponent();
        }
        private void Reset_Values()
        {
            cboThang.SelectedIndex = -1;
            cboQuy.SelectedIndex = -1;
            txtNam.Text = "";
            cboThang.Enabled = true;
            cboQuy.Enabled = true;
            txtNam.Enabled = true;
        }

        private void Baotri_Load(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            btnInbaocao.Enabled = false;
            Reset_Values();
        }

        private void Load_DataGridView()
        {
            DataGridView.Columns[0].HeaderText = "Mã phòng";
            DataGridView.Columns[1].HeaderText = "Tổng chi phí";
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cboThang.Text != "") && (txtNam.Text == ""))
            {
                MessageBox.Show("Nhập năm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((cboQuy.Text != "") && (txtNam.Text == ""))
            {
                MessageBox.Show("Nhập năm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT c.id_phong, sum(a.tongchiphi) AS Tong FROM BaoTri a JOIN CTBT b ON a.id_baotri=b.id_baotri JOIN MayTinh c ON c.id_may= b.id_may WHERE 1=1";
            if ((txtNam.Text != ""))
            {
                sql = sql + "AND (SELECT YEAR(a.day_start) AS CHAR)='" + txtNam.Text.Trim() +"'";
            }
            if ((cboThang.Text!=""))
            {
                sql = sql + " AND (SELECT MONTH(a.day_start) AS CHAR) ='" + cboThang.Text + "'";
            }
            if ((cboQuy.Text != ""))
            {
                if (cboQuy.Text == "1")
                {
                    sql = sql + " AND (SELECT MONTH(a.day_start) AS CHAR) BETWEEN '1' AND '3'";
                }
                if (cboQuy.Text == "2")
                {
                    sql = sql + " AND (SELECT MONTH(a.day_start) AS CHAR) BETWEEN '4' AND '6'";
                }
                if (cboQuy.Text == "3")
                {
                    sql = sql + " AND (SELECT MONTH(a.day_start) AS CHAR) BETWEEN '7' AND '9'";
                }
                if (cboQuy.Text == "4")
                {
                    sql = sql + " AND (SELECT MONTH(a.day_start) AS CHAR) BETWEEN '9' AND '12'";
                }
            }
            tbla = Functions.GetDataToTable(sql+ "GROUP BY c.id_phong");
            if (tbla.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu bảo trì!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Reset_Values();
                btnInbaocao.Enabled = false;
                btnRefresh.Enabled = false;
                btnBaocao.Enabled = true;
            }
            else
            {
                DataGridView.DataSource = tbla;
                Load_DataGridView();
                cboQuy.Enabled = false;
                cboThang.Enabled = false;
                txtNam.Enabled = false;
                btnBaocao.Enabled = false;
                btnRefresh.Enabled = true;
                btnInbaocao.Enabled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reset_Values();
            DataGridView.DataSource = null;
            btnBaocao.Enabled = true;
            btnInbaocao.Enabled = false;
            btnRefresh.Enabled = false;
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboQuy.Enabled = false;
        }

        private void cboQuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboThang.Enabled = false;
        }
    }
}

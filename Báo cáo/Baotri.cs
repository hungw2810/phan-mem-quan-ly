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
            if ((cboThang.Text == "") && (cboQuy.Text == "") && (txtNam.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT b.id_phong,c.TongChiPhi FROM CTBT a INNER JOIN MayTinh b ON a.id_may=b.id_may INNER JOIN BaoTri c ON a.id_baotri=c.id_baotri WHERE 1=1";
            if (cboThang.Text != "")
                sql = sql + " AND MONTH(day_start) Like N'%" + cboThang.Text + "%'";
            if (txtNam.Text != "")
                sql = sql + " AND YEAR(day_start) Like N'%" + txtNam.Text + "%'";

            tbla = Functions.GetDataToTable(sql);
            if (tbla.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tbla.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DataGridView.DataSource = tbla;
            Load_DataGridView();
            btnBaocao.Enabled = false;
            btnRefresh.Enabled = true;
            btnInbaocao.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reset_Values();
            DataGridView.DataSource = null;
            btnBaocao.Enabled = true;
            btnInbaocao.Enabled = false;
            btnRefresh.Enabled=false
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

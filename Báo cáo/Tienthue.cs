using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quanly.Báo_cáo
{
    public partial class Tienthue : Form
    {
        DataTable TT,XX;
        public Tienthue()
        {
            InitializeComponent();
        }

       

        private void Tienthue_Load(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
        }
        private void Load_DataGridView()
        {

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxThang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tt;
            tt = "SELECT SUM(TongTien)  FROM ThueMay";
            XX = Functions.GetDataToTable(tt);
            
            dataGridView2.DataSource = XX;
            if (cbxThang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tháng", "Thông Báo", MessageBoxButtons.OK);
            }
            if (cbxNam.Text == "")
            {
                MessageBox.Show("Bạn phải nhập năm", "Thông Báo", MessageBoxButtons.OK);
            }
            string sql;
            sql = "Select * from ThueMay Where 1=1"; dataGridView1.DataSource = TT; 
            TT = Functions.GetDataToTable(sql);
            if (cbxThang.Text != "")
            {
                sql = sql + "AND MONTH(NgayThue) =" + cbxThang.Text;    
            }
            if (cbxNam.Text != "")
                sql = sql + "AND YEAR(NgayThue) =" + cbxNam.Text;
             txtTongTien.Text=dataGridView2.CurrentRow.Cells[0].Value.ToString();
            Load_DataGridView();
        }
    }
}
    
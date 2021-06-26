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
        DataTable TT;
        public Tienthue()
        {
            InitializeComponent();
        }

       

        private void Tienthue_Load(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
        }
        private void Load_DataGridView()
        {
            
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

       

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tt;
            tt = "SELECT SUM(TongTien) as 'Doanh Thu' FROM ThueMay Where 1=1";
            if (cbxNam.Text == "" && cbxThang.Text == "" && radZoneA.Checked == false && radZoneB.Checked == false && radZoneC.Checked == false)
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            if (cbxThang.Text != "")
            {
                tt = tt + "AND MONTH(NgayThue) =" + cbxThang.Text;    
            }
            if (cbxNam.Text != "")
                tt = tt + "AND YEAR(NgayThue) =" + cbxNam.Text;
            if (radZoneA.Checked == true)
            {
                tt = tt + "AND id_phong='Zone A'";
            }
            if(radZoneB.Checked == true){
                tt = tt + "And id_phong='Zone B'" ;
            }
            if (radZoneC.Checked == true)
            {
                tt = tt + "And id_phong='Zone C'";
            }
            if (cboQuy.Text == "1")
            {
                tt = tt + "AND MONTH(NgayThue) BETWEEN '1' AND '3'";
            }
            if (cboQuy.Text == "2")
            {
                tt = tt + "AND MONTH(NgayThue) BETWEEN '4' AND '6'";
            }
            if (cboQuy.Text == "3")
            {
                tt = tt + "AND MONTH(NgayThue) BETWEEN '7' AND '9'";
            }
            if (cboQuy.Text == "4")
            {
                tt = tt + "AND MONTH(NgayThue) BETWEEN '10' AND '12'";
            }


            TT = Functions.GetDataToTable(tt);
            dataGridView2.DataSource = TT;
           
            Load_DataGridView();
        }
    }
}
    
﻿using System;
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
        public Tienthue()
        {
            InitializeComponent();
        }
    
        private void Tienthue_Load(object sender, EventArgs e)
        {
            
        }
        private void Reset_Values()
        {
            cbxThang.SelectedIndex = -1;
            cbxNam.SelectedIndex = -1;
            cboQuy.SelectedIndex = -1;
            radZoneA.Checked = false;
            radZoneB.Checked = false;
            radZoneC.Checked = false;
            cboQuy.Enabled = true;
            cbxThang.Enabled = true;
            label3.Text = "Tổng tiền ";
        }     
        private void btnTim_Click(object sender, EventArgs e)
        {
            string tt;
            if (cbxNam.Text == "")
            {
                MessageBox.Show("Nhập năm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            {
                tt = tt + "AND YEAR(NgayThue) =" + cbxNam.Text;
            }
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
            label3.Text = label3.Text+ Functions.GetFieldValues(tt);
            btnTim.Enabled = false;
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Reset_Values();
            btnTim.Enabled = true;
        }      
        private void cbxThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboQuy.Enabled = false;
        }
        private void cboQuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxThang.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    
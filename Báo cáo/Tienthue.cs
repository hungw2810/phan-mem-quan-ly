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
using COMExcel = Microsoft.Office.Interop.Excel;

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
     

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            label5.Text = time.ToString("HH:mm:ss");
        }

        private void btn_RP_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel


            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable ThongtinNBT, ThongtinBaotri;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Cửa hàng Internet";

            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Hà Nội";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)88889999";


            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "BÁO CÁO CHI PHÍ";
            // Biểu diễn thông tin chung của Báo cáo chi phí
            sql = "SELECT a.";
            ThongtinNBT = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã nhà bảo trì:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = ThongtinNBT.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Tên nhà bảo trì:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = ThongtinNBT.Rows[0][1].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:J8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = ThongtinNBT.Rows[0][2].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = ThongtinNBT.Rows[0][3].ToString();
            //Lấy thông tin bảo trì
            sql = "SELECT c.id_phong, sum(a.tongchiphi) AS Tong FROM BaoTri a JOIN CTBT b ON a.id_baotri=b.id_baotri JOIN MayTinh c ON c.id_may= b.id_may WHERE 1=1";
            if (cboThang.SelectedIndex != -1)
            {
                cboQuy.Enabled = false;
                txtNam.Enabled = false;
                sql = sql + " AND (SELECT MONTH(a.day_start) AS CHAR) ='" + cboThang.Text + "' GROUP BY c.id_phong";
            }
            if (cboQuy.SelectedIndex != -1)
            {
                cboThang.Enabled = false;
                txtNam.Enabled = false;
                if (cboQuy.Text == "1")
                {
                    sql = sql + "AND (SELECT MONTH(a.day_start) AS CHAR) BETWEEN '1' AND '3' GROUP BY c.id_Phong";
                }
                if (cboQuy.Text == "2")
                {
                    sql = sql + "AND (SELECT MONTH(a.day_start) AS CHAR) BETWEEN '4' AND '6' GROUP BY c.id_Phong";
                }
                if (cboQuy.Text == "3")
                {
                    sql = sql + "AND (SELECT MONTH(a.day_start) AS CHAR) BETWEEN '7' AND '9' GROUP BY c.id_Phong";
                }
                if (cboQuy.Text == "4")
                {
                    sql = sql + "AND (SELECT MONTH(a.day_start) AS CHAR) BETWEEN '9' AND '12' GROUP BY c.id_Phong";
                }
            }
            if (txtNam.Text.Length != 0)
            {
                cboThang.Enabled = false;
                cboQuy.Enabled = false;
                sql = sql + "AND (SELECT YEAR(a.day_start) AS CHAR)='" + txtNam.Text.Trim() + "' GROUP BY c.id_Phong";
            }
            ThongtinBaotri = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A11:F11"].ColumnWidth = 15;
            exRange.Range["A11:A11"].Value = "Mã phòng";
            exRange.Range["B11:B11"].Value = "Tổng tiền";
            for (hang = 0; hang <= ThongtinBaotri.Rows.Count - 1; hang++)
            {
                for (cot = 0; cot <= ThongtinBaotri.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 1, dòng 12
                    exSheet.Cells[cot + 1][hang + 12] = ThongtinBaotri.Rows[hang][cot].ToString();
            }

            exSheet.Name = "Báo Cáo Chi Phí";
            exApp.Visible = true;

        }
    }
}
    
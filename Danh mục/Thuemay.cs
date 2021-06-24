using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanly.Danh_mục
{
    public partial class Thuemay : Form
    {
        public Thuemay()
        {
            InitializeComponent();
        }

        private void Thuemay_Load(object sender, EventArgs e)
        {
            btnThue.Enabled = false;
            btnTinhtien.Enabled = false;
            Load_dtgv1();
        }
        private void Load_dtgv1()
        {
            
        }

        private void btnThue_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhtien_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}

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
        }

        private void Tinhtien_Load(object sender, EventArgs e)
        {

        }
        private void Load_dtgv()
        {
           // string sql = "SELECT id_may,id_phong,TenKhach,GioVao,id_NhanVien FROM MayTinh WHERE ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanly.Dữ_liệu.Bảo_trì
{
    public partial class Giaiphap : Form
    {
        DataTable tbl;
        public Giaiphap()
        {
            InitializeComponent();
        }

        private void Giaiphap_Load(object sender, EventArgs e)
        {

            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM GiaiPhap";
            tbl = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tbl;
            dataGridView1.Columns[0].HeaderText = "Tên Giải Pháp";
            dataGridView1.Columns[1].HeaderText = "Chi Phí";
            dataGridView1.Columns[2].HeaderText = "Thời Gian";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtGiaiphap.Focus();
                return;
            }
            if (tbl.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            txtGiaiphap.Text = dataGridView1.CurrentRow.Cells["TenGiaiPhap"].Value.ToString();
            txtChiPhi.Text = dataGridView1.CurrentRow.Cells["Tenkhach"].Value.ToString();
            txtThoigian.Text = dataGridView1.CurrentRow.Cells["Diachi"].Value.ToString();
            

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtGiaiphap.Focus();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnSua.Enabled = false;
            Reset();
        }
        private void Reset()
        {
            txtGiaiphap.Text = "";
            txtChiPhi.Text = "";
            txtThoigian.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtGiaiphap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giải pháp", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtGiaiphap.Focus();
                return;
            }
            if (txtChiPhi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Chi phí", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChiPhi.Focus();
                return;
            }
            if (txtThoigian.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thời gian", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtThoigian.Focus();
                return;
            }
            
            sql = "SELECT TenGiaiPhap FROM tblKhach WHERE Makhach=N'" + txtGiaiphap.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách này đã có, bạn phải nhập mã khác", "Thông báo",
 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaiphap.Focus();
                txtGiaiphap.Text = "";
                return;
            }
            sql = "INSERT INTO GiaiPhap(TenGiaiPhap,ChiPhi,ThoiGian) VALUES (N'" +
txtGiaiphap.Text.Trim() + "',N'" + txtChiPhi.Text.Trim() + "',N'" +
txtThoigian.Text.Trim() + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            Reset();

        }
    }
}

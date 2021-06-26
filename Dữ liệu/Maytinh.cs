using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanly.Dữ_liệu
{
    public partial class Maytinh : Form
    {
        DataTable tblMT;
        public Maytinh()
        {
            InitializeComponent();
        }

        private void Maytinh_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            txtMamay.Enabled = false;
            Functions.FillCombo("SELECT id_phong FROM Phong", cboMaphong, "id_phong", "id_phong");
            cboMaphong.SelectedIndex = -1;
            Functions.FillCombo("SELECT id_oc,TenOC FROM OCung", cboMaocung, "id_oc", "TenOC");
            cboMaocung.SelectedIndex = -1;
            Functions.FillCombo("SELECT id_chip,TenChip FROM Chip", cboMachip, "id_chip", "TenChip");
            cboMachip.SelectedIndex = -1;
            Functions.FillCombo("SELECT id_ram,TenRam FROM Ram", cboMaram, "id_ram", "TenRam");
            cboMaram.SelectedIndex = -1;
            Functions.FillCombo("SELECT id_man,TenMan FROM ManHinh", cboMamanhinh, "id_man", "TenMan");
           cboMamanhinh.SelectedIndex = -1;
            Functions.FillCombo("SELECT id_chuot,TenChuat FROM Chuot", cboMachuot, "id_chuot", "TenChuat");
            cboMachuot.SelectedIndex = -1;
            Functions.FillCombo("SELECT id_banphim,TenBanPhim FROM BanPhim", cboMabanphim, "id_banphim", "TenBanPhim");
            cboMabanphim.SelectedIndex = -1;
            Functions.FillCombo("SELECT id_tainghe,TenTaiNghe FROM TaiNghe", cboMatainghe, "id_tainghe", "TenTaiNghe");
            cboMatainghe.SelectedIndex = -1;           
            Load_DataGridView();
            resetvalues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT id_may,id_phong,id_ocung,id_chip,id_ram,id_man,id_tainghe,id_chuot,id_banphim,TinhTrang,GhiChu FROM MayTinh";
            tblMT = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblMT;
            DataGridView.Columns[0].HeaderText = "Mã máy";
            DataGridView.Columns[1].HeaderText = "Mã phòng";
            DataGridView.Columns[2].HeaderText = "Mã ổ cứng";
            DataGridView.Columns[3].HeaderText = "Mã chip";
            DataGridView.Columns[4].HeaderText = "Mã ram";
            DataGridView.Columns[5].HeaderText = "Mã màn";
            DataGridView.Columns[6].HeaderText = "Mã tai nghe";
            DataGridView.Columns[7].HeaderText = "Mã chuột";
            DataGridView.Columns[8].HeaderText = "Mã bàn phím";
            DataGridView.Columns[9].HeaderText = "Tình trạng";
            DataGridView.Columns[10].HeaderText = "Ghi chú";

            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            string p, oc, c, r, m, ch, tn, bp;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMamay.Focus();
                return;
            }
            if (tblMT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMamay.Text = DataGridView.CurrentRow.Cells["id_may"].Value.ToString();
            p = DataGridView.CurrentRow.Cells["id_phong"].Value.ToString();
            cboMaphong.Text = Functions.GetFieldValues("SELECT id_phong FROM Phong WHERE id_phong =N'" + p + "'");
            oc = DataGridView.CurrentRow.Cells["id_ocung"].Value.ToString();
            cboMaocung.Text = Functions.GetFieldValues("SELECT id_oc FROM OCung WHERE id_oc =N'" + oc + "'");
            c = DataGridView.CurrentRow.Cells["id_chip"].Value.ToString();
            cboMachip.Text = Functions.GetFieldValues("SELECT id_chip FROM Chip WHERE id_chip =N'" + c + "'");
            r = DataGridView.CurrentRow.Cells["id_ram"].Value.ToString();
            cboMaram.Text = Functions.GetFieldValues("SELECT id_ram FROM Ram WHERE id_ram =N'" + r + "'");
            m = DataGridView.CurrentRow.Cells["id_man"].Value.ToString();
            cboMamanhinh.Text = Functions.GetFieldValues("SELECT id_man FROM ManHinh WHERE id_man =N'" + m + "'");
            tn = DataGridView.CurrentRow.Cells["id_tainghe"].Value.ToString();
            cboMatainghe.Text = Functions.GetFieldValues("SELECT id_tainghe FROM TaiNghe WHERE id_tainghe =N'" + tn + "'");
            ch = DataGridView.CurrentRow.Cells["id_chuot"].Value.ToString();
            cboMachuot.Text = Functions.GetFieldValues("SELECT id_chuot FROM Chuot WHERE id_chuot =N'" + ch + "'");
            bp = DataGridView.CurrentRow.Cells["id_banphim"].Value.ToString();
            cboMabanphim.Text = Functions.GetFieldValues("SELECT id_banphim FROM BanPhim WHERE id_banphim =N'" + bp + "'");
            txtTinhtrang.Text = DataGridView.CurrentRow.Cells["TinhTrang"].Value.ToString();
            txtGhichu.Text = DataGridView.CurrentRow.Cells["GhiChu"].Value.ToString();
            btnBoqua.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        private void resetvalues()
        {
            txtMamay.Text = "";
            txtGhichu.Text = "";
            txtTinhtrang.Text = "";
            cboMabanphim.Text = "";
            cboMachip.Text = "";
            cboMachuot.Text = "";
            cboMamanhinh.Text = "";
            cboMaocung.Text = "";
            cboMaphong.Text = "";
            cboMaram.Text = "";
            cboMatainghe.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            resetvalues();
            txtMamay.Focus();
            txtMamay.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double soluong, slmoi;
            if (txtMamay.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMamay.Focus();
                return;
            }
            if (cboMaphong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaphong.Focus();
                return;
            }
            if (cboMaocung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã ổ cứng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaocung.Focus();
                return;
            }
            if (cboMachip.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chip", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMachip.Focus();
                return;
            }

            if (cboMaram.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã ram", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaram.Focus();
                return;
            }
            if (cboMamanhinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã màn hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMamanhinh.Focus();
                return;
            }
            if (cboMachuot.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chuột", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMachuot.Focus();
                return;
            }
            if (cboMabanphim.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã bàn phím", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMabanphim.Focus();
                return;
            }
            if (cboMatainghe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã tai nghe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMatainghe.Focus();
                return;
            }
            sql = "SELECT id_may FROM MayTinh WHERE id_may=N'" + txtMamay.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã máy này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMamay.Focus();
                txtMamay.Text = "";
                return;
            }
            sql = "INSERT INTO MayTinh(id_may,id_phong,id_ocung,id_chip,id_ram,id_man,id_tainghe,id_chuot,id_banphim,TinhTrang,GhiChu) VALUES(N'" + txtMamay.Text.Trim() + "',N'" + cboMaphong.SelectedValue.ToString() + "',N'" + cboMaocung.SelectedValue.ToString() + "',N'" + cboMachip.SelectedValue.ToString() + "',N'" + cboMaram.SelectedValue.ToString() + "',N'" + cboMamanhinh.SelectedValue.ToString() + "',N'" + cboMatainghe.SelectedValue.ToString() + "',N'" + cboMachuot.SelectedValue.ToString() + "',N'" + cboMabanphim.SelectedValue.ToString() + "',N'" + txtTinhtrang.Text.Trim() + "',N'" + txtGhichu.Text.Trim() + "')";

            Functions.RunSql(sql);
            Load_DataGridView();
            soluong = Convert.ToDouble(Functions.GetFieldValues("SELECT SoMay FROM Phong WHERE id_phong=N'" + cboMaphong.SelectedValue + "'"));
            slmoi = soluong + 1;
            sql = "UPDATE Phong SET SoMay=" + slmoi + "WHERE id_phong =N'" + cboMaphong.SelectedValue + "'";
            Functions.RunSql(sql);
            resetvalues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            txtMamay.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            double soluong, slmoi;
            if (tblMT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMamay.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE MayTinh WHERE id_may=N'" + txtMamay.Text + "'";
                Functions.RunSqlDel(sql);
                soluong = Convert.ToDouble(Functions.GetFieldValues("SELECT SoMay FROM Phong WHERE id_phong=N'" + cboMaphong.SelectedValue + "'"));
                slmoi = soluong - 1;
                sql = "UPDATE Phong SET SoMay=" + slmoi + "WHERE id_phong =N'" + cboMaphong.SelectedValue + "'";
                Functions.RunSql(sql);
                Load_DataGridView();
                resetvalues();
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            // double soluong, slmoi;
            if (txtMamay.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMamay.Focus();
                return;
            }
            if (cboMaphong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaphong.Focus();
                return;
            }
            if (cboMaocung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã ổ cứng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaocung.Focus();
                return;
            }
            if (cboMachip.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chip", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMachip.Focus();
                return;
            }

            if (cboMaram.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã ram", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaram.Focus();
                return;
            }
            if (cboMamanhinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã màn hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMamanhinh.Focus();
                return;
            }
            if (cboMachuot.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chuột", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMachuot.Focus();
                return;
            }
            if (cboMabanphim.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã bàn phím", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMabanphim.Focus();
                return;
            }
            if (cboMatainghe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã tai nghe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMatainghe.Focus();
                return;
            }
            sql = "UPDATE MayTinh SET id_phong=N'" + cboMaphong.SelectedValue.ToString() + "',id_ocung = N'" + cboMaocung.SelectedValue.ToString() + "',id_chip = N'" + cboMachip.SelectedValue.ToString() + "',id_ram = N'" + cboMaram.SelectedValue.ToString() + "',id_man = N'" + cboMamanhinh.SelectedValue.ToString() + "',id_tainghe = N'" + cboMatainghe.SelectedValue.ToString() + "',id_chuot = N'" + cboMachuot.SelectedValue.ToString() + "',id_banphim = N'" + cboMabanphim.SelectedValue.ToString() + "',TinhTrang=N'" + txtTinhtrang.Text.Trim() + "',GhiChu=N'" + txtGhichu.Text.Trim() + "'WHERE id_may=N'" + txtMamay.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            resetvalues();
            btnBoqua.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            resetvalues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMamay.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

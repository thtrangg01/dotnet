using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // thêm thư viện

namespace CSDL_Test
{
    public partial class FrmTimKiem : Form
    {
        public FrmTimKiem()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi(); // khởi tạo class
        private void FrmTimKiem_Load(object sender, EventArgs e)
        {
            //txtTen.Enabled = false;
            //cboMa.Enabled = false;

            DataTable dta = kn.Lay_DulieuBang("Select * from PHONGBAN order by ma_PB");
            cboMa.DataSource = dta;
            cboMa.DisplayMember = "Ma_PB";

            DataTable dta1 = kn.Lay_DulieuBang("Select * from CHUCVU order by ma_CV");
            cboMaCV.DataSource = dta1;
            cboMaCV.DisplayMember = "Ma_CV";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;

            if(optNhapMa.Checked == true) 
            {
                sqltk = "Select * from NHANVIEN where MA_NV like '" + txtMa.Text + "'";
                dta = kn.Lay_DulieuBang(sqltk);
            }

            if(optNhapTen.Checked == true)
            {
                sqltk = "Select * from NHANVIEN where Ten_NV like '%" + txtTen.Text + "%'";
                dta = kn.Lay_DulieuBang(sqltk);
            }

            if(optNhapMa1.Checked == true)
            {
                sqltk = "Select * from NHANVIEN where MA_PB like '" + cboMa.Text + "'";
                dta = kn.Lay_DulieuBang(sqltk);
            }

            if (optNhapMaCV.Checked == true)
            {
                sqltk = "Select * from NHANVIEN where MA_CV like '" + cboMaCV.Text + "'";
                dta = kn.Lay_DulieuBang(sqltk);
            }

            GridTimKiem.DataSource = dta;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //this.Close();
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK)
                this.Close();
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void GridTimKiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void optNhapMa_CheckedChanged(object sender, EventArgs e)
        {
            txtMa.Focus();

            txtMa.Enabled = true;
            txtTen.Clear();

            txtTen.Enabled = false;
            cboMa.Enabled = false;
            cboMaCV.Enabled = false;
        }

        private void optNhapTen_CheckedChanged(object sender, EventArgs e)
        {
            txtTen.Focus();

            txtTen.Enabled = true;
            txtTen.Clear();

            txtMa.Enabled = false;
            cboMa.Enabled = false;
            cboMaCV.Enabled = false;
        }

        private void optNhapMa1_CheckedChanged(object sender, EventArgs e)
        {
            cboMa.Focus();

            cboMa.Enabled = true;
            txtTen.Clear();

            txtTen.Enabled = false;
            txtMa.Enabled = false;
            cboMaCV.Enabled = false;
        }

        private void optNhapMaCV_CheckedChanged(object sender, EventArgs e)
        {
            cboMaCV.Focus();

            cboMaCV.Enabled = true;
            txtTen.Clear();

            txtTen.Enabled = false;
            txtMa.Enabled = false;
            cboMa.Enabled = false;
        }
    }
}

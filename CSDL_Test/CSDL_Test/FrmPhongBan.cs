using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDL_Test
{
    public partial class FrmPhongBan : Form
    {

        private KetNoi kn;
        public FrmPhongBan()
        {
            InitializeComponent();
            kn = new KetNoi();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNS_QLLUONGDataSet.PHONGBAN' table. You can move, or remove it, as needed.
            this.pHONGBANTableAdapter.Fill(this.qLNS_QLLUONGDataSet.PHONGBAN);
            LoadPhongBanData();
            btn_Luu.Enabled = false;
        }

        private void LoadPhongBanData()
        {
            KetNoi kn = new KetNoi();
            kn.KetNoi_Dulieu();
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * FROM PHONGBAN");
            DataGrid_PhongBan.DataSource = dta;
            btn_Luu.Enabled = false;
        }

        private void DataGrid_PhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPB.DataBindings.Clear();
            txtMaPB.DataBindings.Add("text", DataGrid_PhongBan.DataSource, "ma_PB");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("text", DataGrid_PhongBan.DataSource, "dien_thoai");

            txtTenPB.DataBindings.Clear();
            txtTenPB.DataBindings.Add("text", DataGrid_PhongBan.DataSource, "ten_PB");
        }

        private void btn_Taomoi_Click(object sender, EventArgs e)
        {
            txtMaPB.Text = " ";
            txtTenPB.Text = "";
            txtSDT.Text = "";
            txtMaPB.Focus();
            btn_Luu.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string sql_Luu = "Insert into PHONGBAN Values(' " + txtMaPB.Text + "', '" + txtTenPB.Text + "', '" + txtSDT.Text + "')";
            kn.ThucThi(sql_Luu);
            LoadPhongBanData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql_Sua = "Update PHONGBAN Set ten_PB = '" + txtTenPB.Text + "', dien_thoai = '" + txtSDT.Text + "' where ma_PB = '" + txtMaPB.Text + "'";
            kn.ThucThi(sql_Sua);
            LoadPhongBanData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql_Xoa = "Delete PHONGBAN where ma_PB ='" + txtMaPB.Text + "'";
            kn.ThucThi(sql_Xoa);
            LoadPhongBanData();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

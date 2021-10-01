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
    public partial class FrmChucVu : Form
    {

        private KetNoi kn;
        public FrmChucVu()
        {
            InitializeComponent();
            kn = new KetNoi();
        }

        private void FrmChucVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNS_QLLUONGDataSet1.CHUCVU' table. You can move, or remove it, as needed.
            this.cHUCVUTableAdapter.Fill(this.qLNS_QLLUONGDataSet1.CHUCVU);
            LoadChucVuData();
            btn_Luu.Enabled = false;
        }

        private void LoadChucVuData()
        { 
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * FROM CHUCVU");
            GridChucVu.DataSource = dta;
            btn_Luu.Enabled = false;
        }

        private void GridChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_TenCV.DataBindings.Clear();
            txt_TenCV.DataBindings.Add("text", GridChucVu.DataSource, "ten_CV");

            txt_MaCV.DataBindings.Clear();
            txt_MaCV.DataBindings.Add("text", GridChucVu.DataSource, "ma_CV");

            num_PhuCap.DataBindings.Clear();
            num_PhuCap.DataBindings.Add("value", GridChucVu.DataSource, "phu_cap");
        }

        private void btn_Taomoi_Click(object sender, EventArgs e)
        {
            txt_TenCV.Text = " ";
            txt_MaCV.Text = "";
            num_PhuCap.Value = 0;
            txt_TenCV.Focus();
            btn_Luu.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string sql_Luu = "Insert into CHUCVU Values(' " + txt_TenCV.Text + "', '" + txt_MaCV.Text + "', " + num_PhuCap.Value + ")";
            kn.ThucThi(sql_Luu);
            LoadChucVuData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql_Sua = "Update CHUCVU Set ten_CV = '" + txt_TenCV.Text + "', phu_cap = " + num_PhuCap.Value + " where ma_CV = '" + txt_MaCV.Text + "'";
            kn.ThucThi(sql_Sua);
            LoadChucVuData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql_Xoa = "Delete CHUCVU where ma_PB ='" + txt_MaCV.Text + "'";
            kn.ThucThi(sql_Xoa);
            LoadChucVuData();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

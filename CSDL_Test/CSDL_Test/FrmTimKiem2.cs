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
    public partial class FrmTimKiem2 : Form
    {
        public FrmTimKiem2()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK)
                this.Close();
        }

        private void FrmTimKiem2_Load(object sender, EventArgs e)
        {
            DataTable dta = kn.Lay_DulieuBang("Select * from CHUCVU");
            cboMaCV.DataSource = dta;
            cboMaCV.DisplayMember = "Ma_CV";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sql_tk = string.Format("Execute SP_TIM_CHUCVU '{0}'", cboMaCV.Text);
            dta = kn.Lay_DulieuBang(sql_tk);
            GridKetQua.DataSource = dta;
        }
    }
}

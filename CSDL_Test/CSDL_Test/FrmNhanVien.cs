using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSDL_Test
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        public void BangNhanvien()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From NHANVIEN");
            Grid_NhanVien.DataSource = dta;
            //Hienthi_Dulieu();
        }

        public void BangChucVu()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From CHUCVU");
            cbBox_Chucvu.DataSource = dta;
            cbBox_Chucvu.DisplayMember = "ma_CV";
            cbBox_Chucvu.ValueMember = "ma_CV";
        }

        public void BangPhongBan()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * From PHONGBAN");
            cbBox_PB.DataSource = dta;
            cbBox_PB.DisplayMember = "ma_PB";
            cbBox_PB.ValueMember = "ma_PB";
        }
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNS_QLLUONGDataSet2.NHANVIEN' table. You can move, or remove it, as needed.
            //this.nHANVIENTableAdapter.Fill(this.qLNS_QLLUONGDataSet2.NHANVIEN);
            BangChucVu();
            BangNhanvien();
            BangPhongBan();
            //Hienthi_Dulieu();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            //this.Close();
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK)
                this.Close();
        }

        private void btn_Taomoi_Click(object sender, EventArgs e)
        {
            txt_MaNV.Text = " ";
            txt_hoten.Text = " ";
            num_hsl.Value = 0;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string strKtra = "Select ma_NV from NHANVIEN where ma_NV = '" + txt_MaNV.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_dl = cmd.ExecuteReader();
            if(doc_dl.Read() == true)
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại, nhập lại mã khác", "Thông báo");
                txt_MaNV.Focus();
                doc_dl.Close();
                doc_dl.Dispose();
            }
            else 
            {
                string sql_Luu = "Insert into NHANVIEN Values(' " + txt_MaNV.Text + "', '" + txt_hoten.Text + "', " + num_hsl.Value + ", '" + cbBox_Chucvu.Text + "', '" + cbBox_PB.Text + "')";

                kn.ThucThi(sql_Luu);
                BangNhanvien();
            }
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql_Sua = "Update NHANVIEN Set ten_NV = '" + txt_hoten.Text + "'";
            sql_Sua = sql_Sua + ", he_so_luong = " + num_hsl.Value + ", ma_CV = '" + cbBox_Chucvu.Text + "',";
            sql_Sua = sql_Sua + "ma_PB = '" + cbBox_PB.Text + "' where ma_NV = '" + txt_MaNV.Text + "'";
            kn.ThucThi(sql_Sua);
            BangNhanvien();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql_Xoa = "Delete NHANVIEN where ma_NV ='" + txt_MaNV.Text + "'";
            kn.ThucThi(sql_Xoa);
            BangNhanvien();
        }

        private void Hienthi_Dulieu()
        {
            txt_MaNV.DataBindings.Clear();
            txt_MaNV.DataBindings.Add("Text", Grid_NhanVien.DataSource, "ma_NV");


            txt_hoten.DataBindings.Clear();
            txt_hoten.DataBindings.Add("Text", Grid_NhanVien.DataSource, "ten_NV");


            num_hsl.DataBindings.Clear();
            num_hsl.DataBindings.Add("Text", Grid_NhanVien.DataSource, "he_so_Luong");


            cbBox_Chucvu.DataBindings.Clear();
            cbBox_Chucvu.DataBindings.Add("Text", Grid_NhanVien.DataSource, "ma_CV");


            cbBox_PB.DataBindings.Clear();
            cbBox_PB.DataBindings.Add("Text", Grid_NhanVien.DataSource, "ma_PB");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSDL_Test
{
    class KetNoi
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable data;
        public SqlDataAdapter adapter;

        public void KetNoi_Dulieu()
        {
            string strKetNoi = @"Data Source=LAPTOP-0F0PHERC\SQLEXPRESS;Initial Catalog=QLNS_QLLUONG;Integrated Security=True";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }

        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }


        public DataTable Lay_DulieuBang(string Sql)
        {
            KetNoi_Dulieu();
            adapter = new SqlDataAdapter(Sql, cnn);
            data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public void ThucThi(string sql)
        {
            KetNoi_Dulieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
    }
}

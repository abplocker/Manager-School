using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTruong
{
    class LOPDUNGCHUNG
    {
        string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\QuanLySinhVien\QuanLyTruong\QuanLy.mdf;Integrated Security=True";
        SqlConnection conn;
        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection(chuoikn);
        }
        public void ThemXoaSua(string sql)
        {
            try
            {
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                int kq = comm.ExecuteNonQuery();
                conn.Close();
                if (kq >= 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi trùng mã");
            }
        }
        public object ExcuteScalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public DataTable LayDLBang(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        public void lammoi(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }
                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
                if(c is ComboBox)
                {
                    ((ComboBox)c).ResetText();
                }
            } // foreach
        }// lammoi
    }
}

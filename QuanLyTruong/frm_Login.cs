using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTruong
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG phuongthuoc = new LOPDUNGCHUNG();
        private void txt_Login_Click(object sender, EventArgs e)
        {
            if (txt_tendangnhap.Text == "admin" && txt_mk.Text == "12345")
            {
                Hide();
                frm_QuanLy frm = new frm_QuanLy();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Nhập sai tài khoản và mật khẩu");
                phuongthuoc.lammoi(this);
            }
        }
    }
}

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
    public partial class frm_QuanLy : Form
    {
        public frm_QuanLy()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_Khoa_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_QuanLyKhoa());
        }

        private void btn_Lop_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_QuanLyLop());

        }

        private void btn_GiaoVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_QuanLyGiaoVien());

        }

        private void btn_SinhVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_QuanLySinhVien());

        }
    }
}

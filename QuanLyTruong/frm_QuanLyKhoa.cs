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
    public partial class frm_QuanLyKhoa : Form
    {
        public frm_QuanLyKhoa()
        {
            InitializeComponent();
        }
        public void LoadDataGridView()
        {
            string sql = "Select * from Khoa";
            dtG.DataSource = phuongthuc.LayDLBang(sql);
            dtG.Columns[0].HeaderText = "Mã khoa";
            dtG.Columns[1].HeaderText = "Tên khoa";
            dtG.Columns[2].HeaderText = "Thông tin khoa";
        }

        private void frm_QuanLyKhoa_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        LOPDUNGCHUNG phuongthuc = new LOPDUNGCHUNG();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Khoa values ('" + txt_makhoa.Text + "',N'" + txt_tenkhoa.Text + "',N'" + txt_thongtinkhoa.Text + "')";
            phuongthuc.ThemXoaSua(sql);
            LoadDataGridView();
            phuongthuc.lammoi(this);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update Khoa set TenKhoa = N'" + txt_tenkhoa.Text + "',GhiChu  = N'" + txt_thongtinkhoa.Text + "'" + "where MaKhoa = '" + txt_makhoa.Text + "'";
            phuongthuc.ThemXoaSua(sql);
            LoadDataGridView();
            phuongthuc.lammoi(this);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn thật sự có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                string sql = "Delete Khoa where MaKhoa = '" + txt_makhoa.Text + "'";
                phuongthuc.ThemXoaSua(sql);
                LoadDataGridView();
            }
            phuongthuc.lammoi(this);
        }
        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            phuongthuc.lammoi(this);
        }

        private void dtG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makhoa.Text = dtG.CurrentRow.Cells["MaKhoa"].Value.ToString();
            txt_tenkhoa.Text = dtG.CurrentRow.Cells["TenKhoa"].Value.ToString();
            txt_thongtinkhoa.Text = dtG.CurrentRow.Cells["GhiChu"].Value.ToString();
        }
    }
}

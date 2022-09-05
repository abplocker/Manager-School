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
    public partial class frm_QuanLyLop : Form
    {
        public frm_QuanLyLop()
        {
            InitializeComponent();
        }

        public void LoadDataGridView()
        {
            string sql = "Select * from Lop";
            dtG.DataSource = phuongthuc.LayDLBang(sql);
            dtG.Columns["MaLop"].HeaderText = "Mã lớp";
            dtG.Columns["TenLop"].HeaderText = "Tên lớp";
            dtG.Columns["PhongHoc"].HeaderText = "PhongHoc";
            dtG.Columns["GhiChu"].HeaderText = "Ghi chú";
        }

        private void frm_QuanLyKhoa_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        LOPDUNGCHUNG phuongthuc = new LOPDUNGCHUNG();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_malop.Text) || !string.IsNullOrWhiteSpace(txt_tenlop.Text))
            {
                string sql = "Insert into Lop values ('" + txt_malop.Text + "',N'" + txt_tenlop.Text + "',N'" + txt_phonghoc.Text + "',N'" + txt_ghichu.Text + "')";
                phuongthuc.ThemXoaSua(sql);
                LoadDataGridView();
                phuongthuc.lammoi(this);
            }
            else
                MessageBox.Show("Nhập thiếu dữ liệu mã trường và tên trường");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_malop.Text) || !string.IsNullOrWhiteSpace(txt_tenlop.Text))
            {
                string sql = "Update Lop set TenLop = N'" + txt_tenlop.Text + "',GhiChu  = N'" + txt_ghichu.Text + "'"  + ",PhongHoc = N'" + txt_phonghoc.Text + "' where MaLop = '" + txt_malop.Text + "'";
            phuongthuc.ThemXoaSua(sql);
            LoadDataGridView();
            phuongthuc.lammoi(this);
            }
            else
                MessageBox.Show("Nhập thiếu dữ liệu mã trường và tên trường");
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn thật sự có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                string sql = "Delete Lop where MaLop = '" + txt_malop.Text + "'";
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
            txt_malop.Text = dtG.CurrentRow.Cells["MaLop"].Value.ToString();
            txt_tenlop.Text = dtG.CurrentRow.Cells["TenLop"].Value.ToString();
            txt_ghichu.Text = dtG.CurrentRow.Cells["GhiChu"].Value.ToString();
            txt_phonghoc.Text = dtG.CurrentRow.Cells["PhongHoc"].Value.ToString();
        }
        private void frm_QuanLyLop_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}

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
    public partial class frm_QuanLySinhVien : Form
    {
        public frm_QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void frm_QuanLySinhVien_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadDataGridView();

        }

        public void LoadDataGridView()
        {
            string sql = "Select * from SinhVien";
            dtG.DataSource = phuongthuc.LayDLBang(sql);
            dtG.Columns["MaSinhVien"].HeaderText = "Mã sinh viên";
            dtG.Columns["TenSinhVien"].HeaderText = "Họ và tên";
            dtG.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dtG.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtG.Columns["SDT"].HeaderText = "SDT";
            dtG.Columns["Email"].HeaderText = "Email";
            dtG.Columns["TenKhoa"].HeaderText = "Tên khoa";
            dtG.Columns["TenLop"].HeaderText = "Tên lớp";
            dtG.Columns["MaLop"].Visible = false;
            dtG.Columns["MaKhoa"].Visible = false;
            dtG.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        LOPDUNGCHUNG phuongthuc = new LOPDUNGCHUNG();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_masinhvien.Text) || !string.IsNullOrWhiteSpace(txt_hoten.Text))
            {
                string sql = "Insert into SinhVien values ('" + txt_masinhvien.Text + "',N'" + txt_hoten.Text + "','" + datetime_ngaysinh.Value.ToString("MM/dd/yyyy") + "',N'" + txt_diachi.Text + "','"
                + txt_sodienthoai.Text + "','" + txt_email.Text + "','" + comboBox_khoa.SelectedValue.ToString() + "',N'" + comboBox_khoa.GetItemText(comboBox_khoa.SelectedItem) +"','" 
                + comboBox_Lop.SelectedValue.ToString() + "',N'" + comboBox_Lop.GetItemText(comboBox_Lop.SelectedItem) + "')";
                phuongthuc.ThemXoaSua(sql);
                LoadDataGridView();
                phuongthuc.lammoi(this);
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu mã sinh viên hoặc họ và tên");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_masinhvien.Text) || !string.IsNullOrWhiteSpace(txt_hoten.Text))
            {
                string sql = "Update SinhVien set TenSinhVien = N'" + txt_hoten.Text + "', DiaChi = N'" + txt_diachi.Text + "', NgaySinh = '" + datetime_ngaysinh.Value.ToString("MM/dd/yyyy") + "', SDT ='" + txt_sodienthoai.Text
            + "',Email = N'" + txt_email.Text + "',TenKhoa = N'" + comboBox_khoa.GetItemText(comboBox_khoa.SelectedItem) + "',MaKhoa ='" + comboBox_khoa.SelectedValue.ToString() 
            + "',TenLop = N'" + comboBox_Lop.SelectedValue.ToString() + "',MaLop = '" + comboBox_Lop.SelectedValue.ToString() 
            + "' where MaSinhVien = '" + txt_masinhvien.Text + "'";
                phuongthuc.ThemXoaSua(sql);
                LoadDataGridView();
                phuongthuc.lammoi(this);
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu mã giáo viên hoặc tên giáo viên");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn thật sự có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                string sql = "Delete SinhVien where MaSinhVien = '" + txt_masinhvien.Text + "'";
                phuongthuc.ThemXoaSua(sql);
                LoadDataGridView();
            }
            phuongthuc.lammoi(this);
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            phuongthuc.lammoi(this);
            comboBox_LocDS.ResetText();
            comboBox_LocDS.Text = "------------------Khoa------------------";
            LoadDataGridView();
        }
        public void LoadCombobox()
        {
            // Khoa
            string sqlGrid = "Select * from Khoa";
            comboBox_khoa.DataSource = phuongthuc.LayDLBang(sqlGrid);
            comboBox_khoa.DisplayMember = "TenKhoa";
            comboBox_khoa.ValueMember = "MaKhoa";
            comboBox_LocDS.DataSource = phuongthuc.LayDLBang(sqlGrid);
            comboBox_LocDS.DisplayMember = "TenKhoa";
            comboBox_LocDS.ValueMember = "MaKhoa";
            comboBox_LocDS.Text = "------------------Khoa------------------";
            // Lop
            string sqlLop = "Select * from Lop";
            comboBox_Lop.DataSource = phuongthuc.LayDLBang(sqlLop);
            comboBox_Lop.DisplayMember = "TenLop";
            comboBox_Lop.ValueMember = "MaLop";
            comboBox_LocLop.DataSource = phuongthuc.LayDLBang(sqlLop);
            comboBox_LocLop.DisplayMember = "TenLop";
            comboBox_LocLop.ValueMember = "MaLop";
            comboBox_LocLop.Text = "------------------Lớp------------------";
        }
        private void dtG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masinhvien.Text = dtG.CurrentRow.Cells["MaSinhVien"].Value.ToString();
            txt_hoten.Text = dtG.CurrentRow.Cells["TenSinhVien"].Value.ToString();
            txt_diachi.Text = dtG.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_sodienthoai.Text = dtG.CurrentRow.Cells["SDT"].Value.ToString();
            txt_email.Text = dtG.CurrentRow.Cells["Email"].Value.ToString();
            txt_diachi.Text = dtG.CurrentRow.Cells["DiaChi"].Value.ToString();
            comboBox_khoa.Text = dtG.CurrentRow.Cells["TenKhoa"].Value.ToString();
            datetime_ngaysinh.Value = DateTime.Parse(dtG.CurrentRow.Cells["NgaySinh"].Value.ToString());
            comboBox_Lop.Text = dtG.CurrentRow.Cells["TenLop"].Value.ToString();

        }

        private void comboBox_LocDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_LocDS.SelectedValue.ToString() != "")
            {
                string sqlGrid = "Select * from SinhVien where MaKhoa like N'%" + comboBox_LocDS.SelectedValue.ToString() + "%'";
                dtG.DataSource = phuongthuc.LayDLBang(sqlGrid);
            }
        }

        private void comboBox_LocLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_LocLop.SelectedValue.ToString() != "")
            {
                string sqlGrid = "Select * from SinhVien where MaLop like N'%" + comboBox_LocLop.SelectedValue.ToString() + "%'";
                dtG.DataSource = phuongthuc.LayDLBang(sqlGrid);
            }
        }
    }
}

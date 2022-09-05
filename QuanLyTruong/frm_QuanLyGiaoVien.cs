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
    public partial class frm_QuanLyGiaoVien : Form
    {
        public frm_QuanLyGiaoVien()
        {
            InitializeComponent();
        }
        public void LoadDataGridView()
        {
            string sql = "Select * from GiaoVien";
            dtG.DataSource = phuongthuc.LayDLBang(sql);
            dtG.Columns[0].HeaderText = "Mã giáo viên";
            dtG.Columns[1].HeaderText = "Tên giáo viên";
            dtG.Columns[2].HeaderText = "Ngày sinh";
            dtG.Columns[3].HeaderText = "Địa chỉ";
            dtG.Columns[4].HeaderText = "SDT";
            dtG.Columns[5].HeaderText = "Email";
            dtG.Columns[7].HeaderText = "Tên khoa";
            dtG.Columns["MaKhoa"].Visible = false;
            dtG.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        LOPDUNGCHUNG phuongthuc = new LOPDUNGCHUNG();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_magiaovien.Text) || !string.IsNullOrWhiteSpace(txt_tengiaovien.Text))
            {
                string sql = "Insert into GiaoVien values ('" + txt_magiaovien.Text + "',N'" + txt_tengiaovien.Text + "','" + datetime_ngaysinh.Value.ToString("MM/dd/yyyy") + "',N'" + txt_diachi.Text + "','"
                + txt_sodienthoai.Text + "','" + txt_email.Text + "','" + comboBox_khoa.SelectedValue.ToString() + "',N'" + comboBox_khoa.GetItemText(comboBox_khoa.SelectedItem) + "')";
                phuongthuc.ThemXoaSua(sql);
                LoadDataGridView();
                phuongthuc.lammoi(this);
            }
            else
            {
                MessageBox.Show("Nhập thiếu dữ liệu mã giáo viên hoặc tên giáo viên");
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_magiaovien.Text) || !string.IsNullOrWhiteSpace(txt_tengiaovien.Text))
            {
                string sql = "Update GiaoVien set TenGiaoVien = N'" + txt_tengiaovien.Text + "', DiaChi = N'" + txt_diachi.Text + "', NgaySinh = '" + datetime_ngaysinh.Value.ToString("MM/dd/yyyy") + "', SDT ='" + txt_sodienthoai.Text
            + "',Email = N'" + txt_email.Text + "',TenKhoa = N'" + comboBox_khoa.GetItemText(comboBox_khoa.SelectedItem) + "',MaKhoa ='" + comboBox_khoa.SelectedValue.ToString() + "' where MaGiaoVien = '" + txt_magiaovien.Text + "'";
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
                string sql = "Delete GiaoVien where MaGiaoVien = '" + txt_magiaovien.Text + "'";
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
            string sqlGrid = "Select * from Khoa";
            comboBox_khoa.DataSource = phuongthuc.LayDLBang(sqlGrid);
            comboBox_khoa.DisplayMember = "TenKhoa";
            comboBox_khoa.ValueMember = "MaKhoa";
            comboBox_LocDS.DataSource = phuongthuc.LayDLBang(sqlGrid);
            comboBox_LocDS.DisplayMember = "TenKhoa";
            comboBox_LocDS.ValueMember = "MaKhoa";
            comboBox_LocDS.Text = "------------------Khoa------------------";
        }

        private void frm_QuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            LoadDataGridView();
        }

        private void dtG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_magiaovien.Text = dtG.CurrentRow.Cells["MaGiaoVien"].Value.ToString();
            txt_tengiaovien.Text = dtG.CurrentRow.Cells["TenGiaoVien"].Value.ToString();
            txt_diachi.Text = dtG.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_sodienthoai.Text = dtG.CurrentRow.Cells["SDT"].Value.ToString();
            txt_email.Text = dtG.CurrentRow.Cells["Email"].Value.ToString();
            txt_diachi.Text = dtG.CurrentRow.Cells["DiaChi"].Value.ToString();
            comboBox_khoa.Text = dtG.CurrentRow.Cells["TenKhoa"].Value.ToString();
            datetime_ngaysinh.Value = DateTime.Parse(dtG.CurrentRow.Cells["NgaySinh"].Value.ToString());
        }

        private void comboBox_LocDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_LocDS.SelectedValue.ToString() != "")
            {
                string sqlGrid = "Select * from GiaoVien where MaKhoa like N'%" + comboBox_LocDS.SelectedValue.ToString() + "%'";
                dtG.DataSource = phuongthuc.LayDLBang(sqlGrid);
            }
        }
    }
}

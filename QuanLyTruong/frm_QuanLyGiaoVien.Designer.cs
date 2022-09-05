namespace QuanLyTruong
{
    partial class frm_QuanLyGiaoVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dtG = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_magiaovien = new System.Windows.Forms.TextBox();
            this.txt_tengiaovien = new System.Windows.Forms.TextBox();
            this.comboBox_khoa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datetime_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_sodienthoai = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.comboBox_LocDS = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản lý Giáo viên";
            // 
            // dtG
            // 
            this.dtG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtG.Location = new System.Drawing.Point(12, 432);
            this.dtG.Name = "dtG";
            this.dtG.RowHeadersWidth = 62;
            this.dtG.RowTemplate.Height = 28;
            this.dtG.Size = new System.Drawing.Size(1206, 91);
            this.dtG.TabIndex = 7;
            this.dtG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtG_CellClick);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Khoa";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã giáo viên";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên giáo viên";
            // 
            // btn_Lammoi
            // 
            this.btn_Lammoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lammoi.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Lammoi.Location = new System.Drawing.Point(826, 375);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(136, 38);
            this.btn_Lammoi.TabIndex = 18;
            this.btn_Lammoi.Text = "Làm mới";
            this.btn_Lammoi.UseVisualStyleBackColor = true;
            this.btn_Lammoi.Click += new System.EventHandler(this.btn_Lammoi_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Xoa.Location = new System.Drawing.Point(638, 375);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(136, 38);
            this.btn_Xoa.TabIndex = 17;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Sua.Location = new System.Drawing.Point(440, 375);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(136, 38);
            this.btn_Sua.TabIndex = 16;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Them.Location = new System.Drawing.Point(252, 375);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(136, 38);
            this.btn_Them.TabIndex = 15;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_magiaovien
            // 
            this.txt_magiaovien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_magiaovien.Location = new System.Drawing.Point(213, 105);
            this.txt_magiaovien.Name = "txt_magiaovien";
            this.txt_magiaovien.Size = new System.Drawing.Size(197, 26);
            this.txt_magiaovien.TabIndex = 19;
            // 
            // txt_tengiaovien
            // 
            this.txt_tengiaovien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_tengiaovien.Location = new System.Drawing.Point(213, 166);
            this.txt_tengiaovien.Name = "txt_tengiaovien";
            this.txt_tengiaovien.Size = new System.Drawing.Size(197, 26);
            this.txt_tengiaovien.TabIndex = 20;
            // 
            // comboBox_khoa
            // 
            this.comboBox_khoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_khoa.FormattingEnabled = true;
            this.comboBox_khoa.Location = new System.Drawing.Point(213, 221);
            this.comboBox_khoa.Name = "comboBox_khoa";
            this.comboBox_khoa.Size = new System.Drawing.Size(197, 28);
            this.comboBox_khoa.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(457, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(457, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(457, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(457, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 29);
            this.label8.TabIndex = 25;
            this.label8.Text = "Email";
            // 
            // datetime_ngaysinh
            // 
            this.datetime_ngaysinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datetime_ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.datetime_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime_ngaysinh.Location = new System.Drawing.Point(613, 103);
            this.datetime_ngaysinh.Name = "datetime_ngaysinh";
            this.datetime_ngaysinh.Size = new System.Drawing.Size(263, 26);
            this.datetime_ngaysinh.TabIndex = 26;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_email.Location = new System.Drawing.Point(617, 288);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(259, 26);
            this.txt_email.TabIndex = 27;
            // 
            // txt_sodienthoai
            // 
            this.txt_sodienthoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_sodienthoai.Location = new System.Drawing.Point(617, 235);
            this.txt_sodienthoai.Name = "txt_sodienthoai";
            this.txt_sodienthoai.Size = new System.Drawing.Size(259, 26);
            this.txt_sodienthoai.TabIndex = 28;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_diachi.Location = new System.Drawing.Point(617, 162);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(259, 56);
            this.txt_diachi.TabIndex = 29;
            // 
            // comboBox_LocDS
            // 
            this.comboBox_LocDS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_LocDS.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox_LocDS.FormattingEnabled = true;
            this.comboBox_LocDS.Location = new System.Drawing.Point(12, 378);
            this.comboBox_LocDS.Name = "comboBox_LocDS";
            this.comboBox_LocDS.Size = new System.Drawing.Size(229, 28);
            this.comboBox_LocDS.TabIndex = 31;
            this.comboBox_LocDS.SelectedIndexChanged += new System.EventHandler(this.comboBox_LocDS_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 29);
            this.label9.TabIndex = 32;
            this.label9.Text = "Lọc theo";
            // 
            // frm_QuanLyGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1230, 535);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_LocDS);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_sodienthoai);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.datetime_ngaysinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_khoa);
            this.Controls.Add(this.txt_tengiaovien);
            this.Controls.Add(this.txt_magiaovien);
            this.Controls.Add(this.btn_Lammoi);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtG);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QuanLyGiaoVien";
            this.Text = "frm_QuanLyGiaoVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_QuanLyGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Lammoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_magiaovien;
        private System.Windows.Forms.TextBox txt_tengiaovien;
        private System.Windows.Forms.ComboBox comboBox_khoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datetime_ngaysinh;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_sodienthoai;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.ComboBox comboBox_LocDS;
        private System.Windows.Forms.Label label9;
    }
}
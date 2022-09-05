namespace QuanLyTruong
{
    partial class frm_QuanLyKhoa
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_makhoa = new System.Windows.Forms.TextBox();
            this.txt_tenkhoa = new System.Windows.Forms.TextBox();
            this.txt_thongtinkhoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý Khoa";
            // 
            // dtG
            // 
            this.dtG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtG.Location = new System.Drawing.Point(12, 371);
            this.dtG.Name = "dtG";
            this.dtG.RowHeadersWidth = 62;
            this.dtG.RowTemplate.Height = 28;
            this.dtG.Size = new System.Drawing.Size(874, 152);
            this.dtG.TabIndex = 2;
            this.dtG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtG_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Them.Location = new System.Drawing.Point(109, 289);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(136, 38);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Sua.Location = new System.Drawing.Point(280, 289);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(136, 38);
            this.btn_Sua.TabIndex = 4;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Xoa.Location = new System.Drawing.Point(447, 289);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(136, 38);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Lammoi
            // 
            this.btn_Lammoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lammoi.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Lammoi.Location = new System.Drawing.Point(615, 289);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(136, 38);
            this.btn_Lammoi.TabIndex = 6;
            this.btn_Lammoi.Text = "Làm mới";
            this.btn_Lammoi.UseVisualStyleBackColor = true;
            this.btn_Lammoi.Click += new System.EventHandler(this.btn_Lammoi_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã khoa";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên khoa";
            // 
            // txt_makhoa
            // 
            this.txt_makhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_makhoa.Location = new System.Drawing.Point(27, 135);
            this.txt_makhoa.Name = "txt_makhoa";
            this.txt_makhoa.Size = new System.Drawing.Size(285, 26);
            this.txt_makhoa.TabIndex = 9;
            // 
            // txt_tenkhoa
            // 
            this.txt_tenkhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_tenkhoa.Location = new System.Drawing.Point(27, 225);
            this.txt_tenkhoa.Name = "txt_tenkhoa";
            this.txt_tenkhoa.Size = new System.Drawing.Size(285, 26);
            this.txt_tenkhoa.TabIndex = 10;
            // 
            // txt_thongtinkhoa
            // 
            this.txt_thongtinkhoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_thongtinkhoa.Location = new System.Drawing.Point(473, 130);
            this.txt_thongtinkhoa.Multiline = true;
            this.txt_thongtinkhoa.Name = "txt_thongtinkhoa";
            this.txt_thongtinkhoa.Size = new System.Drawing.Size(413, 121);
            this.txt_thongtinkhoa.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Thông tin khoa";
            // 
            // frm_QuanLyKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(898, 535);
            this.Controls.Add(this.txt_thongtinkhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenkhoa);
            this.Controls.Add(this.txt_makhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Lammoi);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dtG);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QuanLyKhoa";
            this.Text = "frm_QuanLyKhoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_QuanLyKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtG;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Lammoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_makhoa;
        private System.Windows.Forms.TextBox txt_tenkhoa;
        private System.Windows.Forms.TextBox txt_thongtinkhoa;
        private System.Windows.Forms.Label label4;
    }
}
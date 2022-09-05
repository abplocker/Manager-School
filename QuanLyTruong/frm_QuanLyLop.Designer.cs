namespace QuanLyTruong
{
    partial class frm_QuanLyLop
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
            this.txt_phonghoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenlop = new System.Windows.Forms.TextBox();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dtG = new System.Windows.Forms.DataGridView();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(278, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản lý Lớp";
            // 
            // txt_phonghoc
            // 
            this.txt_phonghoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_phonghoc.Location = new System.Drawing.Point(459, 133);
            this.txt_phonghoc.Name = "txt_phonghoc";
            this.txt_phonghoc.Size = new System.Drawing.Size(413, 26);
            this.txt_phonghoc.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Phòng học";
            // 
            // txt_tenlop
            // 
            this.txt_tenlop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_tenlop.Location = new System.Drawing.Point(27, 228);
            this.txt_tenlop.Name = "txt_tenlop";
            this.txt_tenlop.Size = new System.Drawing.Size(285, 26);
            this.txt_tenlop.TabIndex = 21;
            // 
            // txt_malop
            // 
            this.txt_malop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_malop.Location = new System.Drawing.Point(27, 138);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(285, 26);
            this.txt_malop.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên lớp";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã lớp";
            // 
            // btn_Lammoi
            // 
            this.btn_Lammoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lammoi.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Lammoi.Location = new System.Drawing.Point(615, 292);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(136, 38);
            this.btn_Lammoi.TabIndex = 17;
            this.btn_Lammoi.Text = "Làm mới";
            this.btn_Lammoi.UseVisualStyleBackColor = true;
            this.btn_Lammoi.Click += new System.EventHandler(this.btn_Lammoi_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Xoa.Location = new System.Drawing.Point(447, 292);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(136, 38);
            this.btn_Xoa.TabIndex = 16;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Sua.Location = new System.Drawing.Point(280, 292);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(136, 38);
            this.btn_Sua.TabIndex = 15;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_Them.Location = new System.Drawing.Point(109, 292);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(136, 38);
            this.btn_Them.TabIndex = 14;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dtG
            // 
            this.dtG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtG.Location = new System.Drawing.Point(12, 374);
            this.dtG.Name = "dtG";
            this.dtG.RowHeadersWidth = 62;
            this.dtG.RowTemplate.Height = 28;
            this.dtG.Size = new System.Drawing.Size(874, 152);
            this.dtG.TabIndex = 13;
            this.dtG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtG_CellClick);
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ghichu.Location = new System.Drawing.Point(459, 214);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(413, 58);
            this.txt_ghichu.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(454, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ghi chú";
            // 
            // frm_QuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(898, 535);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_phonghoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenlop);
            this.Controls.Add(this.txt_malop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Lammoi);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dtG);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_QuanLyLop";
            this.Text = "frm_QuanLyLop";
            this.Load += new System.EventHandler(this.frm_QuanLyLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_phonghoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenlop;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Lammoi;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dtG;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.Label label5;
    }
}
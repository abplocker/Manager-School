namespace QuanLyTruong
{
    partial class frm_QuanLy
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
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btn_Lop = new System.Windows.Forms.Button();
            this.btn_Khoa = new System.Windows.Forms.Button();
            this.btn_SinhVien = new System.Windows.Forms.Button();
            this.btn_GiaoVien = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.AliceBlue;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(248, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1230, 591);
            this.panelChildForm.TabIndex = 9;
            // 
            // btn_Lop
            // 
            this.btn_Lop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Lop.FlatAppearance.BorderSize = 0;
            this.btn_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lop.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_Lop.Location = new System.Drawing.Point(0, 114);
            this.btn_Lop.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Lop.Name = "btn_Lop";
            this.btn_Lop.Size = new System.Drawing.Size(246, 114);
            this.btn_Lop.TabIndex = 6;
            this.btn_Lop.Text = "Lớp";
            this.btn_Lop.UseVisualStyleBackColor = false;
            this.btn_Lop.Click += new System.EventHandler(this.btn_Lop_Click);
            // 
            // btn_Khoa
            // 
            this.btn_Khoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Khoa.FlatAppearance.BorderSize = 0;
            this.btn_Khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Khoa.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_Khoa.Location = new System.Drawing.Point(0, 0);
            this.btn_Khoa.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Khoa.Name = "btn_Khoa";
            this.btn_Khoa.Size = new System.Drawing.Size(246, 114);
            this.btn_Khoa.TabIndex = 1;
            this.btn_Khoa.Text = "Khoa";
            this.btn_Khoa.UseVisualStyleBackColor = false;
            this.btn_Khoa.Click += new System.EventHandler(this.btn_Khoa_Click);
            // 
            // btn_SinhVien
            // 
            this.btn_SinhVien.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_SinhVien.FlatAppearance.BorderSize = 0;
            this.btn_SinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SinhVien.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_SinhVien.Location = new System.Drawing.Point(0, 342);
            this.btn_SinhVien.Margin = new System.Windows.Forms.Padding(0);
            this.btn_SinhVien.Name = "btn_SinhVien";
            this.btn_SinhVien.Size = new System.Drawing.Size(246, 114);
            this.btn_SinhVien.TabIndex = 7;
            this.btn_SinhVien.Text = "Sinh viên";
            this.btn_SinhVien.UseVisualStyleBackColor = false;
            this.btn_SinhVien.Click += new System.EventHandler(this.btn_SinhVien_Click);
            // 
            // btn_GiaoVien
            // 
            this.btn_GiaoVien.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_GiaoVien.FlatAppearance.BorderSize = 0;
            this.btn_GiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GiaoVien.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btn_GiaoVien.Location = new System.Drawing.Point(0, 228);
            this.btn_GiaoVien.Margin = new System.Windows.Forms.Padding(0);
            this.btn_GiaoVien.Name = "btn_GiaoVien";
            this.btn_GiaoVien.Size = new System.Drawing.Size(246, 114);
            this.btn_GiaoVien.TabIndex = 2;
            this.btn_GiaoVien.Text = "Giáo viên";
            this.btn_GiaoVien.UseVisualStyleBackColor = false;
            this.btn_GiaoVien.Click += new System.EventHandler(this.btn_GiaoVien_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Lop);
            this.panel1.Controls.Add(this.btn_Khoa);
            this.panel1.Controls.Add(this.btn_SinhVien);
            this.panel1.Controls.Add(this.btn_GiaoVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 591);
            this.panel1.TabIndex = 10;
            // 
            // frm_QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1478, 591);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Name = "frm_QuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btn_Lop;
        private System.Windows.Forms.Button btn_Khoa;
        private System.Windows.Forms.Button btn_SinhVien;
        private System.Windows.Forms.Button btn_GiaoVien;
        private System.Windows.Forms.Panel panel1;
    }
}
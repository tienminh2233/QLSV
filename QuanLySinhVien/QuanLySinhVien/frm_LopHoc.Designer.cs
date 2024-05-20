namespace QuanLySinhVien
{
    partial class frm_LopHoc
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
            this.cb_tinchi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.dt_SVDK = new System.Windows.Forms.DataGridView();
            this.lbl_GiaTien = new System.Windows.Forms.Label();
            this.lbl_HangXe = new System.Windows.Forms.Label();
            this.lbl_MaXe = new System.Windows.Forms.Label();
            this.lbl_MaLopHoc = new System.Windows.Forms.Label();
            this.lbl_TenMonHoc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_MaMonHoc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_soluong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_GV = new System.Windows.Forms.Label();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.lbl_TimKiem = new System.Windows.Forms.Label();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.txt_tenMH = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_maMH = new System.Windows.Forms.TextBox();
            this.txt_tenGV = new System.Windows.Forms.TextBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_MaGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_SVDK)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_tinchi
            // 
            this.cb_tinchi.FormattingEnabled = true;
            this.cb_tinchi.Location = new System.Drawing.Point(738, 222);
            this.cb_tinchi.Name = "cb_tinchi";
            this.cb_tinchi.Size = new System.Drawing.Size(70, 28);
            this.cb_tinchi.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(360, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 32);
            this.label3.TabIndex = 79;
            this.label3.Text = "THÔNG TIN LỚP HỌC";
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(1303, 839);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(94, 41);
            this.btn_Dong.TabIndex = 78;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            // 
            // dt_SVDK
            // 
            this.dt_SVDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_SVDK.Location = new System.Drawing.Point(127, 326);
            this.dt_SVDK.Name = "dt_SVDK";
            this.dt_SVDK.RowHeadersWidth = 62;
            this.dt_SVDK.RowTemplate.Height = 28;
            this.dt_SVDK.Size = new System.Drawing.Size(1270, 478);
            this.dt_SVDK.TabIndex = 73;
            this.dt_SVDK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_SVDK_CellContentClick);
            this.dt_SVDK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_LopHoc_CellContentClick);
            // 
            // lbl_GiaTien
            // 
            this.lbl_GiaTien.AutoSize = true;
            this.lbl_GiaTien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaTien.Location = new System.Drawing.Point(633, 227);
            this.lbl_GiaTien.Name = "lbl_GiaTien";
            this.lbl_GiaTien.Size = new System.Drawing.Size(99, 23);
            this.lbl_GiaTien.TabIndex = 70;
            this.lbl_GiaTien.Text = "Số Tín Chỉ";
            // 
            // lbl_HangXe
            // 
            this.lbl_HangXe.AutoSize = true;
            this.lbl_HangXe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HangXe.Location = new System.Drawing.Point(123, 141);
            this.lbl_HangXe.Name = "lbl_HangXe";
            this.lbl_HangXe.Size = new System.Drawing.Size(136, 23);
            this.lbl_HangXe.TabIndex = 69;
            this.lbl_HangXe.Text = "Tên Môn Học :";
            // 
            // lbl_MaXe
            // 
            this.lbl_MaXe.AutoSize = true;
            this.lbl_MaXe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaXe.Location = new System.Drawing.Point(123, 89);
            this.lbl_MaXe.Name = "lbl_MaXe";
            this.lbl_MaXe.Size = new System.Drawing.Size(133, 23);
            this.lbl_MaXe.TabIndex = 68;
            this.lbl_MaXe.Text = "Mã Lớp Học  :";
            // 
            // lbl_MaLopHoc
            // 
            this.lbl_MaLopHoc.AutoSize = true;
            this.lbl_MaLopHoc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaLopHoc.Location = new System.Drawing.Point(258, 90);
            this.lbl_MaLopHoc.Name = "lbl_MaLopHoc";
            this.lbl_MaLopHoc.Size = new System.Drawing.Size(0, 23);
            this.lbl_MaLopHoc.TabIndex = 81;
            // 
            // lbl_TenMonHoc
            // 
            this.lbl_TenMonHoc.AutoSize = true;
            this.lbl_TenMonHoc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenMonHoc.Location = new System.Drawing.Point(265, 141);
            this.lbl_TenMonHoc.Name = "lbl_TenMonHoc";
            this.lbl_TenMonHoc.Size = new System.Drawing.Size(0, 23);
            this.lbl_TenMonHoc.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(768, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(633, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 83;
            this.label4.Text = "Mã Môn Học  :";
            // 
            // lbl_MaMonHoc
            // 
            this.lbl_MaMonHoc.AutoSize = true;
            this.lbl_MaMonHoc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaMonHoc.Location = new System.Drawing.Point(776, 89);
            this.lbl_MaMonHoc.Name = "lbl_MaMonHoc";
            this.lbl_MaMonHoc.Size = new System.Drawing.Size(0, 23);
            this.lbl_MaMonHoc.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 23);
            this.label5.TabIndex = 86;
            this.label5.Text = "Số Lượng       :";
            // 
            // lb_soluong
            // 
            this.lb_soluong.AutoSize = true;
            this.lb_soluong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soluong.Location = new System.Drawing.Point(263, 187);
            this.lb_soluong.Name = "lb_soluong";
            this.lb_soluong.Size = new System.Drawing.Size(0, 23);
            this.lb_soluong.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(633, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 23);
            this.label6.TabIndex = 88;
            this.label6.Text = "Tên Giáo Viên :";
            // 
            // lb_GV
            // 
            this.lb_GV.AutoSize = true;
            this.lb_GV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_GV.Location = new System.Drawing.Point(776, 187);
            this.lb_GV.Name = "lb_GV";
            this.lb_GV.Size = new System.Drawing.Size(0, 23);
            this.lb_GV.TabIndex = 89;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(516, 282);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(92, 38);
            this.btn_timkiem.TabIndex = 92;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // lbl_TimKiem
            // 
            this.lbl_TimKiem.AutoSize = true;
            this.lbl_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimKiem.Location = new System.Drawing.Point(124, 284);
            this.lbl_TimKiem.Name = "lbl_TimKiem";
            this.lbl_TimKiem.Size = new System.Drawing.Size(90, 23);
            this.lbl_TimKiem.TabIndex = 90;
            this.lbl_TimKiem.Text = "Tìm kiếm";
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLop.Location = new System.Drawing.Point(262, 85);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(268, 28);
            this.txt_MaLop.TabIndex = 93;
            // 
            // txt_tenMH
            // 
            this.txt_tenMH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenMH.Location = new System.Drawing.Point(262, 136);
            this.txt_tenMH.Name = "txt_tenMH";
            this.txt_tenMH.Size = new System.Drawing.Size(268, 28);
            this.txt_tenMH.TabIndex = 94;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(262, 187);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(268, 28);
            this.txt_soluong.TabIndex = 95;
            // 
            // txt_maMH
            // 
            this.txt_maMH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maMH.Location = new System.Drawing.Point(782, 88);
            this.txt_maMH.Name = "txt_maMH";
            this.txt_maMH.Size = new System.Drawing.Size(268, 28);
            this.txt_maMH.TabIndex = 96;
            // 
            // txt_tenGV
            // 
            this.txt_tenGV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenGV.Location = new System.Drawing.Point(782, 182);
            this.txt_tenGV.Name = "txt_tenGV";
            this.txt_tenGV.Size = new System.Drawing.Size(268, 28);
            this.txt_tenGV.TabIndex = 97;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(830, 277);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 37);
            this.btn_Sua.TabIndex = 100;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(976, 277);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 37);
            this.btn_Xoa.TabIndex = 99;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(677, 276);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 37);
            this.btn_Them.TabIndex = 98;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_MaGV
            // 
            this.txt_MaGV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaGV.Location = new System.Drawing.Point(782, 136);
            this.txt_MaGV.Name = "txt_MaGV";
            this.txt_MaGV.Size = new System.Drawing.Size(268, 28);
            this.txt_MaGV.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(776, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 102;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(633, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 101;
            this.label7.Text = "Mã Giáo Viên :";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(220, 282);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(268, 28);
            this.txt_timkiem.TabIndex = 104;
            // 
            // frm_LopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 1067);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.txt_MaGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_tenGV);
            this.Controls.Add(this.txt_maMH);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_tenMH);
            this.Controls.Add(this.txt_MaLop);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.lbl_TimKiem);
            this.Controls.Add(this.lb_GV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_soluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_MaMonHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_TenMonHoc);
            this.Controls.Add(this.lbl_MaLopHoc);
            this.Controls.Add(this.cb_tinchi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.dt_SVDK);
            this.Controls.Add(this.lbl_GiaTien);
            this.Controls.Add(this.lbl_HangXe);
            this.Controls.Add(this.lbl_MaXe);
            this.Name = "frm_LopHoc";
            this.Text = "frm_LopHoccs";
            this.Load += new System.EventHandler(this.frm_LopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_SVDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_tinchi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.DataGridView dt_SVDK;
        private System.Windows.Forms.Label lbl_GiaTien;
        private System.Windows.Forms.Label lbl_HangXe;
        private System.Windows.Forms.Label lbl_MaXe;
        private System.Windows.Forms.Label lbl_MaLopHoc;
        private System.Windows.Forms.Label lbl_TenMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_MaMonHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_soluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_GV;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Label lbl_TimKiem;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.TextBox txt_tenMH;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_maMH;
        private System.Windows.Forms.TextBox txt_tenGV;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_MaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_timkiem;
    }
}
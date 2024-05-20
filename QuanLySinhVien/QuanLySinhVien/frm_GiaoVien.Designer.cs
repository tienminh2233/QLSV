namespace QuanLySinhVien
{
    partial class frm_GiaoVien
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
            this.label3 = new System.Windows.Forms.Label();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dt_GV = new System.Windows.Forms.DataGridView();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_QueQuan = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_MaGV = new System.Windows.Forms.TextBox();
            this.lbl_GiaTien = new System.Windows.Forms.Label();
            this.lbl_TenXe = new System.Windows.Forms.Label();
            this.lbl_NgaySX = new System.Windows.Forms.Label();
            this.lbl_HangXe = new System.Windows.Forms.Label();
            this.lbl_MaXe = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(392, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 32);
            this.label3.TabIndex = 76;
            this.label3.Text = "THÔNG TIN GIÁO VIÊN";
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(369, 254);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(54, 24);
            this.rb_nu.TabIndex = 75;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(247, 254);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(67, 24);
            this.rb_nam.TabIndex = 74;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 73;
            this.label1.Text = "Giới Tính";
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(934, 717);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(94, 41);
            this.btn_Dong.TabIndex = 72;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 26);
            this.label4.TabIndex = 71;
            this.label4.Text = "Danh sách Giảng Viên";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(788, 308);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 37);
            this.btn_Sua.TabIndex = 70;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(934, 308);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 37);
            this.btn_Xoa.TabIndex = 69;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(635, 307);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 37);
            this.btn_Them.TabIndex = 68;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dt_GV
            // 
            this.dt_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_GV.Location = new System.Drawing.Point(83, 368);
            this.dt_GV.Name = "dt_GV";
            this.dt_GV.RowHeadersWidth = 62;
            this.dt_GV.RowTemplate.Height = 28;
            this.dt_GV.Size = new System.Drawing.Size(945, 334);
            this.dt_GV.TabIndex = 67;
            this.dt_GV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_GV_CellClick);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(760, 201);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(268, 28);
            this.txt_SDT.TabIndex = 66;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(622, 201);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(128, 23);
            this.lbl_SoLuong.TabIndex = 65;
            this.lbl_SoLuong.Text = "Số Điện Thọai";
            // 
            // dt_NgaySinh
            // 
            this.dt_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgaySinh.Location = new System.Drawing.Point(760, 90);
            this.dt_NgaySinh.Name = "dt_NgaySinh";
            this.dt_NgaySinh.Size = new System.Drawing.Size(268, 26);
            this.dt_NgaySinh.TabIndex = 64;
            this.dt_NgaySinh.Value = new System.DateTime(2024, 3, 9, 20, 13, 0, 0);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(760, 145);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(268, 28);
            this.txt_DiaChi.TabIndex = 63;
            // 
            // txt_QueQuan
            // 
            this.txt_QueQuan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QueQuan.Location = new System.Drawing.Point(217, 197);
            this.txt_QueQuan.Name = "txt_QueQuan";
            this.txt_QueQuan.Size = new System.Drawing.Size(268, 28);
            this.txt_QueQuan.TabIndex = 62;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(217, 144);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(268, 28);
            this.txt_HoTen.TabIndex = 61;
            // 
            // txt_MaGV
            // 
            this.txt_MaGV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaGV.Location = new System.Drawing.Point(217, 92);
            this.txt_MaGV.Name = "txt_MaGV";
            this.txt_MaGV.Size = new System.Drawing.Size(268, 28);
            this.txt_MaGV.TabIndex = 60;
            // 
            // lbl_GiaTien
            // 
            this.lbl_GiaTien.AutoSize = true;
            this.lbl_GiaTien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaTien.Location = new System.Drawing.Point(622, 146);
            this.lbl_GiaTien.Name = "lbl_GiaTien";
            this.lbl_GiaTien.Size = new System.Drawing.Size(73, 23);
            this.lbl_GiaTien.TabIndex = 59;
            this.lbl_GiaTien.Text = "Địa Chỉ";
            // 
            // lbl_TenXe
            // 
            this.lbl_TenXe.AutoSize = true;
            this.lbl_TenXe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenXe.Location = new System.Drawing.Point(79, 198);
            this.lbl_TenXe.Name = "lbl_TenXe";
            this.lbl_TenXe.Size = new System.Drawing.Size(96, 23);
            this.lbl_TenXe.TabIndex = 58;
            this.lbl_TenXe.Text = "Quê Quán";
            // 
            // lbl_NgaySX
            // 
            this.lbl_NgaySX.AutoSize = true;
            this.lbl_NgaySX.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySX.Location = new System.Drawing.Point(622, 92);
            this.lbl_NgaySX.Name = "lbl_NgaySX";
            this.lbl_NgaySX.Size = new System.Drawing.Size(92, 23);
            this.lbl_NgaySX.TabIndex = 57;
            this.lbl_NgaySX.Text = "Ngày sinh";
            // 
            // lbl_HangXe
            // 
            this.lbl_HangXe.AutoSize = true;
            this.lbl_HangXe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HangXe.Location = new System.Drawing.Point(79, 144);
            this.lbl_HangXe.Name = "lbl_HangXe";
            this.lbl_HangXe.Size = new System.Drawing.Size(72, 23);
            this.lbl_HangXe.TabIndex = 56;
            this.lbl_HangXe.Text = "Họ Tên";
            // 
            // lbl_MaXe
            // 
            this.lbl_MaXe.AutoSize = true;
            this.lbl_MaXe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaXe.Location = new System.Drawing.Point(79, 92);
            this.lbl_MaXe.Name = "lbl_MaXe";
            this.lbl_MaXe.Size = new System.Drawing.Size(126, 23);
            this.lbl_MaXe.TabIndex = 55;
            this.lbl_MaXe.Text = "Mã Giáo Viên";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(760, 250);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(268, 28);
            this.txt_email.TabIndex = 78;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(622, 250);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(58, 23);
            this.lb_email.TabIndex = 77;
            this.lb_email.Text = "Email";
            // 
            // frm_GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 782);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_nu);
            this.Controls.Add(this.rb_nam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dt_GV);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.dt_NgaySinh);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_QueQuan);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.txt_MaGV);
            this.Controls.Add(this.lbl_GiaTien);
            this.Controls.Add(this.lbl_TenXe);
            this.Controls.Add(this.lbl_NgaySX);
            this.Controls.Add(this.lbl_HangXe);
            this.Controls.Add(this.lbl_MaXe);
            this.Name = "frm_GiaoVien";
            this.Text = "frm_GiaoVien";
            this.Load += new System.EventHandler(this.frm_GiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dt_GV;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.DateTimePicker dt_NgaySinh;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_QueQuan;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_MaGV;
        private System.Windows.Forms.Label lbl_GiaTien;
        private System.Windows.Forms.Label lbl_TenXe;
        private System.Windows.Forms.Label lbl_NgaySX;
        private System.Windows.Forms.Label lbl_HangXe;
        private System.Windows.Forms.Label lbl_MaXe;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lb_email;
    }
}
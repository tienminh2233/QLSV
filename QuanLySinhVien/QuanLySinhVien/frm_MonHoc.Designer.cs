namespace QuanLySinhVien
{
    partial class frm_MonHoc
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
            this.btn_Dong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dt_MH = new System.Windows.Forms.DataGridView();
            this.txt_monHoc = new System.Windows.Forms.TextBox();
            this.txt_MaMonHoc = new System.Windows.Forms.TextBox();
            this.lbl_GiaTien = new System.Windows.Forms.Label();
            this.lbl_HangXe = new System.Windows.Forms.Label();
            this.lbl_MaXe = new System.Windows.Forms.Label();
            this.cb_tchi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dt_MH)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(366, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 32);
            this.label3.TabIndex = 66;
            this.label3.Text = "THÔNG TIN MÔN HỌC";
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.Location = new System.Drawing.Point(933, 721);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(94, 41);
            this.btn_Dong.TabIndex = 65;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 26);
            this.label1.TabIndex = 64;
            this.label1.Text = "Danh sách Môn Học";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(775, 266);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 37);
            this.btn_Sua.TabIndex = 63;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(921, 266);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 37);
            this.btn_Xoa.TabIndex = 62;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(622, 265);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 37);
            this.btn_Them.TabIndex = 61;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dt_MH
            // 
            this.dt_MH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_MH.Location = new System.Drawing.Point(82, 372);
            this.dt_MH.Name = "dt_MH";
            this.dt_MH.RowHeadersWidth = 62;
            this.dt_MH.RowTemplate.Height = 28;
            this.dt_MH.Size = new System.Drawing.Size(945, 334);
            this.dt_MH.TabIndex = 60;
            this.dt_MH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_MH_CellClick);
            // 
            // txt_monHoc
            // 
            this.txt_monHoc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monHoc.Location = new System.Drawing.Point(229, 185);
            this.txt_monHoc.Name = "txt_monHoc";
            this.txt_monHoc.Size = new System.Drawing.Size(268, 28);
            this.txt_monHoc.TabIndex = 59;
            // 
            // txt_MaMonHoc
            // 
            this.txt_MaMonHoc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaMonHoc.Location = new System.Drawing.Point(229, 133);
            this.txt_MaMonHoc.Name = "txt_MaMonHoc";
            this.txt_MaMonHoc.Size = new System.Drawing.Size(268, 28);
            this.txt_MaMonHoc.TabIndex = 58;
            // 
            // lbl_GiaTien
            // 
            this.lbl_GiaTien.AutoSize = true;
            this.lbl_GiaTien.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaTien.Location = new System.Drawing.Point(628, 134);
            this.lbl_GiaTien.Name = "lbl_GiaTien";
            this.lbl_GiaTien.Size = new System.Drawing.Size(99, 23);
            this.lbl_GiaTien.TabIndex = 57;
            this.lbl_GiaTien.Text = "Số Tín Chỉ";
            // 
            // lbl_HangXe
            // 
            this.lbl_HangXe.AutoSize = true;
            this.lbl_HangXe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HangXe.Location = new System.Drawing.Point(91, 185);
            this.lbl_HangXe.Name = "lbl_HangXe";
            this.lbl_HangXe.Size = new System.Drawing.Size(124, 23);
            this.lbl_HangXe.TabIndex = 56;
            this.lbl_HangXe.Text = "Tên Môn Học";
            // 
            // lbl_MaXe
            // 
            this.lbl_MaXe.AutoSize = true;
            this.lbl_MaXe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaXe.Location = new System.Drawing.Point(91, 133);
            this.lbl_MaXe.Name = "lbl_MaXe";
            this.lbl_MaXe.Size = new System.Drawing.Size(120, 23);
            this.lbl_MaXe.TabIndex = 55;
            this.lbl_MaXe.Text = "Mã Môn Học";
            // 
            // cb_tchi
            // 
            this.cb_tchi.FormattingEnabled = true;
            this.cb_tchi.Location = new System.Drawing.Point(757, 133);
            this.cb_tchi.Name = "cb_tchi";
            this.cb_tchi.Size = new System.Drawing.Size(121, 28);
            this.cb_tchi.TabIndex = 72;
            // 
            // frm_MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 769);
            this.Controls.Add(this.cb_tchi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dt_MH);
            this.Controls.Add(this.txt_monHoc);
            this.Controls.Add(this.txt_MaMonHoc);
            this.Controls.Add(this.lbl_GiaTien);
            this.Controls.Add(this.lbl_HangXe);
            this.Controls.Add(this.lbl_MaXe);
            this.Name = "frm_MonHoc";
            this.Text = "frm_MonHoc";
            this.Load += new System.EventHandler(this.frm_MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_MH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_tinchi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dt_MH;
        private System.Windows.Forms.TextBox txt_monHoc;
        private System.Windows.Forms.TextBox txt_MaMonHoc;
        private System.Windows.Forms.Label lbl_GiaTien;
        private System.Windows.Forms.Label lbl_HangXe;
        private System.Windows.Forms.Label lbl_MaXe;
        private System.Windows.Forms.ComboBox cb_tchi;
    }
}
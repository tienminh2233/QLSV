using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frm_SinhVien : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        public frm_SinhVien()
        {
            InitializeComponent();
        }

        public void LoadSV()
        {
            string sqlLoad = "SELECT * FROM SINHVIEN";
            dt_SV.DataSource = lopchung.LoadDL(sqlLoad);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO SINHVIEN (MASV, HOTEN, QUEQUAN, NGAYSINH, DIACHI, SDT, GMAIL, GIOITINH) " +
                             "VALUES (@MASV, @HOTEN, @QUEQUAN, @NGAYSINH, @DIACHI, @SDT, @GMAIL, @GIOITINH)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MASV", txt_MaSV.Text),
                new SqlParameter("@HOTEN", txt_HoTen.Text),
                new SqlParameter("@QUEQUAN", txt_QueQuan.Text),
                new SqlParameter("@NGAYSINH", DateTime.ParseExact(dt_NgaySinh.Text, "dd/MM/yyyy", null)),
                new SqlParameter("@DIACHI", txt_DiaChi.Text),
                new SqlParameter("@SDT", txt_SDT.Text),
                new SqlParameter("@GMAIL", txt_email.Text),
                new SqlParameter("@GIOITINH", rb_nam.Checked ? 1 : 0)
            };

            int kq = lopchung.ThemXoaSua(sqlThem, parameters);
            if (kq >= 1) MessageBox.Show("Thêm sinh viên thành công");
            else MessageBox.Show("Thêm sinh viên thất bại");
            LoadSV();
        }

        private void dt_SV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSV.Text = dt_SV.CurrentRow.Cells["MASV"].Value.ToString();
            txt_HoTen.Text = dt_SV.CurrentRow.Cells["HOTEN"].Value.ToString();
            txt_QueQuan.Text = dt_SV.CurrentRow.Cells["QUEQUAN"].Value.ToString();
            dt_NgaySinh.Text = dt_SV.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txt_DiaChi.Text = dt_SV.CurrentRow.Cells["DIACHI"].Value.ToString();
            txt_SDT.Text = dt_SV.CurrentRow.Cells["SDT"].Value.ToString();
            txt_email.Text = dt_SV.CurrentRow.Cells["GMAIL"].Value.ToString();

            // Check if GIOITINH is DBNull before converting
            if (dt_SV.CurrentRow.Cells["GIOITINH"].Value != DBNull.Value)
            {
                int gioitinh = Convert.ToInt32(dt_SV.CurrentRow.Cells["GIOITINH"].Value);
                rb_nam.Checked = (gioitinh == 1);
                rb_nu.Checked = (gioitinh == 0);
            }
            else
            {
                // Default values if GIOITINH is DBNull
                rb_nam.Checked = false;
                rb_nu.Checked = false;
            }
        }

        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
            LoadSV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE SINHVIEN SET HOTEN = @HOTEN, QUEQUAN = @QUEQUAN, NGAYSINH = @NGAYSINH, " +
                            "DIACHI = @DIACHI, SDT = @SDT, GMAIL = @GMAIL, GIOITINH = @GIOITINH WHERE MASV = @MASV";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MASV", txt_MaSV.Text),
                new SqlParameter("@HOTEN", txt_HoTen.Text),
                new SqlParameter("@QUEQUAN", txt_QueQuan.Text),
                new SqlParameter("@NGAYSINH", DateTime.ParseExact(dt_NgaySinh.Text, "dd/MM/yyyy", null)),
                new SqlParameter("@DIACHI", txt_DiaChi.Text),
                new SqlParameter("@SDT", txt_SDT.Text),
                new SqlParameter("@GMAIL", txt_email.Text),
                new SqlParameter("@GIOITINH", rb_nam.Checked ? 1 : 0)
            };

            int kq = lopchung.ThemXoaSua(sqlSua, parameters);
            if (kq >= 1) MessageBox.Show("Cập nhật sinh viên thành công");
            else MessageBox.Show("Cập nhật sinh viên thất bại");
            LoadSV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sqlXoa = "DELETE FROM SINHVIEN WHERE MASV = @MASV";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MASV", txt_MaSV.Text)
                };

                int kq = lopchung.ThemXoaSua(sqlXoa, parameters);
                if (kq >= 1) MessageBox.Show("Xóa sinh viên thành công");
                else MessageBox.Show("Xóa sinh viên thất bại");
                LoadSV();
            }
        }
    }
}

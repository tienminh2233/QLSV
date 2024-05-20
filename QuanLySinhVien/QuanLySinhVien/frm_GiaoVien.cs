using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frm_GiaoVien : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        public frm_GiaoVien()
        {
            InitializeComponent();
        }

        public void LoadGV()
        {
            string sqlLoad = "SELECT * FROM GIAOVIEN";
            dt_GV.DataSource = lopchung.LoadDL(sqlLoad);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO GIAOVIEN (MAGV, HOTEN, QUEQUAN, NGAYSINH, DIACHI, SDT, GMAIL, GIOITINH) " +
                             "VALUES (@MAGV, @HOTEN, @QUEQUAN, @NGAYSINH, @DIACHI, @SDT, @GMAIL, @GIOITINH)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MAGV", txt_MaGV.Text),
                new SqlParameter("@HOTEN", txt_HoTen.Text),
                new SqlParameter("@QUEQUAN", txt_QueQuan.Text),
                new SqlParameter("@NGAYSINH", DateTime.ParseExact(dt_NgaySinh.Text, "dd/MM/yyyy", null)),
                new SqlParameter("@DIACHI", txt_DiaChi.Text),
                new SqlParameter("@SDT", txt_SDT.Text),
                new SqlParameter("@GMAIL", txt_email.Text),
                new SqlParameter("@GIOITINH", rb_nam.Checked ? 1 : 0)
            };

            int kq = lopchung.ThemXoaSua(sqlThem, parameters);
            if (kq >= 1) MessageBox.Show("Thêm giáo viên thành công");
            else MessageBox.Show("Thêm giáo viên thất bại");
            LoadGV();
        }

        private void dt_GV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaGV.Text = dt_GV.CurrentRow.Cells["MAGV"].Value.ToString();
            txt_HoTen.Text = dt_GV.CurrentRow.Cells["HOTEN"].Value.ToString();
            txt_QueQuan.Text = dt_GV.CurrentRow.Cells["QUEQUAN"].Value.ToString();
            dt_NgaySinh.Text = dt_GV.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txt_DiaChi.Text = dt_GV.CurrentRow.Cells["DIACHI"].Value.ToString();
            txt_SDT.Text = dt_GV.CurrentRow.Cells["SDT"].Value.ToString();
            txt_email.Text = dt_GV.CurrentRow.Cells["GMAIL"].Value.ToString();

            if (dt_GV.CurrentRow.Cells["GIOITINH"].Value != DBNull.Value)
            {
                int gioitinh = Convert.ToInt32(dt_GV.CurrentRow.Cells["GIOITINH"].Value);
                rb_nam.Checked = (gioitinh == 1);
                rb_nu.Checked = (gioitinh == 0);
            }
            else
            {
                rb_nam.Checked = false;
                rb_nu.Checked = false;
            }
        }

        private void frm_GiaoVien_Load(object sender, EventArgs e)
        {
            LoadGV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE GIAOVIEN SET HOTEN = @HOTEN, QUEQUAN = @QUEQUAN, NGAYSINH = @NGAYSINH, " +
                            "DIACHI = @DIACHI, SDT = @SDT, GMAIL = @GMAIL, GIOITINH = @GIOITINH WHERE MAGV = @MAGV";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MAGV", txt_MaGV.Text),
                new SqlParameter("@HOTEN", txt_HoTen.Text),
                new SqlParameter("@QUEQUAN", txt_QueQuan.Text),
                new SqlParameter("@NGAYSINH", DateTime.ParseExact(dt_NgaySinh.Text, "dd/MM/yyyy", null)),
                new SqlParameter("@DIACHI", txt_DiaChi.Text),
                new SqlParameter("@SDT", txt_SDT.Text),
                new SqlParameter("@GMAIL", txt_email.Text),
                new SqlParameter("@GIOITINH", rb_nam.Checked ? 1 : 0)
            };

            int kq = lopchung.ThemXoaSua(sqlSua, parameters);
            if (kq >= 1) MessageBox.Show("Cập nhật giáo viên thành công");
            else MessageBox.Show("Cập nhật giáo viên thất bại");
            LoadGV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sqlXoa = "DELETE FROM GIAOVIEN WHERE MAGV = @MAGV";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MAGV", txt_MaGV.Text)
                };

                int kq = lopchung.ThemXoaSua(sqlXoa, parameters);
                if (kq >= 1) MessageBox.Show("Xóa giáo viên thành công");
                else MessageBox.Show("Xóa giáo viên thất bại");
                LoadGV();
            }
        }
    }
}

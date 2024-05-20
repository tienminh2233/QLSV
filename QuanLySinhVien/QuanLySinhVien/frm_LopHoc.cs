using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frm_LopHoc : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        public frm_LopHoc()
        {
            InitializeComponent();
        }

        private void frm_LopHoc_Load(object sender, EventArgs e)
        {
            LoadDanhSachLopHoc();
        }

        private void LoadDanhSachLopHoc()
        {
            string sql = "SELECT LOPHOC.MALH, MONHOC.MAMH, MONHOC.TENMONHOC, GIAOVIEN.MAGV, GIAOVIEN.HOTEN, MONHOC.SOTINCHI, COUNT(DANGKYMONHOC.MASV) AS SOLUONGSINHVIEN " +
                         "FROM LOPHOC " +
                         "INNER JOIN MONHOC ON LOPHOC.MAMH = MONHOC.MAMH " +
                         "INNER JOIN GIAOVIEN ON LOPHOC.MAGV = GIAOVIEN.MAGV " +
                         "LEFT JOIN DANGKYMONHOC ON LOPHOC.MALH = DANGKYMONHOC.MALH " +
                         "GROUP BY LOPHOC.MALH, MONHOC.MAMH, MONHOC.TENMONHOC, GIAOVIEN.MAGV, GIAOVIEN.HOTEN, MONHOC.SOTINCHI";

            DataTable dt = lopchung.LoadDL(sql);
            dt_SVDK.DataSource = dt;

            if (!dt_SVDK.Columns.Contains("btnXemChiTiet"))
            {
                DataGridViewButtonColumn btnXemChiTiet = new DataGridViewButtonColumn();
                btnXemChiTiet.Name = "btnXemChiTiet";
                btnXemChiTiet.HeaderText = "Xem Chi Tiết";
                btnXemChiTiet.Text = "Xem Chi Tiết";
                btnXemChiTiet.UseColumnTextForButtonValue = true;
                dt_SVDK.Columns.Add(btnXemChiTiet);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO LOPHOC (MALH, MAMH, MAGV) VALUES (@MALH, @MAMH, @MAGV)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MALH", txt_MaLop.Text),
                new SqlParameter("@MAMH", txt_maMH.Text),
                new SqlParameter("@MAGV", txt_MaGV.Text)
            };

            int kq = lopchung.ThemXoaSua(sqlThem, parameters);
            if (kq >= 1) MessageBox.Show("Thêm lớp học thành công");
            else MessageBox.Show("Thêm lớp học thất bại");
            LoadDanhSachLopHoc();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE LOPHOC SET MAMH = @MAMH, MAGV = @MAGV WHERE MALH = @MALH";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MALH", txt_MaLop.Text),
                new SqlParameter("@MAMH", txt_maMH.Text),
                new SqlParameter("@MAGV", txt_MaGV.Text)
            };

            int kq = lopchung.ThemXoaSua(sqlSua, parameters);
            if (kq >= 1) MessageBox.Show("Cập nhật lớp học thành công");
            else MessageBox.Show("Cập nhật lớp học thất bại");
            LoadDanhSachLopHoc();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sqlXoa = "DELETE FROM LOPHOC WHERE MALH = @MALH";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MALH", txt_MaLop.Text)
                };

                int kq = lopchung.ThemXoaSua(sqlXoa, parameters);
                if (kq >= 1) MessageBox.Show("Xóa lớp học thành công");
                else MessageBox.Show("Xóa lớp học thất bại");
                LoadDanhSachLopHoc();
            }
        }

        private void dt_SVDK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dt_SVDK.Rows[e.RowIndex];
                txt_MaLop.Text = row.Cells["MALH"].Value.ToString();
                txt_maMH.Text = row.Cells["MAMH"].Value.ToString();
                txt_tenMH.Text = row.Cells["TENMONHOC"].Value.ToString();
                txt_MaGV.Text = row.Cells["MAGV"].Value.ToString();
                txt_tenGV.Text = row.Cells["HOTEN"].Value.ToString();
                txt_soluong.Text = row.Cells["SOLUONGSINHVIEN"].Value.ToString();
                cb_tinchi.Text = row.Cells["SOTINCHI"].Value.ToString();
            }
        }

        private void dtg_LopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dt_SVDK.Columns["btnXemChiTiet"].Index && e.RowIndex >= 0)
            {
                string maLop = dt_SVDK.Rows[e.RowIndex].Cells["MALH"].Value.ToString();
                frm_DanhSachDangKy frm = new frm_DanhSachDangKy(maLop);
                frm.ShowDialog();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_timkiem.Text))
            {
                LoadDanhSachLopHoc();
            }
            else
            {
                string sql = "SELECT LOPHOC.MALH, MONHOC.MAMH, MONHOC.TENMONHOC, GIAOVIEN.MAGV, GIAOVIEN.HOTEN, MONHOC.SOTINCHI, COUNT(DANGKYMONHOC.MASV) AS SOLUONGSINHVIEN " +
                             "FROM LOPHOC " +
                             "INNER JOIN MONHOC ON LOPHOC.MAMH = MONHOC.MAMH " +
                             "INNER JOIN GIAOVIEN ON LOPHOC.MAGV = GIAOVIEN.MAGV " +
                             "LEFT JOIN DANGKYMONHOC ON LOPHOC.MALH = DANGKYMONHOC.MALH " +
                             "WHERE LOPHOC.MALH = @MALH " +
                             "GROUP BY LOPHOC.MALH, MONHOC.MAMH, MONHOC.TENMONHOC, GIAOVIEN.MAGV, GIAOVIEN.HOTEN, MONHOC.SOTINCHI";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MALH", txt_timkiem.Text)
                };

                DataTable dt = lopchung.LoadDL(sql, parameters);
                dt_SVDK.DataSource = dt;
            }
        }
    }
}

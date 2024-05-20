using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frm_DangKyTinChi : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        public frm_DangKyTinChi()
        {
            InitializeComponent();
        }

        private void frm_DangKyTinChi_Load(object sender, EventArgs e)
        {
            LoadDanhSachLopHoc();
        }

        private void LoadDanhSachLopHoc()
        {
            string sql = "SELECT LOPHOC.MALH, MONHOC.MAMH, MONHOC.TENMONHOC, GIAOVIEN.HOTEN AS TENGV, GIAOVIEN.MAGV, COUNT(DANGKYMONHOC.MASV) AS SOLUONGSINHVIEN " +
                         "FROM LOPHOC " +
                         "INNER JOIN MONHOC ON LOPHOC.MAMH = MONHOC.MAMH " +
                         "INNER JOIN GIAOVIEN ON LOPHOC.MAGV = GIAOVIEN.MAGV " +
                         "LEFT JOIN DANGKYMONHOC ON LOPHOC.MALH = DANGKYMONHOC.MALH " +
                         "GROUP BY LOPHOC.MALH, MONHOC.MAMH, MONHOC.TENMONHOC, GIAOVIEN.HOTEN, GIAOVIEN.MAGV";

            DataTable dt = lopchung.LoadDL(sql);
            dt_dslh.DataSource = dt;
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maMonHoc =txt_MaMon.Text;

            if (string.IsNullOrEmpty(maMonHoc))
            {
                MessageBox.Show("Vui lòng nhập mã môn học cần tìm kiếm.");
                return;
            }

            string sql = "SELECT LOPHOC.MALH, MONHOC.MAMH, MONHOC.TENMONHOC, GIAOVIEN.HOTEN, COUNT(DANGKYMONHOC.MASV) AS SOLUONGSINHVIEN " +
                         "FROM LOPHOC " +
                         "INNER JOIN MONHOC ON LOPHOC.MAMH = MONHOC.MAMH " +
                         "INNER JOIN GIAOVIEN ON LOPHOC.MAGV = GIAOVIEN.MAGV " +
                         "LEFT JOIN DANGKYMONHOC ON LOPHOC.MALH = DANGKYMONHOC.MALH " +
                         "WHERE MONHOC.MAMH = @MaMonHoc " +
                         "GROUP BY LOPHOC.MALH, MONHOC.MAMH, MONHOC.TENMONHOC, GIAOVIEN.HOTEN";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaMonHoc", maMonHoc)
            };

            DataTable dt = lopchung.LoadDL(sql, parameters);
            dt_dslh.DataSource = dt;
        }



        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string maSinhVien = txt_MaSV.Text;
            string maLopHoc = txt_MaLop.Text;

            if (string.IsNullOrEmpty(maSinhVien))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần đăng ký.");
                return;
            }

            string sqlCheckExist = "SELECT COUNT(*) FROM DANGKYMONHOC WHERE MASV = @MaSinhVien AND MALH = @MaLopHoc";
            List<SqlParameter> parametersCheckExist = new List<SqlParameter>
    {
        new SqlParameter("@MaSinhVien", maSinhVien),
        new SqlParameter("@MaLopHoc", maLopHoc)
    };

            int count = Convert.ToInt32(lopchung.GetData(sqlCheckExist, parametersCheckExist));

            if (count > 0)
            {
                MessageBox.Show("Sinh viên này đã được đăng ký vào lớp học này.");
                return;
            }

            string sqlDangKy = "INSERT INTO DANGKYMONHOC (MALH, MASV) VALUES (@MaLopHoc, @MaSinhVien)";
            List<SqlParameter> parametersDangKy = new List<SqlParameter>
    {
        new SqlParameter("@MaLopHoc", maLopHoc),
        new SqlParameter("@MaSinhVien", maSinhVien)
    };

            int kq = lopchung.ThemXoaSua(sqlDangKy, parametersDangKy);

            if (kq > 0)
            {
                MessageBox.Show("Đăng ký thành công.");
                LoadDanhSachLopHoc();
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công.");
            }
        }


        private void dt_dslh_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dt_dslh.Rows[e.RowIndex];
                txt_MaLop.Text = row.Cells["MALH"].Value.ToString();
                txt_MaMon.Text = row.Cells["MAMH"].Value.ToString();
                txt_MaGV.Text = row.Cells["MAGV"].Value.ToString();
                txt_SoLuong.Text = row.Cells["SOLUONGSINHVIEN"].Value.ToString();

                string maMonHoc = txt_MaMon.Text;
                string sqlFetchMonHoc = "SELECT TENMONHOC FROM MONHOC WHERE MAMH = @MaMonHoc";
                List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@MaMonHoc", maMonHoc)
        };
                object tenMonHoc = lopchung.GetData(sqlFetchMonHoc, parameters);
                if (tenMonHoc != null)
                {
                    txt_TenMon.Text = tenMonHoc.ToString();
                }

                string maGiaoVien = txt_MaGV.Text;
                string sqlFetchGiaoVien = "SELECT HOTEN FROM GIAOVIEN WHERE MAGV = @MaGiaoVien";
                List<SqlParameter> parametersGiaoVien = new List<SqlParameter>
        {
            new SqlParameter("@MaGiaoVien", maGiaoVien)
        };
                object tenGiaoVien = lopchung.GetData(sqlFetchGiaoVien, parametersGiaoVien);
                if (tenGiaoVien != null)
                {
                    txt_tenGV.Text = tenGiaoVien.ToString();
                }
            }
        }

        private string GetGiaoVienName(string maGiaoVien)
        {
            string sqlFetchGiaoVien = "SELECT HOTEN FROM GIAOVIEN WHERE MAGV = @MaGiaoVien";
            List<SqlParameter> parameters = new List<SqlParameter>
    {
        new SqlParameter("@MaGiaoVien", maGiaoVien)
    };
            object tenGiaoVien = lopchung.GetData(sqlFetchGiaoVien, parameters);
            return tenGiaoVien != null ? tenGiaoVien.ToString() : string.Empty;
        }

    }
}

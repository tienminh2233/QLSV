using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frm_DanhSachDangKy : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private string maLop;

        public frm_DanhSachDangKy(string maLop)
        {
            InitializeComponent();
            this.maLop = maLop;
        }

        private void frm_DanhSachDangKy_Load(object sender, EventArgs e)
        {
            LoadThongTinLop();
            LoadDanhSachSinhVien();

            if (!dt_DanhSach.Columns.Contains("HOTEN"))
            {
                DataGridViewTextBoxColumn hoTenColumn = new DataGridViewTextBoxColumn();
                hoTenColumn.Name = "HOTEN";
                hoTenColumn.HeaderText = "Họ Tên";
                hoTenColumn.DataPropertyName = "HOTEN";
                dt_DanhSach.Columns.Add(hoTenColumn);
            }

            if (!dt_DanhSach.Columns.Contains("DIEMCHUYENCAN"))
            {
                DataGridViewTextBoxColumn diemChuyenCanColumn = new DataGridViewTextBoxColumn();
                diemChuyenCanColumn.Name = "DIEMCHUYENCAN";
                diemChuyenCanColumn.HeaderText = "Điểm Chuyên Cần";
                diemChuyenCanColumn.DataPropertyName = "DIEMCHUYENCAN";
                dt_DanhSach.Columns.Add(diemChuyenCanColumn);
            }

            if (!dt_DanhSach.Columns.Contains("DIEMGIUAKY"))
            {
                DataGridViewTextBoxColumn diemGiuaKyColumn = new DataGridViewTextBoxColumn();
                diemGiuaKyColumn.Name = "DIEMGIUAKY";
                diemGiuaKyColumn.HeaderText = "Điểm Giữa Kỳ";
                diemGiuaKyColumn.DataPropertyName = "DIEMGIUAKY";
                dt_DanhSach.Columns.Add(diemGiuaKyColumn);
            }

            if (!dt_DanhSach.Columns.Contains("DIEMCUOIKY"))
            {
                DataGridViewTextBoxColumn diemCuoiKyColumn = new DataGridViewTextBoxColumn();
                diemCuoiKyColumn.Name = "DIEMCUOIKY";
                diemCuoiKyColumn.HeaderText = "Điểm Cuối Kỳ";
                diemCuoiKyColumn.DataPropertyName = "DIEMCUOIKY";
                dt_DanhSach.Columns.Add(diemCuoiKyColumn);
            }

            btn_timkiem.Click += new EventHandler(btn_TimKiem_Click);
        }

        private void LoadThongTinLop()
        {
            string sql = "SELECT LOPHOC.MALH, MONHOC.MAMH, MONHOC.TENMONHOC, COUNT(DANGKYMONHOC.MASV) AS SOLUONGSINHVIEN " +
                         "FROM LOPHOC " +
                         "INNER JOIN MONHOC ON LOPHOC.MAMH = MONHOC.MAMH " +
                         "LEFT JOIN DANGKYMONHOC ON LOPHOC.MALH = DANGKYMONHOC.MALH " +
                         "WHERE LOPHOC.MALH = @MaLop " +
                         "GROUP BY LOPHOC.MALH, MONHOC.MAMH, MONHOC.TENMONHOC";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaLop", maLop)
            };

            DataTable dt = lopchung.LoadDL(sql, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txt_MaLop.Text = row["MALH"].ToString();
                txt_maMH.Text = row["MAMH"].ToString();
                txt_tenMH.Text = row["TENMONHOC"].ToString();
                txt_soluong.Text = row["SOLUONGSINHVIEN"].ToString();
            }
        }

        private void LoadDanhSachSinhVien(string maSinhVien = "")
        {
            string sql = "SELECT DANGKYMONHOC.MALH, DANGKYMONHOC.MASV, SINHVIEN.HOTEN, " +
                         "DIEM.DIEMCHUYENCAN, DIEM.DIEMGIUAKY, DIEM.DIEMCUOIKY " +
                         "FROM DANGKYMONHOC " +
                         "INNER JOIN SINHVIEN ON DANGKYMONHOC.MASV = SINHVIEN.MASV " +
                         "LEFT JOIN DIEM ON DANGKYMONHOC.MASV = DIEM.MASV AND DANGKYMONHOC.MALH = DIEM.MALH " +
                         "WHERE DANGKYMONHOC.MALH = @MaLop";

            if (!string.IsNullOrEmpty(maSinhVien))
            {
                sql += " AND DANGKYMONHOC.MASV = @MaSinhVien";
            }

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MaLop", maLop)
            };

            if (!string.IsNullOrEmpty(maSinhVien))
            {
                parameters.Add(new SqlParameter("@MaSinhVien", maSinhVien));
            }

            DataTable dt = lopchung.LoadDL(sql, parameters);
            dt_DanhSach.DataSource = dt;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string maSinhVien = txt_timkiem.Text.Trim();
            LoadDanhSachSinhVien(maSinhVien);
        }
    }
}

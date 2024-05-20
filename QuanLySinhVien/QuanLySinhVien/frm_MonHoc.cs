using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frm_MonHoc : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        public frm_MonHoc()
        {
            InitializeComponent();
        }

        public void LoadMH()
        {
            string sqlLoad = "SELECT MONHOC.MAMH, MONHOC.TENMONHOC, MONHOC.SOTINCHI " +
                             "FROM MONHOC";
            dt_MH.DataSource = lopchung.LoadDL(sqlLoad);
        }

        private void cb_tchi_DropDown(object sender, EventArgs e)
        {
            cb_tchi.Items.Clear();
            for (int i = 1; i <= 4; i++)
            {
                cb_tchi.Items.Add(i);
            }
        }

        private void frm_MonHoc_Load(object sender, EventArgs e)
        {
            LoadMH();
            cb_tchi.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tchi.DropDown += cb_tchi_DropDown;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO MONHOC (MAMH, TENMONHOC, SOTINCHI) VALUES (@MAMH, @TENMONHOC, @SOTINCHI)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MAMH", txt_MaMonHoc.Text),
                new SqlParameter("@TENMONHOC", txt_monHoc.Text),
                new SqlParameter("@SOTINCHI", cb_tchi.Text)
            };

            int kq = lopchung.ThemXoaSua(sqlThem, parameters);
            if (kq >= 1) MessageBox.Show("Thêm môn học thành công");
            else MessageBox.Show("Thêm môn học thất bại");
            LoadMH();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE MONHOC SET TENMONHOC = @TENMONHOC, SOTINCHI = @SOTINCHI WHERE MAMH = @MAMH";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@MAMH", txt_MaMonHoc.Text),
                new SqlParameter("@TENMONHOC", txt_monHoc.Text),
                new SqlParameter("@SOTINCHI", cb_tchi.Text)
            };

            int kq = lopchung.ThemXoaSua(sqlSua, parameters);
            if (kq >= 1) MessageBox.Show("Cập nhật môn học thành công");
            else MessageBox.Show("Cập nhật môn học thất bại");
            LoadMH();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sqlXoa = "DELETE FROM MONHOC WHERE MAMH = @MAMH";
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MAMH", txt_MaMonHoc.Text)
                };

                int kq = lopchung.ThemXoaSua(sqlXoa, parameters);
                if (kq >= 1) MessageBox.Show("Xóa môn học thành công");
                else MessageBox.Show("Xóa môn học thất bại");
                LoadMH();
            }
        }

        private void dt_MH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dt_MH.Rows[e.RowIndex];
                txt_MaMonHoc.Text = row.Cells["MAMH"].Value.ToString();
                txt_monHoc.Text = row.Cells["TENMONHOC"].Value.ToString();
                cb_tchi.Text = row.Cells["SOTINCHI"].Value.ToString();
            }
        }
    }
}

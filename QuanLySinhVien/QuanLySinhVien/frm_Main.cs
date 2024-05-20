using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) Application.Exit();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            p_Main.Controls.Add(childForm);
            p_Main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Item_QuanLySV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_SinhVien());
        }

        private void Item_QuanLyGV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_GiaoVien());
        }

        private void Item_QuanLyMH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_MonHoc());
        }

        private void Item_QuanLyLH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_LopHoc());

        }

        private void Item_QuanLyKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_DangKyTinChi());
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

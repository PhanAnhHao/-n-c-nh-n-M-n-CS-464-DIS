using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAnVat
{
    public partial class frm_DangNhap : Form
    {
        LOPDUNGCHUNG ldc = new LOPDUNGCHUNG();
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT(*) from ACCOUNT where TaiKhoan = '" + txt_tenTaiKhoan.Text + "' and MatKhau = '" + txt_matKhau.Text + "'";
            int kq = (int)ldc.LayDulieu(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Đăng nhập thành công!");
                frm_MainMenu mainMenu = new frm_MainMenu();
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_nhapLai_Click(object sender, EventArgs e)
        {
            txt_tenTaiKhoan.Clear();
            txt_matKhau.Clear();
        }

        private void chk_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            txt_matKhau.UseSystemPasswordChar = !chk_HienThiMK.Checked;
        }

        private void btn_dangKi_Click(object sender, EventArgs e)
        {
           frm_DangKi dangKi = new frm_DangKi();
           dangKi.Show();
        }

        private void chk_HienThiMK_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_matKhau.UseSystemPasswordChar = !chk_HienThiMK.Checked;
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}

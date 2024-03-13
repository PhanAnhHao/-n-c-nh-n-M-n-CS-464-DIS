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
    public partial class frm_DangKi : Form
    {
        LOPDUNGCHUNG ldc = new LOPDUNGCHUNG();
        public frm_DangKi()
        {
            InitializeComponent();
        }

        private void btn_nhapLai_Click(object sender, EventArgs e)
        {
            txt_tenTaiKhoan.Clear();
            txt_matKhau.Clear();
            txt_matKhauNhaplai.Clear();
        }

        private void chk_hienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hienMK.Checked == true)
            {
                txt_matKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matKhau.UseSystemPasswordChar = true;
            }
        }

        private void btn_dangKy_Click(object sender, EventArgs e)
        {
            string sql = "Insert into ACCOUNT values('" + txt_tenTaiKhoan.Text + "', N'" + txt_matKhau.Text + "')";
            int kq = ldc.ThemXoaSua(sql);
            if (kq >= 1 && txt_matKhau.Text == txt_matKhauNhaplai.Text)
            {
                MessageBox.Show("Đăng kí thành công");
                frm_DangKi dangKi = new frm_DangKi();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng kí thất bại");
            }
        }

        private void chk_hienMKNhapLai_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hienMKNhapLai.Checked == true)
            {
                txt_matKhauNhaplai.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matKhauNhaplai.UseSystemPasswordChar = true;
            }
        }
    }
}

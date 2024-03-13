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
    public partial class frm_ThayDoiMK : Form
    {
        LOPDUNGCHUNG ldc = new LOPDUNGCHUNG();
        public frm_ThayDoiMK()
        {
            InitializeComponent();
        }

        private void btn_thaydoiMK_Click(object sender, EventArgs e)
        {
            string sql = "Update ACCOUNT set MatKhau = N'" + txt_matKhau.Text + "' where TaiKhoan = N'" + txt_tenDangNhap.Text + "'";
            int kq = ldc.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Sửa thành công!");
            }
            else MessageBox.Show("Sửa thất bại");
        }

        private void btn_nhapLai_Click(object sender, EventArgs e)
        {
            txt_tenDangNhap.Clear();
            txt_matKhau.Clear();
            txt_matKhauNhaplai.Clear();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            frm_ThayDoiMK thayDoiMK = new frm_ThayDoiMK();
            this.Close();
        }

        private void chk_hienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hienMatKhau.Checked == true)
            {
                txt_matKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matKhau.UseSystemPasswordChar = true;
            }
        }

        private void chk_hienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hienMK.Checked == true)
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

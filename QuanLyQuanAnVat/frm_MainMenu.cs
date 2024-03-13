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
    public partial class frm_MainMenu : Form
    {
        public frm_MainMenu()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThucAn thucAn = new frm_ThucAn();
            thucAn.MdiParent = this;
            thucAn.Show();
        }

        private void nướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThucUong thucUong = new frm_ThucUong();
            thucUong.MdiParent = this;
            thucUong.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_thoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Oder order = new frm_Oder();
            order.MdiParent = this;
            order.Show();
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThayDoiMK thaydoiMK = new frm_ThayDoiMK();
            thaydoiMK.MdiParent = this;
            thaydoiMK.Show();
        }
    }
}

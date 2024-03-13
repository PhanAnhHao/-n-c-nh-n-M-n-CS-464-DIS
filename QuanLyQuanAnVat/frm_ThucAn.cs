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
    public partial class frm_ThucAn : Form
    {
        LOPDUNGCHUNG ldc = new LOPDUNGCHUNG();

        public frm_ThucAn()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into THUCAN values('" + txt_maThucAn.Text+"', N'"+txt_tenThucAn.Text+"', N'"+txt_gia.Text+"','"+cb_loaiThucAn.Text+"')";
            int kq = ldc.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Thêm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Thêm món ăn thất bại");
            }
            LoadData();
        }

        public void LoadData()
        {
            string sql = "Select * from THUCAN";
            data_thucAn.DataSource = ldc.LoadDuLieu(sql);
        }

        private void frm_ThucAn_Load(object sender, EventArgs e)
        {
            LoadData();
            string sql = "Select * from LOAITHUCAN";
            cb_loaiThucAn.DataSource = ldc.LoadDuLieu(sql);
            cb_loaiThucAn.DisplayMember = "TENLOAITHUCAN";
            cb_loaiThucAn.ValueMember = "MALOAITHUCAN";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from THUCAN where (MATHUCAN = '" + txt_maThucAn.Text + "')";
            int kq = ldc.ThemXoaSua(sql);
            if(kq >= 1)
            {
                MessageBox.Show("Xóa món ăn thành công!");
            }
            else { MessageBox.Show("Xóa món ăn thất bại"); }
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update THUCAN set MATHUCAN = N'"+txt_maThucAn.Text+"', TENTHUCAN =N'"+txt_tenThucAn.Text+"', GIA = N'"+txt_gia.Text+"', LOAITHUCAN = N'"+cb_loaiThucAn.Text+"' where MATHUCAN = N'"+txt_maThucAn.Text+"'";
            int kq = ldc.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Sửa thành công!");
            }
            else MessageBox.Show("Sửa thất bại");
        }

        private void data_thucAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maThucAn.Text = data_thucAn.CurrentRow.Cells["MATHUCAN"].Value.ToString();
            txt_tenThucAn.Text = data_thucAn.CurrentRow.Cells["TENTHUCAN"].Value.ToString();
            txt_gia.Text = data_thucAn.CurrentRow.Cells["GIA"].Value.ToString();
            cb_loaiThucAn.SelectedValue = data_thucAn.CurrentRow.Cells["LOAITHUCAN"].Value.ToString();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            frm_ThucAn thucAn = new frm_ThucAn();
            this.Close();
        }
    }
}

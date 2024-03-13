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
    public partial class frm_ThucUong : Form
    {
       LOPDUNGCHUNG ldc = new LOPDUNGCHUNG();
        public frm_ThucUong()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            string sql = "Select * from THUCUONG";
            data_thucUong.DataSource = ldc.LoadDuLieu(sql);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into THUCUONG values('" + txt_maThucUong.Text + "', N'" + txt_tenThucUong.Text + "', N'" + txt_gia.Text + "','" + cb_loaiThucUong.Text + "')";
            int kq = ldc.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Thêm đồ uống thành công");
            }
            else
            {
                MessageBox.Show("Thêm đồ uống thất bại");
            }
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update THUCUONG set MATHUCUONG = N'" + txt_maThucUong.Text + "', TENTHUCUONG =N'" + txt_tenThucUong.Text + "', GIA = N'" + txt_gia.Text + "', LOAITHUCUONG = N'" + cb_loaiThucUong.Text + "' where MATHUCUONG = N'" + txt_maThucUong.Text + "'";
            int kq = ldc.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Sửa thành công!");
            }
            else MessageBox.Show("Sửa thất bại");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from THUCUONG where (MATHUCUONG = '" + txt_maThucUong.Text + "')";
            int kq = ldc.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Xóa đồ uống thành công!");
            }
            else { MessageBox.Show("Xóa đồng uống thất bại"); }
            LoadData();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            frm_ThucUong thucUong = new frm_ThucUong();
            this.Close();
        }

        private void frm_ThucUong_Load(object sender, EventArgs e)
        {
            LoadData();
            string sql = "Select * from LOAITHUCUONG";
            cb_loaiThucUong.DataSource = ldc.LoadDuLieu(sql);
            cb_loaiThucUong.DisplayMember = "TENLOAITHUCUONG";
            cb_loaiThucUong.ValueMember = "MALOAITHUCUONG";
        }

        private void data_thucUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maThucUong.Text = data_thucUong.CurrentRow.Cells["MATHUCUONG"].Value.ToString();
            txt_tenThucUong.Text = data_thucUong.CurrentRow.Cells["TENTHUCUONG"].Value.ToString();
            txt_gia.Text = data_thucUong.CurrentRow.Cells["GIA"].Value.ToString();
            cb_loaiThucUong.SelectedValue = data_thucUong.CurrentRow.Cells["LOAITHUCUONG"].Value.ToString();
        }

        private void data_thucUong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

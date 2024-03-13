using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanAnVat
{
    public partial class frm_Oder : Form
    {
        LOPDUNGCHUNG ldc = new LOPDUNGCHUNG();
        public frm_Oder()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }    

        private void data_hoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maHoaDon.Text = data_hoaDon.CurrentRow.Cells["MAHOADON"].Value.ToString();
            cb_thucAn.SelectedValue = data_hoaDon.CurrentRow.Cells["THUCAN"].Value.ToString();
            cb_thucUong.SelectedValue = data_hoaDon.CurrentRow.Cells["THUCUONG"].Value.ToString();

        }

        public void LoadData()
        {
            string sql = "Select * from HOADON";
            data_hoaDon.DataSource = ldc.LoadDuLieu(sql);
        }

        private void frm_Oder_Load(object sender, EventArgs e)
        {
            LoadData();
            string thucAn = "Select * from THUCAN";
            cb_thucAn.DataSource = ldc.LoadDuLieu(thucAn);
            cb_thucAn.DisplayMember = "TENTHUCAN";
            cb_thucAn.ValueMember = "MATHUCAN";

            string thucUong = "Select * from THUCUONG";
            cb_thucUong.DataSource = ldc.LoadDuLieu(thucUong);
            cb_thucUong.DisplayMember = "TENTHUCUONG";
            cb_thucUong.ValueMember = "MATHUCUONG";
        }

        private void data_hoaDon_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_maHoaDon.Text = data_hoaDon.CurrentRow.Cells["MAHOADON"].Value.ToString();
            cb_thucAn.SelectedValue = data_hoaDon.CurrentRow.Cells["THUCAN"].Value.ToString();
            cb_thucUong.SelectedValue = data_hoaDon.CurrentRow.Cells["THUCUONG"].Value.ToString();
        }

        private void btn_themThucAn_Click(object sender, EventArgs e)
        {
            string laygia = "Select GIA from THUCAN where MATHUCAN = N'"+cb_thucAn.SelectedValue.ToString()+"' ";
            int giaThucAn = (int)ldc.LayDulieu(laygia);
            txt_giaThucAn.Text = giaThucAn.ToString();
            string sql = "Insert into HOADON values('" + txt_maHoaDon.Text + "', N'" + cb_thucAn.Text + "', N'" + null + "','" + txt_giaThucAn.Text + "')";
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

        private void btn_themThucUong_Click(object sender, EventArgs e)
        {
            string laygia = "Select GIA from THUCUONG where MATHUCUONG = N'" + cb_thucUong.SelectedValue.ToString() + "' ";
            int giaThucUong = (int)ldc.LayDulieu(laygia);
            txt_giaThucUong.Text = giaThucUong.ToString();
            string sql = "Insert into HOADON values('" + txt_maHoaDon.Text + "', N'" + null + "', N'" + cb_thucUong.Text + "','" + txt_giaThucUong.Text + "')";
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

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            string sql = "delete from hoadon";
            int kq = ldc.ThemXoaSua(sql);
            if (kq >= 1)
            {
                DialogResult dr;
                dr = MessageBox.Show("Xác nhận thanh toán", "Thanh toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    txt_maHoaDon.Text = "";
                    cb_thucAn.Text = "";
                    txt_giaThucAn.Text = "";
                    cb_thucUong.Text = "";
                    txt_giaThucUong.Text = "";
                    txt_tongGia.Text = "";
                }
            } else { MessageBox.Show("Không có sản phẩm để thanh toán!"); }
            LoadData() ;
        }

        private void btn_thanhTien_Click(object sender, EventArgs e)
        {
            int giathucan = Convert.ToInt32(txt_giaThucAn.Text);
            int giathucuong = Convert.ToInt32(txt_giaThucUong.Text);
            int tong = giathucan + giathucuong;
            txt_tongGia.Text = tong.ToString();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            frm_Oder order = new frm_Oder();
            this.Close();
        }
    }
}

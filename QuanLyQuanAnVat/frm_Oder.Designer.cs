namespace QuanLyQuanAnVat
{
    partial class frm_Oder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_thucAn = new System.Windows.Forms.ComboBox();
            this.cb_thucUong = new System.Windows.Forms.ComboBox();
            this.data_hoaDon = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maHoaDon = new System.Windows.Forms.TextBox();
            this.btn_themThucAn = new System.Windows.Forms.Button();
            this.btn_themThucUong = new System.Windows.Forms.Button();
            this.txt_tongGia = new System.Windows.Forms.TextBox();
            this.btn_thanhToan = new System.Windows.Forms.Button();
            this.txt_giaThucAn = new System.Windows.Forms.TextBox();
            this.txt_giaThucUong = new System.Windows.Forms.TextBox();
            this.btn_thanhTien = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_hoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Món ăn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thức uống:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng giá:";
            // 
            // cb_thucAn
            // 
            this.cb_thucAn.BackColor = System.Drawing.Color.Linen;
            this.cb_thucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_thucAn.FormattingEnabled = true;
            this.cb_thucAn.Location = new System.Drawing.Point(186, 171);
            this.cb_thucAn.Name = "cb_thucAn";
            this.cb_thucAn.Size = new System.Drawing.Size(254, 28);
            this.cb_thucAn.TabIndex = 6;
            // 
            // cb_thucUong
            // 
            this.cb_thucUong.BackColor = System.Drawing.Color.Linen;
            this.cb_thucUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_thucUong.FormattingEnabled = true;
            this.cb_thucUong.Location = new System.Drawing.Point(186, 245);
            this.cb_thucUong.Name = "cb_thucUong";
            this.cb_thucUong.Size = new System.Drawing.Size(254, 28);
            this.cb_thucUong.TabIndex = 7;
            // 
            // data_hoaDon
            // 
            this.data_hoaDon.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.data_hoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_hoaDon.Location = new System.Drawing.Point(70, 351);
            this.data_hoaDon.Name = "data_hoaDon";
            this.data_hoaDon.RowHeadersWidth = 51;
            this.data_hoaDon.RowTemplate.Height = 24;
            this.data_hoaDon.Size = new System.Drawing.Size(618, 150);
            this.data_hoaDon.TabIndex = 8;
            this.data_hoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_hoaDon_CellClick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thanh Toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã hóa đơn:";
            // 
            // txt_maHoaDon
            // 
            this.txt_maHoaDon.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_maHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maHoaDon.Location = new System.Drawing.Point(188, 118);
            this.txt_maHoaDon.Name = "txt_maHoaDon";
            this.txt_maHoaDon.Size = new System.Drawing.Size(254, 30);
            this.txt_maHoaDon.TabIndex = 11;
            // 
            // btn_themThucAn
            // 
            this.btn_themThucAn.BackColor = System.Drawing.Color.Linen;
            this.btn_themThucAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themThucAn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_themThucAn.Location = new System.Drawing.Point(468, 171);
            this.btn_themThucAn.Name = "btn_themThucAn";
            this.btn_themThucAn.Size = new System.Drawing.Size(89, 32);
            this.btn_themThucAn.TabIndex = 12;
            this.btn_themThucAn.Text = "Thêm";
            this.btn_themThucAn.UseVisualStyleBackColor = false;
            this.btn_themThucAn.Click += new System.EventHandler(this.btn_themThucAn_Click);
            // 
            // btn_themThucUong
            // 
            this.btn_themThucUong.BackColor = System.Drawing.Color.Linen;
            this.btn_themThucUong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themThucUong.Location = new System.Drawing.Point(468, 245);
            this.btn_themThucUong.Name = "btn_themThucUong";
            this.btn_themThucUong.Size = new System.Drawing.Size(89, 32);
            this.btn_themThucUong.TabIndex = 13;
            this.btn_themThucUong.Text = "Thêm";
            this.btn_themThucUong.UseVisualStyleBackColor = false;
            this.btn_themThucUong.Click += new System.EventHandler(this.btn_themThucUong_Click);
            // 
            // txt_tongGia
            // 
            this.txt_tongGia.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_tongGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongGia.Location = new System.Drawing.Point(611, 289);
            this.txt_tongGia.Multiline = true;
            this.txt_tongGia.Name = "txt_tongGia";
            this.txt_tongGia.Size = new System.Drawing.Size(126, 39);
            this.txt_tongGia.TabIndex = 18;
            // 
            // btn_thanhToan
            // 
            this.btn_thanhToan.BackColor = System.Drawing.Color.Linen;
            this.btn_thanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhToan.Location = new System.Drawing.Point(588, 98);
            this.btn_thanhToan.Name = "btn_thanhToan";
            this.btn_thanhToan.Size = new System.Drawing.Size(123, 32);
            this.btn_thanhToan.TabIndex = 19;
            this.btn_thanhToan.Text = "Thanh toán";
            this.btn_thanhToan.UseVisualStyleBackColor = false;
            this.btn_thanhToan.Click += new System.EventHandler(this.btn_thanhToan_Click);
            // 
            // txt_giaThucAn
            // 
            this.txt_giaThucAn.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_giaThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaThucAn.Location = new System.Drawing.Point(588, 178);
            this.txt_giaThucAn.Name = "txt_giaThucAn";
            this.txt_giaThucAn.Size = new System.Drawing.Size(149, 27);
            this.txt_giaThucAn.TabIndex = 20;
            // 
            // txt_giaThucUong
            // 
            this.txt_giaThucUong.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_giaThucUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaThucUong.Location = new System.Drawing.Point(588, 255);
            this.txt_giaThucUong.Name = "txt_giaThucUong";
            this.txt_giaThucUong.Size = new System.Drawing.Size(149, 27);
            this.txt_giaThucUong.TabIndex = 21;
            // 
            // btn_thanhTien
            // 
            this.btn_thanhTien.BackColor = System.Drawing.Color.Linen;
            this.btn_thanhTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhTien.Location = new System.Drawing.Point(386, 300);
            this.btn_thanhTien.Name = "btn_thanhTien";
            this.btn_thanhTien.Size = new System.Drawing.Size(123, 32);
            this.btn_thanhTien.TabIndex = 22;
            this.btn_thanhTien.Text = "Thành tiền";
            this.btn_thanhTien.UseVisualStyleBackColor = false;
            this.btn_thanhTien.Click += new System.EventHandler(this.btn_thanhTien_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(679, 525);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(109, 53);
            this.btn_thoat.TabIndex = 23;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_Oder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_thanhTien);
            this.Controls.Add(this.txt_giaThucUong);
            this.Controls.Add(this.txt_giaThucAn);
            this.Controls.Add(this.btn_thanhToan);
            this.Controls.Add(this.txt_tongGia);
            this.Controls.Add(this.btn_themThucUong);
            this.Controls.Add(this.btn_themThucAn);
            this.Controls.Add(this.txt_maHoaDon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data_hoaDon);
            this.Controls.Add(this.cb_thucUong);
            this.Controls.Add(this.cb_thucAn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Oder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Oder";
            this.Load += new System.EventHandler(this.frm_Oder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_hoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_thucAn;
        private System.Windows.Forms.ComboBox cb_thucUong;
        private System.Windows.Forms.DataGridView data_hoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_maHoaDon;
        private System.Windows.Forms.Button btn_themThucAn;
        private System.Windows.Forms.Button btn_themThucUong;
        private System.Windows.Forms.TextBox txt_tongGia;
        private System.Windows.Forms.Button btn_thanhToan;
        private System.Windows.Forms.TextBox txt_giaThucAn;
        private System.Windows.Forms.TextBox txt_giaThucUong;
        private System.Windows.Forms.Button btn_thanhTien;
        private System.Windows.Forms.Button btn_thoat;
    }
}
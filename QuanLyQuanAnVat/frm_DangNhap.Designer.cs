namespace QuanLyQuanAnVat
{
    partial class frm_DangNhap
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
            this.txt_tenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.btn_dangKi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_nhapLai = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.chk_HienThiMK = new System.Windows.Forms.CheckBox();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txt_tenTaiKhoan
            // 
            this.txt_tenTaiKhoan.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_tenTaiKhoan.Location = new System.Drawing.Point(312, 148);
            this.txt_tenTaiKhoan.Multiline = true;
            this.txt_tenTaiKhoan.Name = "txt_tenTaiKhoan";
            this.txt_tenTaiKhoan.Size = new System.Drawing.Size(261, 25);
            this.txt_tenTaiKhoan.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đăng nhập";
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.BackColor = System.Drawing.Color.Linen;
            this.btn_dangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangNhap.Location = new System.Drawing.Point(491, 295);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(139, 44);
            this.btn_dangNhap.TabIndex = 5;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = false;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // btn_dangKi
            // 
            this.btn_dangKi.BackColor = System.Drawing.Color.Linen;
            this.btn_dangKi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangKi.Location = new System.Drawing.Point(250, 389);
            this.btn_dangKi.Name = "btn_dangKi";
            this.btn_dangKi.Size = new System.Drawing.Size(130, 33);
            this.btn_dangKi.TabIndex = 6;
            this.btn_dangKi.Text = "Đăng kí";
            this.btn_dangKi.UseVisualStyleBackColor = false;
            this.btn_dangKi.Click += new System.EventHandler(this.btn_dangKi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chưa có tài khoản? Đăng kí ngay";
            // 
            // btn_nhapLai
            // 
            this.btn_nhapLai.BackColor = System.Drawing.Color.Linen;
            this.btn_nhapLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhapLai.Location = new System.Drawing.Point(193, 295);
            this.btn_nhapLai.Name = "btn_nhapLai";
            this.btn_nhapLai.Size = new System.Drawing.Size(137, 44);
            this.btn_nhapLai.TabIndex = 8;
            this.btn_nhapLai.Text = "Nhập lại";
            this.btn_nhapLai.UseVisualStyleBackColor = false;
            this.btn_nhapLai.Click += new System.EventHandler(this.btn_nhapLai_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Linen;
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(647, 389);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(126, 33);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // chk_HienThiMK
            // 
            this.chk_HienThiMK.AutoSize = true;
            this.chk_HienThiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_HienThiMK.Location = new System.Drawing.Point(592, 243);
            this.chk_HienThiMK.Name = "chk_HienThiMK";
            this.chk_HienThiMK.Size = new System.Drawing.Size(162, 24);
            this.chk_HienThiMK.TabIndex = 12;
            this.chk_HienThiMK.Text = "Hiển thị mật khẩu";
            this.chk_HienThiMK.UseVisualStyleBackColor = true;
            this.chk_HienThiMK.CheckedChanged += new System.EventHandler(this.chk_HienThiMK_CheckedChanged_1);
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.BackColor = System.Drawing.Color.PeachPuff;
            this.txt_matKhau.Location = new System.Drawing.Point(312, 239);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(261, 22);
            this.txt_matKhau.TabIndex = 13;
            this.txt_matKhau.UseSystemPasswordChar = true;
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_matKhau);
            this.Controls.Add(this.chk_HienThiMK);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_nhapLai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_dangKi);
            this.Controls.Add(this.btn_dangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tenTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.Button btn_dangKi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_nhapLai;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.CheckBox chk_HienThiMK;
        private System.Windows.Forms.TextBox txt_matKhau;
    }
}
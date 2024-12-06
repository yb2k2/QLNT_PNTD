namespace QLNT
{
    partial class ThongTinTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinTaiKhoan));
            this.pic_hinhanh = new DevExpress.XtraEditors.PictureEdit();
            this.txt_hoten = new DevExpress.XtraEditors.TextEdit();
            this.txt_password = new DevExpress.XtraEditors.TextEdit();
            this.txt_username = new DevExpress.XtraEditors.TextEdit();
            this.txt_ngaysinh = new DevExpress.XtraEditors.DateEdit();
            this.txt_diachi = new DevExpress.XtraEditors.MemoEdit();
            this.txt_gioitinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hinhanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hoten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ngaysinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ngaysinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gioitinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_hinhanh
            // 
            this.pic_hinhanh.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_hinhanh.Location = new System.Drawing.Point(29, 35);
            this.pic_hinhanh.Name = "pic_hinhanh";
            this.pic_hinhanh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_hinhanh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pic_hinhanh.Properties.ZoomAccelerationFactor = 1D;
            this.pic_hinhanh.Size = new System.Drawing.Size(282, 323);
            this.pic_hinhanh.TabIndex = 0;
            this.pic_hinhanh.DoubleClick += new System.EventHandler(this.pic_hinhanh_DoubleClick);
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(338, 126);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoten.Properties.Appearance.Options.UseFont = true;
            this.txt_hoten.Size = new System.Drawing.Size(175, 26);
            this.txt_hoten.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(584, 58);
            this.txt_password.Name = "txt_password";
            this.txt_password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Properties.Appearance.Options.UseFont = true;
            this.txt_password.Properties.UseSystemPasswordChar = true;
            this.txt_password.Size = new System.Drawing.Size(170, 26);
            this.txt_password.TabIndex = 2;
            this.txt_password.Validating += new System.ComponentModel.CancelEventHandler(this.txt_password_Validating);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(338, 58);
            this.txt_username.Name = "txt_username";
            this.txt_username.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Properties.Appearance.Options.UseFont = true;
            this.txt_username.Properties.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(175, 26);
            this.txt_username.TabIndex = 3;
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.EditValue = null;
            this.txt_ngaysinh.Location = new System.Drawing.Point(584, 126);
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaysinh.Properties.Appearance.Options.UseFont = true;
            this.txt_ngaysinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_ngaysinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_ngaysinh.Size = new System.Drawing.Size(175, 26);
            this.txt_ngaysinh.TabIndex = 4;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(338, 262);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(416, 96);
            this.txt_diachi.TabIndex = 5;
            // 
            // txt_gioitinh
            // 
            this.txt_gioitinh.Location = new System.Drawing.Point(338, 194);
            this.txt_gioitinh.Name = "txt_gioitinh";
            this.txt_gioitinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gioitinh.Properties.Appearance.Options.UseFont = true;
            this.txt_gioitinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_gioitinh.Size = new System.Drawing.Size(175, 26);
            this.txt_gioitinh.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Họ Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Username";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(712, 474);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(631, 474);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 18;
            this.simpleButton4.Text = "Lưu";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // ThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 509);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_gioitinh);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_ngaysinh);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.pic_hinhanh);
            this.Name = "ThongTinTaiKhoan";
            this.Text = "Thông Tin Tài Khoản";
            this.Load += new System.EventHandler(this.ThongTinTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_hinhanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hoten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ngaysinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ngaysinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gioitinh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pic_hinhanh;
        private DevExpress.XtraEditors.TextEdit txt_hoten;
        private DevExpress.XtraEditors.TextEdit txt_password;
        private DevExpress.XtraEditors.TextEdit txt_username;
        private DevExpress.XtraEditors.DateEdit txt_ngaysinh;
        private DevExpress.XtraEditors.MemoEdit txt_diachi;
        private DevExpress.XtraEditors.ComboBoxEdit txt_gioitinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}
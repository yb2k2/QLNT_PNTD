namespace QLNT
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_TenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.txt_MatKhau = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_HienThiMatKhau = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.buttonCirculer1 = new QLNT.ButtonCirculer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_HienThiMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.EditValue = "duy";
            this.txt_TenDangNhap.Location = new System.Drawing.Point(43, 150);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.txt_TenDangNhap.Properties.AutoHeight = false;
            this.txt_TenDangNhap.Size = new System.Drawing.Size(273, 30);
            this.txt_TenDangNhap.TabIndex = 0;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.EditValue = "admin";
            this.txt_MatKhau.Location = new System.Drawing.Point(43, 210);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Properties.Appearance.Options.UseFont = true;
            this.txt_MatKhau.Properties.AutoHeight = false;
            this.txt_MatKhau.Properties.UseSystemPasswordChar = true;
            this.txt_MatKhau.Size = new System.Drawing.Size(273, 30);
            this.txt_MatKhau.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(43, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đăng Nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_HienThiMatKhau
            // 
            this.cb_HienThiMatKhau.Location = new System.Drawing.Point(43, 265);
            this.cb_HienThiMatKhau.Name = "cb_HienThiMatKhau";
            this.cb_HienThiMatKhau.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.cb_HienThiMatKhau.Properties.Appearance.Options.UseForeColor = true;
            this.cb_HienThiMatKhau.Properties.Caption = "Hiển Thị Mật Khẩu";
            this.cb_HienThiMatKhau.Size = new System.Drawing.Size(119, 19);
            this.cb_HienThiMatKhau.TabIndex = 3;
            this.cb_HienThiMatKhau.CheckedChanged += new System.EventHandler(this.cb_HienThiMatKhau_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(43, 185);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 19);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mật Khẩu";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(43, 125);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 19);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Tên Đăng Nhập";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(58, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(236, 116);
            this.pictureEdit1.TabIndex = 7;
            // 
            // buttonCirculer1
            // 
            this.buttonCirculer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCirculer1.BackgroundImage")));
            this.buttonCirculer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCirculer1.FlatAppearance.BorderSize = 0;
            this.buttonCirculer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCirculer1.Location = new System.Drawing.Point(317, 3);
            this.buttonCirculer1.Name = "buttonCirculer1";
            this.buttonCirculer1.Size = new System.Drawing.Size(32, 30);
            this.buttonCirculer1.TabIndex = 6;
            this.buttonCirculer1.UseVisualStyleBackColor = true;
            this.buttonCirculer1.Click += new System.EventHandler(this.buttonCirculer1_Click);
            // 
            // Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 371);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.buttonCirculer1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cb_HienThiMatKhau);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TenDangNhap);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_HienThiMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_TenDangNhap;
        private DevExpress.XtraEditors.TextEdit txt_MatKhau;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.CheckEdit cb_HienThiMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private ButtonCirculer buttonCirculer1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
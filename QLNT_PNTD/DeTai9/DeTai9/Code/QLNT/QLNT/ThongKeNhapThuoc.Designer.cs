namespace QLNT
{
    partial class ThongKeNhapThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeNhapThuoc));
            this.grd_thongkenhapthuoc = new DevExpress.XtraGrid.GridControl();
            this.gv_thongkenhapthuoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_manhaphang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_TenThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_hamluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_hangsx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_donvinhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_giatriquydoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_soluongnhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_gianhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_mota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_ngaynhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_thanhtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_thongkenhapthuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_thongkenhapthuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_thongkenhapthuoc
            // 
            this.grd_thongkenhapthuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_thongkenhapthuoc.Location = new System.Drawing.Point(0, 0);
            this.grd_thongkenhapthuoc.MainView = this.gv_thongkenhapthuoc;
            this.grd_thongkenhapthuoc.Name = "grd_thongkenhapthuoc";
            this.grd_thongkenhapthuoc.Size = new System.Drawing.Size(917, 470);
            this.grd_thongkenhapthuoc.TabIndex = 0;
            this.grd_thongkenhapthuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_thongkenhapthuoc});
            // 
            // gv_thongkenhapthuoc
            // 
            this.gv_thongkenhapthuoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_manhaphang,
            this.gc_TenThuoc,
            this.gc_hamluong,
            this.gc_hangsx,
            this.gc_donvinhap,
            this.gc_giatriquydoi,
            this.gc_soluongnhap,
            this.gc_gianhap,
            this.gc_mota,
            this.gc_ngaynhap,
            this.gc_username,
            this.gc_thanhtien});
            this.gv_thongkenhapthuoc.GridControl = this.grd_thongkenhapthuoc;
            this.gv_thongkenhapthuoc.Name = "gv_thongkenhapthuoc";
            this.gv_thongkenhapthuoc.OptionsView.ShowFooter = true;
            this.gv_thongkenhapthuoc.OptionsView.ShowGroupPanel = false;
            // 
            // gc_manhaphang
            // 
            this.gc_manhaphang.Caption = "Mã Nhập Hàng";
            this.gc_manhaphang.FieldName = "manhaphang";
            this.gc_manhaphang.Name = "gc_manhaphang";
            this.gc_manhaphang.Visible = true;
            this.gc_manhaphang.VisibleIndex = 0;
            // 
            // gc_TenThuoc
            // 
            this.gc_TenThuoc.Caption = "Tên Thuốc";
            this.gc_TenThuoc.FieldName = "tenthuoc";
            this.gc_TenThuoc.Name = "gc_TenThuoc";
            this.gc_TenThuoc.Visible = true;
            this.gc_TenThuoc.VisibleIndex = 1;
            // 
            // gc_hamluong
            // 
            this.gc_hamluong.Caption = "Hàm Lượng";
            this.gc_hamluong.FieldName = "hamluong";
            this.gc_hamluong.Name = "gc_hamluong";
            this.gc_hamluong.Visible = true;
            this.gc_hamluong.VisibleIndex = 10;
            // 
            // gc_hangsx
            // 
            this.gc_hangsx.Caption = "Hãng Sản Xuất";
            this.gc_hangsx.FieldName = "hangsx";
            this.gc_hangsx.Name = "gc_hangsx";
            this.gc_hangsx.Visible = true;
            this.gc_hangsx.VisibleIndex = 11;
            // 
            // gc_donvinhap
            // 
            this.gc_donvinhap.Caption = "Đơn Vị Nhập";
            this.gc_donvinhap.FieldName = "donvinhap";
            this.gc_donvinhap.Name = "gc_donvinhap";
            this.gc_donvinhap.Visible = true;
            this.gc_donvinhap.VisibleIndex = 2;
            // 
            // gc_giatriquydoi
            // 
            this.gc_giatriquydoi.Caption = "Giá Trị Quy Đổi";
            this.gc_giatriquydoi.FieldName = "giatriquydoi";
            this.gc_giatriquydoi.Name = "gc_giatriquydoi";
            this.gc_giatriquydoi.Visible = true;
            this.gc_giatriquydoi.VisibleIndex = 3;
            // 
            // gc_soluongnhap
            // 
            this.gc_soluongnhap.Caption = "Số Lượng Nhập";
            this.gc_soluongnhap.FieldName = "soluongnhap";
            this.gc_soluongnhap.Name = "gc_soluongnhap";
            this.gc_soluongnhap.Visible = true;
            this.gc_soluongnhap.VisibleIndex = 4;
            // 
            // gc_gianhap
            // 
            this.gc_gianhap.Caption = "Giá Nhập";
            this.gc_gianhap.FieldName = "gianhap";
            this.gc_gianhap.Name = "gc_gianhap";
            this.gc_gianhap.Visible = true;
            this.gc_gianhap.VisibleIndex = 5;
            // 
            // gc_mota
            // 
            this.gc_mota.Caption = "Mô Tả";
            this.gc_mota.FieldName = "mota";
            this.gc_mota.Name = "gc_mota";
            this.gc_mota.Visible = true;
            this.gc_mota.VisibleIndex = 6;
            // 
            // gc_ngaynhap
            // 
            this.gc_ngaynhap.Caption = "Ngày Nhập";
            this.gc_ngaynhap.FieldName = "ngaynhap";
            this.gc_ngaynhap.Name = "gc_ngaynhap";
            this.gc_ngaynhap.Visible = true;
            this.gc_ngaynhap.VisibleIndex = 7;
            // 
            // gc_username
            // 
            this.gc_username.Caption = "Username";
            this.gc_username.FieldName = "username";
            this.gc_username.Name = "gc_username";
            this.gc_username.Visible = true;
            this.gc_username.VisibleIndex = 9;
            // 
            // gc_thanhtien
            // 
            this.gc_thanhtien.Caption = "Thành Tiền";
            this.gc_thanhtien.FieldName = "thanhtien";
            this.gc_thanhtien.Name = "gc_thanhtien";
            this.gc_thanhtien.Visible = true;
            this.gc_thanhtien.VisibleIndex = 8;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(749, 489);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 14;
            this.simpleButton2.Text = "Lưu";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(830, 489);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ThongKeNhapThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 524);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.grd_thongkenhapthuoc);
            this.Name = "ThongKeNhapThuoc";
            this.Text = "Thống Kê Nhập Thuốc";
            this.Load += new System.EventHandler(this.ThongKeNhapThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_thongkenhapthuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_thongkenhapthuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_thongkenhapthuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_thongkenhapthuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gc_manhaphang;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TenThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gc_hamluong;
        private DevExpress.XtraGrid.Columns.GridColumn gc_hangsx;
        private DevExpress.XtraGrid.Columns.GridColumn gc_donvinhap;
        private DevExpress.XtraGrid.Columns.GridColumn gc_giatriquydoi;
        private DevExpress.XtraGrid.Columns.GridColumn gc_soluongnhap;
        private DevExpress.XtraGrid.Columns.GridColumn gc_gianhap;
        private DevExpress.XtraGrid.Columns.GridColumn gc_mota;
        private DevExpress.XtraGrid.Columns.GridColumn gc_ngaynhap;
        private DevExpress.XtraGrid.Columns.GridColumn gc_username;
        private DevExpress.XtraGrid.Columns.GridColumn gc_thanhtien;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
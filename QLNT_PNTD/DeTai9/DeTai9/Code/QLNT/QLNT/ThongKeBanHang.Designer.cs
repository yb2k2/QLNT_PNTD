namespace QLNT
{
    partial class Thống_Kê_Bán_Hàng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thống_Kê_Bán_Hàng));
            this.grd_thongkebanhang = new DevExpress.XtraGrid.GridControl();
            this.gv_thongkebanhang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_mahd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_trangthai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_giothanhtoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_mathuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_tenthuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_hamluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_hangsx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_macthd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_donvi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_soluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_giabantheodonvi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_thanhtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grd_thongkebanhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_thongkebanhang)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_thongkebanhang
            // 
            this.grd_thongkebanhang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_thongkebanhang.Location = new System.Drawing.Point(0, 0);
            this.grd_thongkebanhang.MainView = this.gv_thongkebanhang;
            this.grd_thongkebanhang.Name = "grd_thongkebanhang";
            this.grd_thongkebanhang.Size = new System.Drawing.Size(917, 471);
            this.grd_thongkebanhang.TabIndex = 0;
            this.grd_thongkebanhang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_thongkebanhang});
            // 
            // gv_thongkebanhang
            // 
            this.gv_thongkebanhang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_mahd,
            this.gc_trangthai,
            this.gc_username,
            this.gc_giothanhtoan,
            this.gc_mathuoc,
            this.gc_tenthuoc,
            this.gc_hamluong,
            this.gc_hangsx,
            this.gc_macthd,
            this.gc_donvi,
            this.gc_soluong,
            this.gc_giabantheodonvi,
            this.gc_thanhtien});
            this.gv_thongkebanhang.GridControl = this.grd_thongkebanhang;
            this.gv_thongkebanhang.Name = "gv_thongkebanhang";
            this.gv_thongkebanhang.OptionsView.ShowFooter = true;
            this.gv_thongkebanhang.OptionsView.ShowGroupPanel = false;
            // 
            // gc_mahd
            // 
            this.gc_mahd.Caption = "Mã Hóa Đơn";
            this.gc_mahd.FieldName = "mahd";
            this.gc_mahd.Name = "gc_mahd";
            this.gc_mahd.Visible = true;
            this.gc_mahd.VisibleIndex = 0;
            // 
            // gc_trangthai
            // 
            this.gc_trangthai.Caption = "Trạng Thái";
            this.gc_trangthai.FieldName = "trangthai";
            this.gc_trangthai.Name = "gc_trangthai";
            this.gc_trangthai.Visible = true;
            this.gc_trangthai.VisibleIndex = 1;
            // 
            // gc_username
            // 
            this.gc_username.Caption = "Username";
            this.gc_username.FieldName = "username";
            this.gc_username.Name = "gc_username";
            this.gc_username.Visible = true;
            this.gc_username.VisibleIndex = 2;
            // 
            // gc_giothanhtoan
            // 
            this.gc_giothanhtoan.Caption = "Giờ Thanh Toán";
            this.gc_giothanhtoan.FieldName = "giothanhtoan";
            this.gc_giothanhtoan.Name = "gc_giothanhtoan";
            this.gc_giothanhtoan.Visible = true;
            this.gc_giothanhtoan.VisibleIndex = 3;
            // 
            // gc_mathuoc
            // 
            this.gc_mathuoc.Caption = "Mã Thuốc";
            this.gc_mathuoc.FieldName = "mathuoc";
            this.gc_mathuoc.Name = "gc_mathuoc";
            this.gc_mathuoc.Visible = true;
            this.gc_mathuoc.VisibleIndex = 4;
            // 
            // gc_tenthuoc
            // 
            this.gc_tenthuoc.Caption = "Tên Thuốc";
            this.gc_tenthuoc.FieldName = "tenthuoc";
            this.gc_tenthuoc.Name = "gc_tenthuoc";
            this.gc_tenthuoc.Visible = true;
            this.gc_tenthuoc.VisibleIndex = 5;
            // 
            // gc_hamluong
            // 
            this.gc_hamluong.Caption = "Hàm Lượng";
            this.gc_hamluong.FieldName = "hamluong";
            this.gc_hamluong.Name = "gc_hamluong";
            this.gc_hamluong.Visible = true;
            this.gc_hamluong.VisibleIndex = 6;
            // 
            // gc_hangsx
            // 
            this.gc_hangsx.Caption = "Hãng Sản Xuất";
            this.gc_hangsx.FieldName = "hangsx";
            this.gc_hangsx.Name = "gc_hangsx";
            this.gc_hangsx.Visible = true;
            this.gc_hangsx.VisibleIndex = 7;
            // 
            // gc_macthd
            // 
            this.gc_macthd.Caption = "Mã Chi Tiết Hóa Đơn";
            this.gc_macthd.FieldName = "macthd";
            this.gc_macthd.Name = "gc_macthd";
            this.gc_macthd.Visible = true;
            this.gc_macthd.VisibleIndex = 8;
            // 
            // gc_donvi
            // 
            this.gc_donvi.Caption = "Đơn Vị";
            this.gc_donvi.FieldName = "donvi";
            this.gc_donvi.Name = "gc_donvi";
            this.gc_donvi.Visible = true;
            this.gc_donvi.VisibleIndex = 9;
            // 
            // gc_soluong
            // 
            this.gc_soluong.Caption = "Số Lượng";
            this.gc_soluong.FieldName = "soluong";
            this.gc_soluong.Name = "gc_soluong";
            this.gc_soluong.Visible = true;
            this.gc_soluong.VisibleIndex = 10;
            // 
            // gc_giabantheodonvi
            // 
            this.gc_giabantheodonvi.Caption = "Giá Bán Theo Đơn Vị";
            this.gc_giabantheodonvi.FieldName = "giabantheodonvi";
            this.gc_giabantheodonvi.Name = "gc_giabantheodonvi";
            this.gc_giabantheodonvi.Visible = true;
            this.gc_giabantheodonvi.VisibleIndex = 11;
            // 
            // gc_thanhtien
            // 
            this.gc_thanhtien.Caption = "Thành Tiền";
            this.gc_thanhtien.FieldName = "thanhtien";
            this.gc_thanhtien.Name = "gc_thanhtien";
            this.gc_thanhtien.Visible = true;
            this.gc_thanhtien.VisibleIndex = 12;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(749, 489);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "Lưu";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(830, 489);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Thống_Kê_Bán_Hàng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 524);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.grd_thongkebanhang);
            this.Name = "Thống_Kê_Bán_Hàng";
            this.Text = "Thống Kê Bán Hàng";
            this.Load += new System.EventHandler(this.Thống_Kê_Bán_Hàng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_thongkebanhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_thongkebanhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_thongkebanhang;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_thongkebanhang;
        private DevExpress.XtraGrid.Columns.GridColumn gc_mahd;
        private DevExpress.XtraGrid.Columns.GridColumn gc_trangthai;
        private DevExpress.XtraGrid.Columns.GridColumn gc_username;
        private DevExpress.XtraGrid.Columns.GridColumn gc_giothanhtoan;
        private DevExpress.XtraGrid.Columns.GridColumn gc_mathuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gc_tenthuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gc_hamluong;
        private DevExpress.XtraGrid.Columns.GridColumn gc_hangsx;
        private DevExpress.XtraGrid.Columns.GridColumn gc_macthd;
        private DevExpress.XtraGrid.Columns.GridColumn gc_donvi;
        private DevExpress.XtraGrid.Columns.GridColumn gc_soluong;
        private DevExpress.XtraGrid.Columns.GridColumn gc_giabantheodonvi;
        private DevExpress.XtraGrid.Columns.GridColumn gc_thanhtien;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
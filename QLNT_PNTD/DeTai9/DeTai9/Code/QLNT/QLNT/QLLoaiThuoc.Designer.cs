namespace QLNT
{
    partial class QLLoaiThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLLoaiThuoc));
            this.grd_loaiThuoc = new DevExpress.XtraGrid.GridControl();
            this.gv_loaiThuoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_tenLoaiThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_mota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rếhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grd_loaiThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_loaiThuoc)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd_loaiThuoc
            // 
            this.grd_loaiThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_loaiThuoc.Location = new System.Drawing.Point(0, 0);
            this.grd_loaiThuoc.MainView = this.gv_loaiThuoc;
            this.grd_loaiThuoc.Name = "grd_loaiThuoc";
            this.grd_loaiThuoc.Size = new System.Drawing.Size(799, 459);
            this.grd_loaiThuoc.TabIndex = 14;
            this.grd_loaiThuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_loaiThuoc});
            // 
            // gv_loaiThuoc
            // 
            this.gv_loaiThuoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_tenLoaiThuoc,
            this.gc_mota});
            this.gv_loaiThuoc.GridControl = this.grd_loaiThuoc;
            this.gv_loaiThuoc.Name = "gv_loaiThuoc";
            this.gv_loaiThuoc.OptionsView.ShowGroupPanel = false;
            // 
            // gc_tenLoaiThuoc
            // 
            this.gc_tenLoaiThuoc.Caption = "Tên Loại Thuốc";
            this.gc_tenLoaiThuoc.FieldName = "tenlt";
            this.gc_tenLoaiThuoc.Name = "gc_tenLoaiThuoc";
            this.gc_tenLoaiThuoc.Visible = true;
            this.gc_tenLoaiThuoc.VisibleIndex = 0;
            // 
            // gc_mota
            // 
            this.gc_mota.Caption = "Mô Tả";
            this.gc_mota.FieldName = "mota";
            this.gc_mota.Name = "gc_mota";
            this.gc_mota.Visible = true;
            this.gc_mota.VisibleIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(623, 529);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Text = "Lưu";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(726, 529);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Thoát";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(631, 474);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 16;
            this.simpleButton3.Text = "Lưu";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(712, 474);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 15;
            this.simpleButton4.Text = "Thoát";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.rếhToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 92);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // rếhToolStripMenuItem
            // 
            this.rếhToolStripMenuItem.Name = "rếhToolStripMenuItem";
            this.rếhToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.rếhToolStripMenuItem.Text = "Rếh";
            this.rếhToolStripMenuItem.Click += new System.EventHandler(this.rếhToolStripMenuItem_Click);
            // 
            // QLLoaiThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 509);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.grd_loaiThuoc);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "QLLoaiThuoc";
            this.Text = "Quản Lý Loại Thuốc";
            this.Load += new System.EventHandler(this.QLLoaiThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_loaiThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_loaiThuoc)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_loaiThuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_loaiThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gc_tenLoaiThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gc_mota;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rếhToolStripMenuItem;
    }
}
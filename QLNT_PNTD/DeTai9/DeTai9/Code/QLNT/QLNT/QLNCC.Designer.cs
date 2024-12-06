namespace QLNT
{
    partial class QLNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLNCC));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.grd_ncc = new DevExpress.XtraGrid.GridControl();
            this.gv_ncc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_tenncc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_loaincc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_loaincc = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gc_mota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ncc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ncc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_loaincc)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(631, 474);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "Lưu";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(712, 474);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // grd_ncc
            // 
            this.grd_ncc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_ncc.Location = new System.Drawing.Point(0, 0);
            this.grd_ncc.MainView = this.gv_ncc;
            this.grd_ncc.Name = "grd_ncc";
            this.grd_ncc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txt_loaincc});
            this.grd_ncc.Size = new System.Drawing.Size(799, 459);
            this.grd_ncc.TabIndex = 11;
            this.grd_ncc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ncc});
            // 
            // gv_ncc
            // 
            this.gv_ncc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_tenncc,
            this.gc_loaincc,
            this.gc_mota});
            this.gv_ncc.GridControl = this.grd_ncc;
            this.gv_ncc.Name = "gv_ncc";
            this.gv_ncc.OptionsView.ShowGroupPanel = false;
            // 
            // gc_tenncc
            // 
            this.gc_tenncc.Caption = "Tên Nhà Cung Cấp";
            this.gc_tenncc.FieldName = "tenncc";
            this.gc_tenncc.Name = "gc_tenncc";
            this.gc_tenncc.Visible = true;
            this.gc_tenncc.VisibleIndex = 0;
            // 
            // gc_loaincc
            // 
            this.gc_loaincc.Caption = "Loại Nhà Cung Cấp";
            this.gc_loaincc.ColumnEdit = this.txt_loaincc;
            this.gc_loaincc.FieldName = "loaincc";
            this.gc_loaincc.Name = "gc_loaincc";
            this.gc_loaincc.Visible = true;
            this.gc_loaincc.VisibleIndex = 1;
            // 
            // txt_loaincc
            // 
            this.txt_loaincc.AutoHeight = false;
            this.txt_loaincc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_loaincc.Items.AddRange(new object[] {
            "Nhà Máy Sản Xuất",
            "Đại Lý"});
            this.txt_loaincc.Name = "txt_loaincc";
            // 
            // gc_mota
            // 
            this.gc_mota.Caption = "Mô Tả";
            this.gc_mota.FieldName = "mota";
            this.gc_mota.Name = "gc_mota";
            this.gc_mota.Visible = true;
            this.gc_mota.VisibleIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.toolStripMenuItem1});
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem1.Text = "Refresh";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // QLNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 509);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.grd_ncc);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "QLNCC";
            this.Text = "Quản Lý Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.QLNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ncc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ncc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_loaincc)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl grd_ncc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ncc;
        private DevExpress.XtraGrid.Columns.GridColumn gc_tenncc;
        private DevExpress.XtraGrid.Columns.GridColumn gc_loaincc;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox txt_loaincc;
        private DevExpress.XtraGrid.Columns.GridColumn gc_mota;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
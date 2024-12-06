namespace QLNT
{
    partial class BanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHang));
            this.grd_banthuoc = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gv_banthuoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_mathuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_TenThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_HangSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_HamLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_giaban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_soluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_donvi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_thanhtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_hinhanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.txt_giaban = new DevExpress.XtraEditors.TextEdit();
            this.txt_chonthuoc = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_dvcoban = new System.Windows.Forms.RadioButton();
            this.txt_soluongton = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_dvban = new System.Windows.Forms.RadioButton();
            this.txt_soluong = new DevExpress.XtraEditors.CalcEdit();
            this.txt_thanhtien = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tongthanhtien = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grd_banthuoc)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_banthuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_giaban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_chonthuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soluongton.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_thanhtien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tongthanhtien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_banthuoc
            // 
            this.grd_banthuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_banthuoc.ContextMenuStrip = this.contextMenuStrip1;
            this.grd_banthuoc.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grd_banthuoc.Location = new System.Drawing.Point(1, 134);
            this.grd_banthuoc.MainView = this.gv_banthuoc;
            this.grd_banthuoc.Name = "grd_banthuoc";
            this.grd_banthuoc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.grd_banthuoc.Size = new System.Drawing.Size(962, 330);
            this.grd_banthuoc.TabIndex = 1;
            this.grd_banthuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_banthuoc});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // gv_banthuoc
            // 
            this.gv_banthuoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_mathuoc,
            this.gc_TenThuoc,
            this.gc_HangSX,
            this.gc_HamLuong,
            this.gc_giaban,
            this.gc_soluong,
            this.gc_donvi,
            this.gc_thanhtien,
            this.gc_hinhanh});
            this.gv_banthuoc.GridControl = this.grd_banthuoc;
            this.gv_banthuoc.Name = "gv_banthuoc";
            this.gv_banthuoc.OptionsBehavior.ReadOnly = true;
            this.gv_banthuoc.OptionsView.RowAutoHeight = true;
            this.gv_banthuoc.OptionsView.ShowGroupPanel = false;
            // 
            // gc_mathuoc
            // 
            this.gc_mathuoc.Caption = "Mã Thuốc";
            this.gc_mathuoc.FieldName = "mathuoc";
            this.gc_mathuoc.Name = "gc_mathuoc";
            this.gc_mathuoc.Visible = true;
            this.gc_mathuoc.VisibleIndex = 0;
            // 
            // gc_TenThuoc
            // 
            this.gc_TenThuoc.Caption = "Tên Thuốc";
            this.gc_TenThuoc.FieldName = "tenthuoc";
            this.gc_TenThuoc.Name = "gc_TenThuoc";
            this.gc_TenThuoc.Visible = true;
            this.gc_TenThuoc.VisibleIndex = 1;
            // 
            // gc_HangSX
            // 
            this.gc_HangSX.Caption = "Hãng Sản Xuất";
            this.gc_HangSX.FieldName = "hangsx";
            this.gc_HangSX.Name = "gc_HangSX";
            this.gc_HangSX.Visible = true;
            this.gc_HangSX.VisibleIndex = 2;
            // 
            // gc_HamLuong
            // 
            this.gc_HamLuong.Caption = "Hàm Lượng";
            this.gc_HamLuong.FieldName = "hamluong";
            this.gc_HamLuong.Name = "gc_HamLuong";
            this.gc_HamLuong.Visible = true;
            this.gc_HamLuong.VisibleIndex = 3;
            // 
            // gc_giaban
            // 
            this.gc_giaban.Caption = "Giá Bán";
            this.gc_giaban.FieldName = "giabantheodonvi";
            this.gc_giaban.Name = "gc_giaban";
            this.gc_giaban.Visible = true;
            this.gc_giaban.VisibleIndex = 4;
            // 
            // gc_soluong
            // 
            this.gc_soluong.Caption = "Số Lượng";
            this.gc_soluong.FieldName = "soluong";
            this.gc_soluong.Name = "gc_soluong";
            this.gc_soluong.Visible = true;
            this.gc_soluong.VisibleIndex = 5;
            // 
            // gc_donvi
            // 
            this.gc_donvi.Caption = "Đơn Vị";
            this.gc_donvi.FieldName = "donvi";
            this.gc_donvi.Name = "gc_donvi";
            this.gc_donvi.Visible = true;
            this.gc_donvi.VisibleIndex = 6;
            // 
            // gc_thanhtien
            // 
            this.gc_thanhtien.Caption = "Thành Tiền";
            this.gc_thanhtien.FieldName = "thanhtien";
            this.gc_thanhtien.Name = "gc_thanhtien";
            this.gc_thanhtien.Visible = true;
            this.gc_thanhtien.VisibleIndex = 7;
            // 
            // gc_hinhanh
            // 
            this.gc_hinhanh.Caption = "Hình Ảnh";
            this.gc_hinhanh.ColumnEdit = this.repositoryItemPictureEdit1;
            this.gc_hinhanh.FieldName = "hinhanh";
            this.gc_hinhanh.Name = "gc_hinhanh";
            this.gc_hinhanh.Visible = true;
            this.gc_hinhanh.VisibleIndex = 8;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.CustomHeight = 100;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            // 
            // txt_giaban
            // 
            this.txt_giaban.Location = new System.Drawing.Point(12, 95);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaban.Properties.Appearance.Options.UseFont = true;
            this.txt_giaban.Properties.ReadOnly = true;
            this.txt_giaban.Size = new System.Drawing.Size(294, 22);
            this.txt_giaban.TabIndex = 36;
            this.txt_giaban.EditValueChanged += new System.EventHandler(this.txt_giaban_EditValueChanged);
            // 
            // txt_chonthuoc
            // 
            this.txt_chonthuoc.Location = new System.Drawing.Point(12, 34);
            this.txt_chonthuoc.Name = "txt_chonthuoc";
            this.txt_chonthuoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chonthuoc.Properties.Appearance.Options.UseFont = true;
            this.txt_chonthuoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_chonthuoc.Properties.DisplayMember = "tenthuoc";
            this.txt_chonthuoc.Properties.NullText = "";
            this.txt_chonthuoc.Properties.ValueMember = "mathuoc";
            this.txt_chonthuoc.Properties.View = this.searchLookUpEdit1View;
            this.txt_chonthuoc.Size = new System.Drawing.Size(294, 22);
            this.txt_chonthuoc.TabIndex = 33;
            this.txt_chonthuoc.EditValueChanged += new System.EventHandler(this.txt_chonthuoc_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 73);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 16);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "Giá Bán";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 16);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "Chọn Thuốc";
            // 
            // txt_dvcoban
            // 
            this.txt_dvcoban.AutoSize = true;
            this.txt_dvcoban.Location = new System.Drawing.Point(6, 21);
            this.txt_dvcoban.Name = "txt_dvcoban";
            this.txt_dvcoban.Size = new System.Drawing.Size(93, 17);
            this.txt_dvcoban.TabIndex = 0;
            this.txt_dvcoban.TabStop = true;
            this.txt_dvcoban.Text = "Đơn Vị Cơ Bản";
            this.txt_dvcoban.UseVisualStyleBackColor = true;
            this.txt_dvcoban.CheckedChanged += new System.EventHandler(this.txt_dvcoban_CheckedChanged);
            // 
            // txt_soluongton
            // 
            this.txt_soluongton.Location = new System.Drawing.Point(334, 95);
            this.txt_soluongton.Name = "txt_soluongton";
            this.txt_soluongton.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluongton.Properties.Appearance.Options.UseFont = true;
            this.txt_soluongton.Properties.ReadOnly = true;
            this.txt_soluongton.Size = new System.Drawing.Size(294, 22);
            this.txt_soluongton.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_dvban);
            this.groupBox1.Controls.Add(this.txt_dvcoban);
            this.groupBox1.Location = new System.Drawing.Point(334, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 55);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đơn Vị";
            // 
            // txt_dvban
            // 
            this.txt_dvban.AutoSize = true;
            this.txt_dvban.Location = new System.Drawing.Point(185, 21);
            this.txt_dvban.Name = "txt_dvban";
            this.txt_dvban.Size = new System.Drawing.Size(77, 17);
            this.txt_dvban.TabIndex = 1;
            this.txt_dvban.TabStop = true;
            this.txt_dvban.Text = "Đơn Vị Bán";
            this.txt_dvban.UseVisualStyleBackColor = true;
            this.txt_dvban.CheckedChanged += new System.EventHandler(this.txt_dvban_CheckedChanged);
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(661, 34);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Properties.Appearance.Options.UseFont = true;
            this.txt_soluong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_soluong.Size = new System.Drawing.Size(294, 22);
            this.txt_soluong.TabIndex = 38;
            this.txt_soluong.EditValueChanged += new System.EventHandler(this.txt_soluong_EditValueChanged);
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Location = new System.Drawing.Point(661, 95);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thanhtien.Properties.Appearance.Options.UseFont = true;
            this.txt_thanhtien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_thanhtien.Size = new System.Drawing.Size(294, 22);
            this.txt_thanhtien.TabIndex = 37;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(661, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 16);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "Số Lượng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(661, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 16);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Thành Tiền";
            // 
            // txt_tongthanhtien
            // 
            this.txt_tongthanhtien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_tongthanhtien.Location = new System.Drawing.Point(12, 492);
            this.txt_tongthanhtien.Name = "txt_tongthanhtien";
            this.txt_tongthanhtien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongthanhtien.Properties.Appearance.Options.UseFont = true;
            this.txt_tongthanhtien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_tongthanhtien.Size = new System.Drawing.Size(294, 22);
            this.txt_tongthanhtien.TabIndex = 40;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 470);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(104, 16);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Tổng Thành Tiền";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(849, 500);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(102, 23);
            this.simpleButton3.TabIndex = 45;
            this.simpleButton3.Text = "In Hóa Đơn";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(729, 500);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(103, 23);
            this.simpleButton2.TabIndex = 44;
            this.simpleButton2.Text = "Thanh Toán";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(623, 500);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 23);
            this.simpleButton1.TabIndex = 43;
            this.simpleButton1.Text = "Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(334, 73);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(87, 16);
            this.labelControl5.TabIndex = 46;
            this.labelControl5.Text = "Số Lượng Tồn";
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 535);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txt_tongthanhtien);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_giaban);
            this.Controls.Add(this.txt_chonthuoc);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_soluongton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_thanhtien);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grd_banthuoc);
            this.Name = "BanHang";
            this.Text = "Bán Thuốc";
            this.Load += new System.EventHandler(this.BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_banthuoc)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_banthuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_giaban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_chonthuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soluongton.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_thanhtien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tongthanhtien.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_banthuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_banthuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gc_mathuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gc_TenThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn gc_HangSX;
        private DevExpress.XtraGrid.Columns.GridColumn gc_HamLuong;
        private DevExpress.XtraGrid.Columns.GridColumn gc_giaban;
        private DevExpress.XtraGrid.Columns.GridColumn gc_soluong;
        private DevExpress.XtraGrid.Columns.GridColumn gc_donvi;
        private DevExpress.XtraGrid.Columns.GridColumn gc_thanhtien;
        private DevExpress.XtraGrid.Columns.GridColumn gc_hinhanh;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.TextEdit txt_giaban;
        private DevExpress.XtraEditors.SearchLookUpEdit txt_chonthuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.RadioButton txt_dvcoban;
        private DevExpress.XtraEditors.TextEdit txt_soluongton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton txt_dvban;
        private DevExpress.XtraEditors.CalcEdit txt_soluong;
        private DevExpress.XtraEditors.CalcEdit txt_thanhtien;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CalcEdit txt_tongthanhtien;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
    }
}
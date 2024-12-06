using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLNT.Global;
using System.Data.SqlClient;

namespace QLNT
{
    public partial class QlThuoc : DevExpress.XtraEditors.XtraForm
    {
        public QlThuoc()
        {
            InitializeComponent();
        }
        Main m;
        public QlThuoc(Main m)
        {
            InitializeComponent();
            this.m = m;
        }
        public void LoadData()
        {
            try
            {
                var dtLoaiThuoc = SQL.GetData("select malt,tenlt from loaithuoc", CommandType.Text);
                txt_loaithuoc.DataSource = dtLoaiThuoc;
                var dtNhaCC = SQL.GetData("select mancc,tenncc from nhacungcap", CommandType.Text);
                txt_nhacc.DataSource = dtNhaCC;
                string query = @"select * from thuoc";
                var dt = SQL.GetData(query, CommandType.Text);
                grd_qlthuoc.DataSource = dt;
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        private void QlThuoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pic_hinhanh_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Image img = Data.SelectImageFromFile();
                var byteImage = Data.ConvertImageToByte(img);
                gv_qlthuoc.SetRowCellValue(gv_qlthuoc.FocusedRowHandle, gc_HinhAnh, byteImage);
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var data = (grd_qlthuoc.DataSource as DataTable);
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    if (gv_qlthuoc.GetRowCellValue(i, gv_qlthuoc.Columns.ColumnByFieldName("tenthuoc")).ToString() == "")
                    {
                        m.Status(TypeStatus.Error, "Tên thuốc không được để trống");
                        return;
                    }
                    if (gv_qlthuoc.GetRowCellValue(i, gv_qlthuoc.Columns.ColumnByFieldName("mancc")).ToString() == "")
                    {
                        m.Status(TypeStatus.Error, "Nhà cung cấp không được để trống");
                        return;
                    }
                    if (gv_qlthuoc.GetRowCellValue(i, gv_qlthuoc.Columns.ColumnByFieldName("malt")).ToString() == "")
                    {
                        m.Status(TypeStatus.Error, "Loại thuốc không được để trống");
                        return;
                    }
                    if (gv_qlthuoc.GetRowCellValue(i, gv_qlthuoc.Columns.ColumnByFieldName("donvicoban")).ToString() == "")
                    {
                        m.Status(TypeStatus.Error, "Đơn vị cơ bản không được để trống");
                        return;
                    }
                    if (gv_qlthuoc.GetRowCellValue(i, gv_qlthuoc.Columns.ColumnByFieldName("donviban")).ToString() == "")
                    {
                        m.Status(TypeStatus.Error, "Đơn vị bán không được để trống");
                        return;
                    }
                    if (gv_qlthuoc.GetRowCellValue(i, gv_qlthuoc.Columns.ColumnByFieldName("hansd")).ToString() == "")
                    {
                        m.Status(TypeStatus.Error, "Hạn sử dụng không được để trống");
                        return;
                    }
                    if (gv_qlthuoc.GetRowCellValue(i, gv_qlthuoc.Columns.ColumnByFieldName("giatriquydoi")).ToString() == "")
                    {
                        m.Status(TypeStatus.Error, "Giá trị quy đổi không được để trống");
                        return;
                    }
                    if (gv_qlthuoc.GetRowCellValue(i, gv_qlthuoc.Columns.ColumnByFieldName("soluong")).ToString() == "")
                    {
                        m.Status(TypeStatus.Error, "Số lượng thuốc không được để trống");
                        return;
                    }
                    if (gv_qlthuoc.GetRowCellValue(i, gv_qlthuoc.Columns.ColumnByFieldName("giaban")).ToString() == "")
                    {
                        m.Status(TypeStatus.Error, "Giá bán thuốc không được để trống");
                        return;
                    }
                }

                var dt = grd_qlthuoc.DataSource as DataTable;
                const string tempTB = @"#Thuoc";
                SQL.CreateTempTable3(dt.Copy(), "Thuoc", tempTB);
                const string sql = @"delete from Thuoc insert into Thuoc select * from #Thuoc";
                var result = SQL.ExcuteNonquery(sql, CommandType.Text);
                if (result == "")
                {
                    m.Status(TypeStatus.Success, "Thành Công");
                    LoadData();
                }
                else
                {
                    m.Status(TypeStatus.Error, result);
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        public void Them()
        {
            try
            {
                var dt = grd_qlthuoc.DataSource as DataTable;
                var row = dt.NewRow();
                if (dt.Rows.Count > 0)
                {
                    int maxID = dt.AsEnumerable().Max(nrow => Convert.ToInt32(nrow["mathuoc"]));
                    row["mathuoc"] = maxID + 1;
                }
                else
                {
                    row["mathuoc"] = 1;
                }
                row["giatriquydoi"] = 1;
                row["soluong"] = 0;
                row["giaban"] = 0;
                var img = Image.FromFile(@"Item//noimage.png");
                var byteImage = Data.ConvertImageToByte(img);
                row["hinhanh"] = byteImage;
                dt.Rows.Add(row);
                grd_qlthuoc.DataSource = dt;

            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Them();
        }
        public void Xoa()
        {
            try
            {
                var mathuoc = gv_qlthuoc.GetFocusedRowCellValue("mathuoc");
                var query = "delete from Thuoc where mathuoc=@mathuoc";
                var result = SQL.ExcuteNonquery(query, CommandType.Text, new SqlParameter("@mathuoc", mathuoc));
                if (result == "")
                {
                    m.Status(TypeStatus.Success, "Thành Công");
                    LoadData();
                }
                else
                {
                    m.Status(TypeStatus.Error, result);
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var dlResult = XtraMessageBox.Show("Bạn có muốn xóa ?", "Xóa", MessageBoxButtons.YesNo);
                if (dlResult == DialogResult.Yes)
                {
                    Xoa();
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_qlthuoc.IsFindPanelVisible == false)
                {
                    gv_qlthuoc.ShowFindPanel();
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var dlResult = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo);
                if (dlResult == DialogResult.Yes)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        
        private void txt_giaban_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int rowHander = gv_qlthuoc.FocusedRowHandle;
                if (gv_qlthuoc.GetRowCellValue(rowHander, gc_GiaBan) == null || gv_qlthuoc.GetRowCellValue(rowHander, gc_GiaTriQuyDoi) == null)
                {
                    return;
                }

                int giaban = int.Parse(gv_qlthuoc.GetRowCellValue(rowHander, gc_GiaBan).ToString());
                int gtqd = int.Parse(gv_qlthuoc.GetRowCellValue(rowHander, gc_GiaTriQuyDoi).ToString());
                gv_qlthuoc.SetRowCellValue(rowHander, gc_giabantheodvban, giaban * gtqd);
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void txt_giatriquydoi_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int rowHander = gv_qlthuoc.FocusedRowHandle;
                if (gv_qlthuoc.GetRowCellValue(rowHander,gc_SoLuong)==null||gv_qlthuoc.GetRowCellValue(rowHander, gc_GiaBan) == null || gv_qlthuoc.GetRowCellValue(rowHander, gc_GiaTriQuyDoi) == null)
                {
                    return;
                }

                int giaban = int.Parse(gv_qlthuoc.GetRowCellValue(rowHander, gc_GiaBan).ToString());
                int gtqd = int.Parse(gv_qlthuoc.GetRowCellValue(rowHander, gc_GiaTriQuyDoi).ToString());
                int soLuong = int.Parse(gv_qlthuoc.GetRowCellValue(rowHander, gc_SoLuong).ToString());
                gv_qlthuoc.SetRowCellValue(rowHander, gc_giabantheodvban, giaban * gtqd);
                gv_qlthuoc.SetRowCellValue(rowHander, gc_SoLuongTheoDVBan, soLuong / gtqd);
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void txt_soluong_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int rowHander = gv_qlthuoc.FocusedRowHandle;
                if (gv_qlthuoc.GetRowCellValue(rowHander, gc_SoLuong) == null || gv_qlthuoc.GetRowCellValue(rowHander, gc_GiaTriQuyDoi) == null)
                {
                    return;
                }

                int soLuong = int.Parse(gv_qlthuoc.GetRowCellValue(rowHander, gc_SoLuong).ToString());
                int gtqd = int.Parse(gv_qlthuoc.GetRowCellValue(rowHander, gc_GiaTriQuyDoi).ToString());
                gv_qlthuoc.SetRowCellValue(rowHander, gc_SoLuongTheoDVBan, soLuong / gtqd);
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

    }
}
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
    public partial class QLLoaiThuoc : DevExpress.XtraEditors.XtraForm
    {
        Main m;
        public QLLoaiThuoc()
        {
            InitializeComponent();
        }
        public QLLoaiThuoc(Main m)
        {
            InitializeComponent();
            this.m = m;
        }
        public void LoadData()
        {
            try
            {
                var dt = SQL.GetData("select * from LoaiThuoc", CommandType.Text);
                grd_loaiThuoc.DataSource = dt;
                gv_loaiThuoc.ClearColumnsFilter();
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        private void QLLoaiThuoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = grd_loaiThuoc.DataSource as DataTable;
                const string tempTB = @"#LoaiThuoc";
                SQL.CreateTempTable3(dt.Copy(), "LoaiThuoc", tempTB);
                const string sql = @"delete from LoaiThuoc insert into LoaiThuoc select * from #LoaiThuoc";
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
                var dt = grd_loaiThuoc.DataSource as DataTable;
                var row = dt.NewRow();
                if (dt.Rows.Count > 0)
                {
                    int maxID = dt.AsEnumerable().Max(nrow => Convert.ToInt32(nrow["malt"]));
                    row["malt"] = maxID + 1;
                }
                else
                {
                    row["malt"] = 1;
                }
                dt.Rows.Add(row);
                grd_loaiThuoc.DataSource = dt;
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
                var malt = gv_loaiThuoc.GetFocusedRowCellValue("malt");
                var query = "delete from LoaiThuoc where malt=@malt";
                var result = SQL.ExcuteNonquery(query, CommandType.Text, new SqlParameter(@"malt", malt));
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
                if (gv_loaiThuoc.IsFindPanelVisible == false)
                {
                    gv_loaiThuoc.ShowFindPanel();
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void rếhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
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
    }
}
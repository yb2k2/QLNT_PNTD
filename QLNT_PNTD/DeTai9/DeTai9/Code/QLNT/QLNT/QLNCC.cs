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
    public partial class QLNCC : DevExpress.XtraEditors.XtraForm
    {
        Main m;
        public QLNCC()
        {
            InitializeComponent();
        }
        public QLNCC(Main m)
        {
            InitializeComponent();
            this.m = m;
        }
        public void LoadData()
        {
            try
            {
                var dt = SQL.GetData("select * from NhaCungCap", CommandType.Text);
                grd_ncc.DataSource = dt;
                gv_ncc.ClearColumnsFilter();
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        private void QLNCC_Load(object sender, EventArgs e)
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = grd_ncc.DataSource as DataTable;
                const string tempTB = @"#NhaCungCap";
                SQL.CreateTempTable3(dt.Copy(), "NhaCungCap", tempTB);
                const string sql = @"delete from NhaCungCap insert into NhaCungCap select * from #NhaCungCap";
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
                var dt = grd_ncc.DataSource as DataTable;
                var row = dt.NewRow();
                if (dt.Rows.Count > 0)
                {
                    int maxID = dt.AsEnumerable().Max(nrow => Convert.ToInt32(nrow["mancc"]));
                    row["mancc"] = maxID + 1;
                }
                else
                {
                    row["mancc"] = 1;
                }
                row["loaincc"] = "Đại Lý";
                dt.Rows.Add(row);
                grd_ncc.DataSource = dt;
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
                var mancc = gv_ncc.GetFocusedRowCellValue("mancc");
                var query = "delete from NhaCungCap where mancc=@mancc";
                var result = SQL.ExcuteNonquery(query, CommandType.Text, new SqlParameter(@"mancc", mancc));
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
                if (gv_ncc.IsFindPanelVisible == false)
                {
                    gv_ncc.ShowFindPanel();
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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

    }
}
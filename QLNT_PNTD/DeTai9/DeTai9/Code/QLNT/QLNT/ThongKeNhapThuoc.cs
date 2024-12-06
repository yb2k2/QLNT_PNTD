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

namespace QLNT
{
    public partial class ThongKeNhapThuoc : DevExpress.XtraEditors.XtraForm
    {
        public ThongKeNhapThuoc()
        {
            InitializeComponent();
        }
        Main m;
        public ThongKeNhapThuoc(Main m)
        {
            InitializeComponent();
            this.m = m;
        }
        public void LoadData()
        {
            try
            {
                var query = @"select a.manhaphang,a.donvinhap,a.giatriquydoi,a.soluongnhap,a.gianhap,a.mota,a.ngaynhap,a.thanhtien,a.username,b.tenthuoc,b.hamluong,b.hangsx from nhaphang a,thuoc b where a.mathuoc=b.mathuoc";
                var dt = SQL.GetData(query, CommandType.Text);
                grd_thongkenhapthuoc.DataSource = dt;
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        private void ThongKeNhapThuoc_Load(object sender, EventArgs e)
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
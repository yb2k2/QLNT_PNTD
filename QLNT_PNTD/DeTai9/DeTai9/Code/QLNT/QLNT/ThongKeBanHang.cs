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
    public partial class Thống_Kê_Bán_Hàng : DevExpress.XtraEditors.XtraForm
    {
        public Thống_Kê_Bán_Hàng()
        {
            InitializeComponent();
        }
        Main m;
        public Thống_Kê_Bán_Hàng(Main m)
        {
            InitializeComponent();
            this.m = m;
        }
        public void LoadData()
        {
            try
            {
                string query = @"select b.mahd,b.trangthai,b.username,b.giothanhtoan,a.mathuoc,a.tenthuoc,a.hamluong,a.hangsx,c.macthd,c.donvi,c.soluong,c.giabantheodonvi,c.thanhtien from thuoc a,HoaDon b,ChiTietHD c where a.mathuoc=c.mathuoc and b.mahd=c.mahd";
                var dt = SQL.GetData(query, CommandType.Text);
                grd_thongkebanhang.DataSource = dt;
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }            
        }
        private void Thống_Kê_Bán_Hàng_Load(object sender, EventArgs e)
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
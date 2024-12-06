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
using Microsoft.Reporting.WinForms;
using QLNT.Global;

namespace QLNT
{
    public partial class In : DevExpress.XtraEditors.XtraForm
    {
        public In()
        {
            InitializeComponent();
        }

        private void In_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLNTDataSet.DataTable1' table. You can move, or remove it, as needed.
            var query = @"select t1.tenthuoc, t0.giabantheodonvi,t0.soluong,t0.thanhtien 
from ChiTietHD t0 
inner join Thuoc t1 on t0.mathuoc = t1.mathuoc
inner join HoaDon t2 on t2.mahd = t0.mahd
where lower(t2.trangthai) = 'unpaid'";
            var dt = SQL.GetData(query, CommandType.Text);
            var dataSource = new ReportDataSource("DataSet2", dt);

            // Add the data source to the report viewer
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dataSource);

            // Refresh the report
            reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
    }
}
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
    public partial class BanThuoc : DevExpress.XtraEditors.XtraForm
    {

        public BanThuoc()
        {
            InitializeComponent();
        }
        Main m;
        public BanThuoc(Main m)
        {
            InitializeComponent();
            this.m = m;
        }

        private void BanThuoc_Load(object sender, EventArgs e)
        {
            try
            {
                var dt = SQL.GetData("select mathuoc,tenthuoc,hamluong,hangsx from thuoc", CommandType.Text);
                txt_chonthuoc.Properties.DataSource = dt;
                LoadGridView();

            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void txt_dvcoban_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var dt=SQL.GetData("select * from thuoc where mathuoc=@mathuoc",CommandType.Text,new SqlParameter("@mathuoc",int.Parse(txt_chonthuoc.EditValue.ToString())));

                if(txt_dvcoban.Checked==true)
                {
                    txt_soluongton.Text = dt.Rows[0]["soluong"].ToString();
                    txt_giaban.Text = dt.Rows[0]["giaban"].ToString();
                }
                else
                {
                    txt_soluongton.Text = dt.Rows[0]["soluongtheodvban"].ToString();
                    txt_giaban.Text = dt.Rows[0]["giabantheodvban"].ToString();
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void txt_dvban_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = SQL.GetData("select * from thuoc where mathuoc=@mathuoc", CommandType.Text, new SqlParameter("@mathuoc", int.Parse(txt_chonthuoc.EditValue.ToString())));

                if (txt_dvcoban.Checked == true)
                {
                    txt_soluongton.Text = dt.Rows[0]["soluong"].ToString();
                    txt_giaban.Text = dt.Rows[0]["giaban"].ToString();
                }
                else
                {
                    txt_soluongton.Text = dt.Rows[0]["soluongtheodvban"].ToString();
                    txt_giaban.Text = dt.Rows[0]["giabantheodvban"].ToString();
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void txt_chonthuoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = SQL.GetData("select * from thuoc where mathuoc=@mathuoc", CommandType.Text, new SqlParameter("@mathuoc", int.Parse(txt_chonthuoc.EditValue.ToString())));
                txt_dvban.Text = dt.Rows[0]["donviban"].ToString();
                txt_dvcoban.Text = dt.Rows[0]["donvicoban"].ToString();
                txt_dvban.Checked = true;
                txt_soluongton.Text = dt.Rows[0]["soluongtheodvban"].ToString();
                txt_giaban.Text = dt.Rows[0]["giabantheodvban"].ToString();
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void txt_soluong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(txt_giaban.EditValue==null||txt_soluong.EditValue==null)
                {
                    return;
                }
                int soluongmua = int.Parse(txt_soluong.EditValue.ToString());
                int giaban = int.Parse(txt_giaban.EditValue.ToString());
                txt_thanhtien.Text = (soluongmua * giaban).ToString();
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void txt_giaban_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_giaban.EditValue == null || txt_soluong.EditValue == null)
                {
                    return;
                }
                int soluongmua = int.Parse(txt_soluong.EditValue.ToString());
                int giaban = int.Parse(txt_giaban.EditValue.ToString());
                txt_thanhtien.Text = (soluongmua * giaban).ToString();
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        public void LoadGridView()
        {
            try
            {
                var dt = SQL.GetData("select a.mathuoc,a.tenthuoc,a.hangsx,a.hamluong,a.hinhanh,b.soluong,b.donvi,b.giabantheodonvi,b.thanhtien from thuoc a,ChiTietHD b,Hoadon c where a.mathuoc=b.mathuoc and b.mahd=c.mahd and c.trangthai='unpaid'", CommandType.Text);
                grd_banthuoc.DataSource = dt;
                int tong=0;
                for(int i=0;i<gv_banthuoc.RowCount;i++)
                {
                    tong = tong+int.Parse(gv_banthuoc.GetRowCellValue(i, gc_thanhtien).ToString());
                }
                txt_tongthanhtien.Text = tong.ToString();
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_chonthuoc.EditValue==null||txt_soluong.EditValue==null||int.Parse(txt_soluong.EditValue.ToString())==0)
                {
                    m.Status(TypeStatus.Error, "Bạn cần nhập đủ thông tin");
                    return;
                }
                if(int.Parse(txt_soluong.EditValue.ToString())>int.Parse(txt_soluongton.EditValue.ToString()))
                {
                    m.Status(TypeStatus.Warning, "Số lượng hàng tồn không đủ đáp ứng");
                    return;
                }
                //Chưa có hóa đơn
                if(SQL.GetData("select * from hoadon where trangthai='unpaid'",CommandType.Text).Rows.Count<=0)
                {
                    int maxMaHD;
                    if (SQL.GetData("select ISNULL(max(mahd),0) from hoadon", CommandType.Text).Rows[0][0].ToString() != "")
                    {
                        var dtrowcout = SQL.GetData("select ISNULL(max(mahd),0) from hoadon", CommandType.Text);
                        maxMaHD = int.Parse(dtrowcout.Rows[0][0].ToString());
                    }
                    else
                    {
                        maxMaHD = 0;
                    }

                    string queryHoaDon = "insert into hoadon values(@mahd,'unpaid',@username,null)";
                    var resulthd = SQL.ExcuteNonquery(queryHoaDon, CommandType.Text, new SqlParameter("@mahd", maxMaHD + 1), new SqlParameter("username", Data.userName));
                    if (resulthd != "")
                    {
                        m.Status(TypeStatus.Error, resulthd);
                        return;
                    }
                    int maxMaCTHD;
                    if (SQL.GetData("select ISNULL(max(macthd),0) from chitiethd", CommandType.Text).Rows[0][0].ToString() != "")
                    {
                        maxMaCTHD = int.Parse(SQL.GetData("select ISNULL(max(macthd),0) from chitiethd", CommandType.Text).Rows[0][0].ToString());
                    }
                    else
                    {
                        maxMaCTHD = 0;
                    }
                    string queryCTHD = "insert into chitiethd values(@macthd,@mahd,@mathuoc,@soluong,@thanhtien,@donvi,@giabantheodonvi)";
                    var lst = new List<SqlParameter>();
                    lst.Add(new SqlParameter("@macthd", maxMaCTHD + 1));
                    lst.Add(new SqlParameter("@mahd", maxMaHD + 1));
                    lst.Add(new SqlParameter("@mathuoc", int.Parse(txt_chonthuoc.EditValue.ToString())));
                    lst.Add(new SqlParameter("@soluong", int.Parse(txt_soluong.EditValue.ToString())));
                    lst.Add(new SqlParameter("@thanhtien", int.Parse(txt_thanhtien.EditValue.ToString())));
                    string donvi;
                    if(txt_dvban.Checked)
                    {
                        donvi = txt_dvban.Text;
                    }
                    else
                    {
                        donvi = txt_dvcoban.Text;
                    }
                    lst.Add(new SqlParameter("@donvi", donvi));
                    lst.Add(new SqlParameter("@giabantheodonvi", int.Parse(txt_giaban.EditValue.ToString())));
                    var resultInsertThuoc = SQL.ExcuteNonquery(queryCTHD, CommandType.Text, lst.ToArray());
                    if(resultInsertThuoc!="")
                    {
                        m.Status(TypeStatus.Error, resultInsertThuoc);
                        return;
                    }
                    
                    if(txt_dvban.Checked)
                    {
                        var dt=SQL.GetData("select * from thuoc where mathuoc=@mathuoc", CommandType.Text, new SqlParameter("mathuoc",int.Parse(txt_chonthuoc.EditValue.ToString())));
                        int gtqd = int.Parse(dt.Rows[0]["giatriquydoi"].ToString());
                        int soluongtheodvbanmoi = int.Parse(txt_soluongton.EditValue.ToString()) - int.Parse(txt_soluong.EditValue.ToString());
                        int soluongtheodonvicobanmoi = int.Parse(dt.Rows[0]["soluong"].ToString()) - gtqd * int.Parse(txt_soluong.EditValue.ToString());
                        string query = "update thuoc set soluong=@soluong,soluongtheodvban=@soluongtheodvban where mathuoc=@mathuoc";
                        var list = new List<SqlParameter>();
                        list.Add(new SqlParameter("@soluong", soluongtheodonvicobanmoi));
                        list.Add(new SqlParameter("@soluongtheodvban", soluongtheodvbanmoi));
                        list.Add(new SqlParameter("@mathuoc", int.Parse(txt_chonthuoc.EditValue.ToString())));
                        var result = SQL.ExcuteNonquery(query, CommandType.Text, list.ToArray());
                        if(result=="")
                        {
                            m.Status(TypeStatus.Success, "Thành Công");
                            LoadGridView();
                        }
                        else
                        {
                            m.Status(TypeStatus.Error, result);
                        }

                        
                    }
                    else
                    {
                        var dt = SQL.GetData("select * from thuoc where mathuoc=@mathuoc", CommandType.Text, new SqlParameter("mathuoc", int.Parse(txt_chonthuoc.EditValue.ToString())));
                        int gtqd = int.Parse(dt.Rows[0]["giatriquydoi"].ToString());
                        int soluongtheodvcobanmoi = int.Parse(txt_soluongton.EditValue.ToString()) - int.Parse(txt_soluong.EditValue.ToString());
                        int soluongtheodvbanmoi = soluongtheodvcobanmoi / gtqd;
                        string query = "update thuoc set soluong=@soluong,soluongtheodvban=@soluongtheodvban where mathuoc=@mathuoc";
                        var list = new List<SqlParameter>();
                        lst.Add(new SqlParameter("@soluong", soluongtheodvcobanmoi));
                        lst.Add(new SqlParameter("@soluongtheodvban", soluongtheodvcobanmoi));
                        lst.Add(new SqlParameter("@mathuoc", int.Parse(txt_chonthuoc.EditValue.ToString())));
                        var result = SQL.ExcuteNonquery(query, CommandType.Text, list.ToArray());
                        if (result == "")
                        {
                            m.Status(TypeStatus.Success, "Thành Công");
                            LoadGridView();
                        }
                        else
                        {
                            m.Status(TypeStatus.Error, result);
                        }
                    }
                }
                //đã có hóa đơn
                else
                {
                    int mahd = int.Parse(SQL.GetData("select ISNULL(max(mahd),0) from hoadon", CommandType.Text).Rows[0][0].ToString());
                    int maxMaCTHD;
                    if (SQL.GetData("select ISNULL(max(macthd),0) from chitiethd", CommandType.Text).Rows[0][0].ToString() != "")
                    {
                        maxMaCTHD = int.Parse(SQL.GetData("select ISNULL(max(macthd),0) from chitiethd", CommandType.Text).Rows[0][0].ToString());
                    }
                    else
                    {
                        maxMaCTHD = 0;
                    }
                    string queryCTHD = "insert into chitiethd values(@macthd,@mahd,@mathuoc,@soluong,@thanhtien,@donvi,@giabantheodonvi)";
                    var lst = new List<SqlParameter>();
                    lst.Add(new SqlParameter("@macthd", maxMaCTHD + 1));
                    lst.Add(new SqlParameter("@mahd", mahd));
                    lst.Add(new SqlParameter("@mathuoc", int.Parse(txt_chonthuoc.EditValue.ToString())));
                    lst.Add(new SqlParameter("@soluong", int.Parse(txt_soluong.EditValue.ToString())));
                    lst.Add(new SqlParameter("@thanhtien", int.Parse(txt_thanhtien.EditValue.ToString())));
                    string donvi;
                    if (txt_dvban.Checked)
                    {
                        donvi = txt_dvban.Text;
                    }
                    else
                    {
                        donvi = txt_dvcoban.Text;
                    }
                    lst.Add(new SqlParameter("@donvi", donvi));
                    lst.Add(new SqlParameter("@giabantheodonvi", int.Parse(txt_giaban.EditValue.ToString())));
                    var resultInsertThuoc = SQL.ExcuteNonquery(queryCTHD, CommandType.Text, lst.ToArray());
                    if (resultInsertThuoc != "")
                    {
                        m.Status(TypeStatus.Error, resultInsertThuoc);
                        return;
                    }
                    if (txt_dvban.Checked)
                    {
                        var dt = SQL.GetData("select * from thuoc where mathuoc=@mathuoc", CommandType.Text, new SqlParameter("mathuoc", int.Parse(txt_chonthuoc.EditValue.ToString())));
                        int gtqd = int.Parse(dt.Rows[0]["giatriquydoi"].ToString());
                        int soluongtheodvbanmoi = int.Parse(txt_soluongton.EditValue.ToString()) - int.Parse(txt_soluong.EditValue.ToString());
                        int soluongtheodonvicobanmoi = int.Parse(dt.Rows[0]["soluong"].ToString()) - gtqd * int.Parse(txt_soluong.EditValue.ToString());
                        string query = "update thuoc set soluong=@soluong,soluongtheodvban=@soluongtheodvban where mathuoc=@mathuoc";
                        var list = new List<SqlParameter>();
                        list.Add(new SqlParameter("@soluong", soluongtheodonvicobanmoi));
                        list.Add(new SqlParameter("@soluongtheodvban", soluongtheodvbanmoi));
                        list.Add(new SqlParameter("@mathuoc", int.Parse(txt_chonthuoc.EditValue.ToString())));
                        var result = SQL.ExcuteNonquery(query, CommandType.Text, list.ToArray());
                        if (result == "")
                        {
                            m.Status(TypeStatus.Success, "Thành Công");
                            LoadGridView();
                        }
                        else
                        {
                            m.Status(TypeStatus.Error, result);
                        }


                    }
                    else
                    {
                        var dt = SQL.GetData("select * from thuoc where mathuoc=@mathuoc", CommandType.Text, new SqlParameter("mathuoc", int.Parse(txt_chonthuoc.EditValue.ToString())));
                        int gtqd = int.Parse(dt.Rows[0]["giatriquydoi"].ToString());
                        int soluongtheodvcobanmoi = int.Parse(txt_soluongton.EditValue.ToString()) - int.Parse(txt_soluong.EditValue.ToString());
                        int soluongtheodvbanmoi = soluongtheodvcobanmoi / gtqd;
                        string query = "update thuoc set soluong=@soluong,soluongtheodvban=@soluongtheodvban where mathuoc=@mathuoc";
                        var list = new List<SqlParameter>();
                        lst.Add(new SqlParameter("@soluong", soluongtheodvcobanmoi));
                        lst.Add(new SqlParameter("@soluongtheodvban", soluongtheodvcobanmoi));
                        lst.Add(new SqlParameter("@mathuoc", int.Parse(txt_chonthuoc.EditValue.ToString())));
                        var result = SQL.ExcuteNonquery(query, CommandType.Text, list.ToArray());
                        if (result == "")
                        {
                            m.Status(TypeStatus.Success, "Thành Công");
                            LoadGridView();
                        }
                        else
                        {
                            m.Status(TypeStatus.Error, result);
                        }
                    }
                }
                

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
                var dlResult = XtraMessageBox.Show("Bạn có muốn thanh toán ?", "Thanh Toán", MessageBoxButtons.YesNo);
                if (dlResult == DialogResult.Yes)
                {
                    ThanhToan();
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        public void ThanhToan()
        {
            int mahd = int.Parse(SQL.GetData("select mahd from hoadon where trangthai='unpaid'", CommandType.Text).Rows[0][0].ToString());
            string query = "update hoadon set trangthai='paid',giothanhtoan=GETDATE() where mahd=@mahd";
            var resultUpdate = SQL.ExcuteNonquery(query, CommandType.Text, new SqlParameter("@mahd", mahd));
            if(resultUpdate=="")
            {
                m.Status(TypeStatus.Success, "Thành Công");
                LoadGridView();
                txt_soluong.EditValue = null;
                txt_thanhtien.EditValue = null;
            }
            else
            {
                m.Status(TypeStatus.Error, resultUpdate);
                return;
            }
            
        }
    }
}
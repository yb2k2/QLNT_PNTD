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
    public partial class ThongTinThuoc : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinThuoc()
        {
            InitializeComponent();
        }
        Main m;

        public ThongTinThuoc(Main m)
        {
            InitializeComponent();
            this.m = m;
        }

        public void LoadData()
        {
            try
            {
                var dt = SQL.GetData("select mathuoc,tenthuoc,hamluong,hangsx from thuoc", CommandType.Text);
                txt_chonthuoc.Properties.DataSource = dt;
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        private void ThongTinThuoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txt_chonthuoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var dt = SQL.GetData("select * from thuoc where mathuoc=@mathuoc", CommandType.Text, new SqlParameter("@mathuoc", int.Parse(txt_chonthuoc.EditValue.ToString())));
                txt_dvban.Text = dt.Rows[0]["donviban"].ToString();
                txt_dvcoban.Text = dt.Rows[0]["donvicoban"].ToString();
                txt_giabandvban.Text = dt.Rows[0]["giabantheodvban"].ToString();
                txt_giabandvcoban.Text = dt.Rows[0]["giaban"].ToString();
                txt_giatriquydoi.Text = dt.Rows[0]["giatriquydoi"].ToString();
                txt_hamluong.Text = dt.Rows[0]["hamluong"].ToString();
                txt_hangsx.Text = dt.Rows[0]["hangsx"].ToString();
                txt_hsd.Text = dt.Rows[0]["hansd"].ToString();
                txt_loaithuoc.Text = SQL.GetData("select tenlt from loaithuoc where malt=@malt", CommandType.Text, new SqlParameter("@malt", dt.Rows[0]["malt"].ToString())).Rows[0][0].ToString();
                txt_mota.Text = dt.Rows[0]["mota"].ToString();
                txt_ncc.Text=SQL.GetData("select tenncc from nhacungcap where mancc=@mancc",CommandType.Text,new SqlParameter("@mancc",dt.Rows[0]["mancc"].ToString())).Rows[0][0].ToString();
                
                txt_quycachdonggoi.Text = dt.Rows[0]["quycachdonggoi"].ToString();
                txt_sldvban.Text = dt.Rows[0]["soluongtheodvban"].ToString();
                txt_sldvcoban.Text = dt.Rows[0]["soluong"].ToString();
                pic_hinhanh.EditValue = dt.Rows[0]["hinhanh"];
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
                this.Close();
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
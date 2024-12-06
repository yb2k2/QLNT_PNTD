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
    public partial class NhapHang : DevExpress.XtraEditors.XtraForm
    {
        public NhapHang()
        {
            InitializeComponent();
        }
        Main m;
        public NhapHang(Main m)
        {
            InitializeComponent();
            this.m = m;
        }
        public void LoadData()
        {
            try
            {
                var query = @"select mathuoc,tenthuoc,hamluong,hangsx,soluongtheodvban from Thuoc";
                var dt = SQL.GetData(query, CommandType.Text);
                txt_ThuocTrongKho.Properties.DataSource = dt;
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        private void NhapHang_Load(object sender, EventArgs e)
        {
            LoadData();
            var img = Image.FromFile(@"Item//noimage.png");
            var byteImage = Data.ConvertImageToByte(img);
            pic_newHinhAnh.EditValue = byteImage;
            var dtlt = SQL.GetData("select malt,tenlt from loaithuoc", CommandType.Text);
            txt_newLoaiThuoc.Properties.DataSource = dtlt;
            var dtncc = SQL.GetData("select mancc,tenncc from nhacungcap", CommandType.Text);
            txt_newNhaCC.Properties.DataSource = dtncc;
        }

        private void txt_ThuocTrongKho_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var query = @"select * from thuoc where mathuoc=@mathuoc";
                var dt = SQL.GetData(query, CommandType.Text, new SqlParameter("@mathuoc", int.Parse(txt_ThuocTrongKho.EditValue.ToString())));
                txt_hamluong.Text = dt.Rows[0]["hamluong"].ToString();
                txt_hansd.Text = dt.Rows[0]["hansd"].ToString();
                txt_hangsx.Text = dt.Rows[0]["hangsx"].ToString();
                txt_quycach.Text = dt.Rows[0]["quycachdonggoi"].ToString();
                txt_donvicoban.Text = dt.Rows[0]["donvicoban"].ToString();
                txt_giabantheodvcoban.Text = dt.Rows[0]["giaban"].ToString();
                var query2 = @"select tenlt from loaithuoc where malt=@malt";
                var dtlt = SQL.GetData(query2, CommandType.Text, new SqlParameter("@malt", int.Parse(dt.Rows[0]["malt"].ToString())));
                txt_loaithuoc.Text = dtlt.Rows[0][0].ToString();
                pic_hinhanh.EditValue = dt.Rows[0]["hinhanh"];
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void txt_soluongnhap_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(txt_soluongnhap.EditValue ==null||txt_tilequydoi.EditValue==null||txt_gianhap.EditValue==null)
                {
                    return;
                }
                txt_thanhtien.EditValue = (int.Parse(txt_gianhap.EditValue.ToString())) * (int.Parse(txt_soluongnhap.EditValue.ToString())) * (int.Parse(txt_tilequydoi.EditValue.ToString()));
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void txt_tilequydoi_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_soluongnhap.EditValue == null || txt_tilequydoi.EditValue == null || txt_gianhap.EditValue == null)
                {
                    return;
                }
                txt_thanhtien.EditValue = (int.Parse(txt_gianhap.EditValue.ToString())) * (int.Parse(txt_soluongnhap.EditValue.ToString())) * (int.Parse(txt_tilequydoi.EditValue.ToString()));
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void txt_gianhap_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_soluongnhap.EditValue == null || txt_tilequydoi.EditValue == null || txt_gianhap.EditValue == null)
                {
                    return;
                }
                txt_thanhtien.EditValue = (int.Parse(txt_gianhap.EditValue.ToString())) * (int.Parse(txt_soluongnhap.EditValue.ToString())) * (int.Parse(txt_tilequydoi.EditValue.ToString()));
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
                if(txt_ThuocTrongKho.EditValue==null||txt_donvinhap.EditValue==null||txt_tilequydoi.EditValue==null||txt_soluongnhap.EditValue==null||txt_gianhap.EditValue==null)
                {
                    m.Status(TypeStatus.Error, "Bạn Chưa Nhập Đầy Đủ Thông Tin");
                    return;
                }
                int maxMaNhapHang;
                var dt = SQL.GetData("select ISNULL(max(manhaphang),0) from nhaphang", CommandType.Text);
                if(dt.Rows.Count>0)
                {
                    maxMaNhapHang = int.Parse(dt.Rows[0][0].ToString());
                }
                else
                {
                    maxMaNhapHang = 0;
                }
                
                int maThuoc = int.Parse(txt_ThuocTrongKho.EditValue.ToString());
                int giaTriQuyDoi = int.Parse(txt_tilequydoi.EditValue.ToString());
                int soLuongNhap = int.Parse(txt_soluongnhap.EditValue.ToString());
                int giaNhap = int.Parse(txt_gianhap.EditValue.ToString());
                string donViNhap=txt_donvinhap.Text;
                string mota = txt_mota.Text;
                int thanhTien = int.Parse(txt_thanhtien.EditValue.ToString());
                string query = @"insert into nhaphang values(@manhaphang,@mathuoc,@donvinhap,@giatriquydoi,@soluongnhap,@gianhap,@mota,GETDATE(),@thanhtien,@username)";
                var lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@manhaphang", maxMaNhapHang + 1));
                lst.Add(new SqlParameter("@mathuoc", maThuoc));
                lst.Add(new SqlParameter("@donvinhap", donViNhap));
                lst.Add(new SqlParameter("@giatriquydoi", giaTriQuyDoi));
                lst.Add(new SqlParameter("@soluongnhap", soLuongNhap));
                lst.Add(new SqlParameter("@gianhap", giaNhap));
                lst.Add(new SqlParameter("@mota", mota));
                lst.Add(new SqlParameter("@thanhtien", thanhTien));
                lst.Add(new SqlParameter("@username", Data.userName));
                var resultNhapHang = SQL.ExcuteNonquery(query, CommandType.Text, lst.ToArray());
                if (resultNhapHang!="")
                {
                    m.Status(TypeStatus.Error, resultNhapHang);
                    return;
                }
                int soLuongCu=int.Parse(SQL.GetData(@"select soluong from thuoc where mathuoc=@mathuoc",CommandType.Text,new SqlParameter("@mathuoc",maThuoc)).Rows[0][0].ToString());

                int soLuongMoi=soLuongNhap*giaTriQuyDoi+soLuongCu;
                int soluongTheoDvBanMoi = soLuongMoi / giaTriQuyDoi;
                string queryUpdateThuoc = @"update thuoc set soluong=@soluong,soluongtheodvban=@soluongtheodvban where mathuoc=@mathuoc";
                var result = SQL.ExcuteNonquery(queryUpdateThuoc, CommandType.Text, new SqlParameter("@soluong", soLuongMoi), new SqlParameter("@mathuoc", maThuoc),new SqlParameter("@soluongtheodvban",soluongTheoDvBanMoi));

                if (result == "")
                {
                    m.Status(TypeStatus.Success, "Thành Công");
                }
                else
                {
                    m.Status(TypeStatus.Error, result);
                    return;
                }

            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void txt_newSoLuong_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_newSoLuong.EditValue == null || txt_newTiLeQuyDoi.EditValue == null || txt_newGiaNhap.EditValue == null)
                {
                    return;
                }
                txt_newThanhTien.EditValue = (int.Parse(txt_newGiaNhap.EditValue.ToString())) * (int.Parse(txt_newSoLuong.EditValue.ToString())) * (int.Parse(txt_newTiLeQuyDoi.EditValue.ToString()));
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void txt_newTiLeQuyDoi_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_newSoLuong.EditValue == null || txt_newTiLeQuyDoi.EditValue == null || txt_newGiaNhap.EditValue == null)
                {
                    return;
                }
                txt_newThanhTien.EditValue = (int.Parse(txt_newGiaNhap.EditValue.ToString())) * (int.Parse(txt_newSoLuong.EditValue.ToString())) * (int.Parse(txt_newTiLeQuyDoi.EditValue.ToString()));
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void txt_newGiaNhap_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_newSoLuong.EditValue == null || txt_newTiLeQuyDoi.EditValue == null || txt_newGiaNhap.EditValue == null)
                {
                    return;
                }
                txt_newThanhTien.EditValue = (int.Parse(txt_newGiaNhap.EditValue.ToString())) * (int.Parse(txt_newSoLuong.EditValue.ToString())) * (int.Parse(txt_newTiLeQuyDoi.EditValue.ToString()));
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
                if(txt_newTenThuoc.EditValue==null||txt_newNhaCC.EditValue==null||txt_newLoaiThuoc.EditValue==null||txt_newDonViCoBan.EditValue==null||txt_newQuyCachDongGoi.EditValue==null||txt_newGiaBan.EditValue==null||txt_newHSD.EditValue==null||txt_newDonViBan.EditValue==null||txt_newGiaTriQuyDoi.EditValue==null||txt_newSoLuong.EditValue==null||txt_newDonViNhap.EditValue==null||txt_newTiLeQuyDoi.EditValue==null||txt_newGiaNhap.EditValue==null||txt_newThanhTien.EditValue==null)
                {
                    m.Status(TypeStatus.Error, "Bạn Chưa Nhập Đầy Đủ Thông Tin");
                    return;
                }
                int maxMaNhapHang;
                var dt = SQL.GetData("select ISNULL(max(manhaphang),0) from nhaphang", CommandType.Text);
                if (dt.Rows.Count > 0)
                {
                    maxMaNhapHang = int.Parse(dt.Rows[0][0].ToString());
                }
                else
                {
                    maxMaNhapHang = 0;
                }
                int maxMaThuoc;
                var dtThuoc = SQL.GetData("select ISNULL(max(mathuoc),0) from thuoc", CommandType.Text);
                if(dtThuoc.Rows.Count>0)
                {
                    maxMaThuoc = int.Parse(dtThuoc.Rows[0][0].ToString());
                }
                else
                {
                    maxMaThuoc = 0;
                }

                string tenThuoc = txt_newTenThuoc.Text;
                int malt = int.Parse(txt_newLoaiThuoc.EditValue.ToString());
                int mancc = int.Parse(txt_newNhaCC.EditValue.ToString());
                string hamLuong = txt_newHamLuong.Text;
                string quyCachDongGoi = txt_newQuyCachDongGoi.Text;
                string hangSX = txt_newHangSX.Text;
                string dvCoBan = txt_newDonViCoBan.Text;
                int soLuong = int.Parse(txt_newSoLuong.EditValue.ToString());
                int giaBan = int.Parse(txt_newGiaBan.EditValue.ToString());
                string mota = txt_newMota.Text;
                string donViBan = txt_newDonViBan.Text;
                int giaTriQuyDoi = int.Parse(txt_newGiaTriQuyDoi.EditValue.ToString());
                string donViNhap = txt_newDonViNhap.Text;
                int tiLe = int.Parse(txt_newTiLeQuyDoi.EditValue.ToString());
                int giaNhap = int.Parse(txt_newGiaNhap.EditValue.ToString());
                string ghiChu = txt_newGhiChu.Text;
                var hsd = txt_newHSD.EditValue;
                var byteArr = Data.ConvertImageToByte(pic_newHinhAnh.Image);
                int thanhTien = int.Parse(txt_newThanhTien.EditValue.ToString());
                int giaBanTheoDVBan = giaBan * giaTriQuyDoi;
                int soluongtheodvban=(soLuong*tiLe)/giaTriQuyDoi;
                string queryInsertThuoc = @"insert into Thuoc values(@mathuoc,@malt,@mancc,@tenthuoc,@hamluong,@quycachdonggoi,@hangsx,@donvicoban,@soluong,@giaban,@mota,@hinhanh,@hansd,@donviban,@giatriquydoi,@giabantheodvban,@soluongtheodvban)";
                var lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@mathuoc", maxMaThuoc + 1));
                lst.Add(new SqlParameter("@malt", malt));
                lst.Add(new SqlParameter("@mancc", mancc));
                lst.Add(new SqlParameter("@tenthuoc", tenThuoc));
                lst.Add(new SqlParameter("@hamluong", hamLuong));
                lst.Add(new SqlParameter("@quycachdonggoi", quyCachDongGoi));

                lst.Add(new SqlParameter("@hangsx", hangSX));
                lst.Add(new SqlParameter("@donvicoban",dvCoBan ));
                lst.Add(new SqlParameter("@soluong", soLuong*tiLe));
                lst.Add(new SqlParameter("@giaban", giaBan));
                lst.Add(new SqlParameter("@mota", mota));
                lst.Add(new SqlParameter("@hinhanh", byteArr));
                lst.Add(new SqlParameter("@hansd", hsd));
                lst.Add(new SqlParameter("@donviban", donViBan));
                lst.Add(new SqlParameter("@giatriquydoi", giaTriQuyDoi));
                lst.Add(new SqlParameter("@giabantheodvban", giaBanTheoDVBan));
                lst.Add(new SqlParameter("@soluongtheodvban", soluongtheodvban));
                var resultThemThuoc = SQL.ExcuteNonquery(queryInsertThuoc, CommandType.Text, lst.ToArray());
                if(resultThemThuoc!="")
                {
                    m.Status(TypeStatus.Error, resultThemThuoc);
                    return;
                }

                string queryInsertNhapHang = @"insert into NhapHang values(@manhaphang,@mathuoc,@donvinhap,@giatriquydoi,@soluongnhap,@gianhap,@mota,GETDATE(),@thanhtien,@username)";
                var lstNhap = new List<SqlParameter>();
                lstNhap.Add(new SqlParameter("@manhaphang", maxMaNhapHang + 1));
                lstNhap.Add(new SqlParameter("@mathuoc", maxMaThuoc + 1));
                lstNhap.Add(new SqlParameter("@donvinhap", donViNhap));
                lstNhap.Add(new SqlParameter("@giatriquydoi", giaTriQuyDoi));
                lstNhap.Add(new SqlParameter("@soluongnhap", soLuong));
                lstNhap.Add(new SqlParameter("@gianhap", giaNhap));
                lstNhap.Add(new SqlParameter("@mota", ghiChu));
                lstNhap.Add(new SqlParameter("@thanhtien", thanhTien));
                lstNhap.Add(new SqlParameter("@username", Data.userName));
                var result = SQL.ExcuteNonquery(queryInsertNhapHang, CommandType.Text, lstNhap.ToArray());
                if (result == "")
                {
                    m.Status(TypeStatus.Success, "Thành Công");
                }
                else
                {
                    m.Status(TypeStatus.Error, result);
                    return;
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void pic_newHinhAnh_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Image img = Data.SelectImageFromFile();
                var byteImage = Data.ConvertImageToByte(img);
                pic_newHinhAnh.Image = img;
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

        private void simpleButton3_Click(object sender, EventArgs e)
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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(xtraTabControl1.SelectedTabPage==xtraTabPage1)
                {
                    foreach (Control control in xtraTabPage1.Controls)
                    {
                        if (control is TextEdit)
                        {
                            TextEdit textBox = (TextEdit)control;
                            textBox.EditValue = null;
                        }

                        if (control is DevExpress.XtraEditors.ComboBox)
                        {
                            DevExpress.XtraEditors.ComboBox comboBox = (DevExpress.XtraEditors.ComboBox)control;
                            if (comboBox.Properties.Items.Count > 0)
                                comboBox.SelectedIndex = 0;
                        }


                        if (control is SearchLookUpEdit)
                        {
                            SearchLookUpEdit l = (SearchLookUpEdit)control;
                            l.EditValue = null;
                        }
                        if (control is DateEdit)
                        {
                            DateEdit d = (DateEdit)control;
                            d.EditValue = null;
                        }
                        if (control is CalcEdit)
                        {
                            CalcEdit c = (CalcEdit)control;
                            c.EditValue = null;
                        }
                    }
                }
                else if (xtraTabControl1.SelectedTabPage == xtraTabPage2)
                {
                    foreach (Control control in xtraTabPage2.Controls)
                    {
                        if (control is TextEdit)
                        {
                            TextEdit textBox = (TextEdit)control;
                            textBox.EditValue = null;
                        }

                        if (control is DevExpress.XtraEditors.ComboBox)
                        {
                            DevExpress.XtraEditors.ComboBox comboBox = (DevExpress.XtraEditors.ComboBox)control;
                            if (comboBox.Properties.Items.Count > 0)
                                comboBox.SelectedIndex = 0;
                        }

                    
                        if(control is SearchLookUpEdit)
                        {
                            SearchLookUpEdit l = (SearchLookUpEdit)control;
                            l.EditValue = null;
                        }
                        if(control is DateEdit)
                        {
                            DateEdit d = (DateEdit)control;
                            d.EditValue = null;
                        }
                        if(control is CalcEdit)
                        {
                            CalcEdit c = (CalcEdit)control;
                            c.EditValue = null;
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
    }
}
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
    public partial class ThongTinTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public ThongTinTaiKhoan()
        {
            InitializeComponent();
        }
        Main m;
        public ThongTinTaiKhoan(Main m)
        {
            InitializeComponent();
            this.m = m;
        }
        public void LoadData()
        {
            try
            {
                txt_username.Text = Data.userName;
                string query = @"select * from nhanvien where username=@username";
                var dt = SQL.GetData(query, CommandType.Text, new SqlParameter("@username", Data.userName));
                txt_password.Text = dt.Rows[0]["password"].ToString();
                txt_hoten.Text = dt.Rows[0]["hoten"].ToString();
                if (dt.Rows[0]["ngaysinh"].ToString() == "")
                {
                    txt_ngaysinh.EditValue = DBNull.Value;
                }
                else
                {
                    txt_ngaysinh.EditValue = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
                }
                txt_diachi.Text = dt.Rows[0]["diachi"].ToString();
                List<string> lst_gioitinh = new List<string>() { "Nam", "Nữ" };
                txt_gioitinh.Properties.Items.AddRange(lst_gioitinh);
                txt_gioitinh.Text = dt.Rows[0]["gioitinh"].ToString();
                pic_hinhanh.EditValue = dt.Rows[0]["hinhanh"];
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pic_hinhanh_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Image img = Data.SelectImageFromFile();
                var byteImage = Data.ConvertImageToByte(img);
                pic_hinhanh.Image = img;
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                TextEdit edit = sender as TextEdit;
                if (edit.IsModified)
                {
                    txt_password.Text = Data.MaHoaMD5(txt_password.Text);
                }
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

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"update nhanvien set hoten=@hoten,ngaysinh=@ngaysinh,password=@password,hinhanh=@hinhanh,gioitinh=@gioitinh,diachi=@diachi where username=@username";
                List<SqlParameter> lst = new List<SqlParameter>();
                lst.Add(new SqlParameter("@username", Data.userName));
                lst.Add(new SqlParameter("@password", txt_password.Text));
                lst.Add(new SqlParameter("@hoten", txt_hoten.Text));
                if (txt_ngaysinh.EditValue != null)
                {
                    lst.Add(new SqlParameter("@ngaysinh", txt_ngaysinh.EditValue));
                }
                else
                {
                    lst.Add(new SqlParameter("@ngaysinh", DBNull.Value));
                }
                lst.Add(new SqlParameter("@gioitinh", txt_gioitinh.Text));
                if (pic_hinhanh.Image != null)
                {
                    var byteArr = Data.ConvertImageToByte(pic_hinhanh.Image);
                    lst.Add(new SqlParameter("@hinhanh", byteArr));
                }
                else
                {
                    lst.Add(new SqlParameter("@hinhanh", null));
                }
                lst.Add(new SqlParameter("@diachi", txt_diachi.Text));
                var result = SQL.ExcuteNonquery(query, CommandType.Text, lst.ToArray());
                if (result == "")
                {
                    m.Status(TypeStatus.Success, "Thành Công");
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
    }
}
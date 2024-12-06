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
    public partial class QLNV : DevExpress.XtraEditors.XtraForm
    {
        Main m;
        public QLNV()
        {
            InitializeComponent();
        }
        public QLNV(Main m)
        {
            InitializeComponent();
            this.m = m;
        }
        private void QLNV_Load(object sender, EventArgs e)
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
        public void LoadData()
        {
            try
            {
                
                List<string> lst_gioitinh = new List<string>() { "Nam", "Nữ" };
                List<string> lst_chucvu = new List<string>() { "admin", "Nhân Viên" };
                txt_chucvu.Items.Clear();
                txt_gioitinh.Items.Clear();
                txt_chucvu.Items.AddRange(lst_chucvu);
                txt_gioitinh.Items.AddRange(lst_gioitinh);
                var dt = SQL.GetData(@"select * from NhanVien", CommandType.Text);
                grd_qlnv.DataSource = dt;
                gv_qlnv.ClearColumnsFilter();
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        public Image SelectImageFromFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            open.FilterIndex = 1;
            open.RestoreDirectory = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                return Image.FromFile(open.FileName);
            }
            return null;
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            try
            {
                var txt_pass = (TextEdit)sender;
                txt_pass.Text = Data.MaHoaMD5(txt_pass.Text);

            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void pic_hinhanh_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Image img = SelectImageFromFile();
                var byteImage = Data.ConvertImageToByte(img);
                gv_qlnv.SetRowCellValue(gv_qlnv.FocusedRowHandle, gc_hinhanh, byteImage);
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
                var dt = grd_qlnv.DataSource as DataTable;
                const string tempTB = @"#NhanVien";
                SQL.CreateTempTable3(dt.Copy(), "NhanVien", tempTB);
                const string sql = @"delete from NhanVien insert into NhanVien select * from #NhanVien";
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

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Them();
        }
        public void Them()
        {
            try
            {
                var dt = grd_qlnv.DataSource as DataTable;
                var row = dt.NewRow();
                row["gioitinh"] = "Nam";
                var img = Image.FromFile(@"Item//noimage.png");
                var byteImage = Data.ConvertImageToByte(img);
                row["hinhanh"] = byteImage;
                row["chucvu"] = "Nhân Viên";
                dt.Rows.Add(row);
                grd_qlnv.DataSource = dt;

            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }
        public void Xoa()
        {
            try
            {
                var username_delete = gv_qlnv.GetFocusedRowCellValue(gc_username.FieldName);
                var query = "delete from nhanvien where username=@username";
                var result = SQL.ExcuteNonquery(query, CommandType.Text, new SqlParameter(@"username", username_delete.ToString()));
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
                var username_delete = gv_qlnv.GetFocusedRowCellValue(gc_username.FieldName);
                var dlResult = XtraMessageBox.Show("Bạn có muốn xóa nhân viên "+username_delete.ToString()+" ?", "Xóa", MessageBoxButtons.YesNo);
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
                if (gv_qlnv.IsFindPanelVisible == false)
                {
                    gv_qlnv.ShowFindPanel();
                }
            }
            catch (Exception ex)
            {
                m.Status(TypeStatus.Error, ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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
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
using System.Data.SqlClient;
using QLNT.Global;

namespace QLNT
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        Main main = new Main();
        public Login()
        {
            InitializeComponent();
        }

        private void cb_HienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_HienThiMatKhau.Checked == true)
                {
                    txt_MatKhau.Properties.UseSystemPasswordChar = false;
                }
                else
                {
                    txt_MatKhau.Properties.UseSystemPasswordChar = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_TenDangNhap.Text == "")
                {
                    MessageBox.Show("Tên Đăng Nhập Trống");
                    return;
                }
                if (txt_MatKhau.Text == "")
                {
                    MessageBox.Show("Mật Khẩu Trống");
                    return;
                }

                string username = txt_TenDangNhap.Text;
                string password = txt_MatKhau.Text;  // Không mã hóa mật khẩu

                string query = "SELECT * FROM NhanVien WHERE Username=@username AND password=@password";
                var dtKQ = SQL.GetData(query, CommandType.Text, new SqlParameter("@username", username), new SqlParameter("@password", password));

                if (dtKQ.Rows.Count > 0)
                {
                    Data.userName = dtKQ.Rows[0]["username"].ToString();
                    Data.chucvu = dtKQ.Rows[0]["chucvu"].ToString();

                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCirculer1_Click(object sender, EventArgs e)
        {
            var dlResult = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo);
            if (dlResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
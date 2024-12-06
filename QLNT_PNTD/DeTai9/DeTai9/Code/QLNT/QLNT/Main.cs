using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QLNT.Global;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;

namespace QLNT
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {

                if (Data.chucvu != "admin")
                {
                    ribbonPage_Quanly.Visible = false;
                }
                timerDateTime.Start();
                txt_Username.Caption = "User : " + Data.userName;
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }
        public void Status(TypeStatus type, string message)
        {
            timerStatus.Interval = 10000;
            var apperance = txt_Status.ItemAppearance.Normal;
            switch (type)
            {
                case TypeStatus.Error: apperance.BackColor = Color.Red;
                    apperance.ForeColor = Color.White;
                    break;
                case TypeStatus.Success: apperance.BackColor = Color.Green;
                    apperance.ForeColor = Color.White;
                    break;
                case TypeStatus.Warning: apperance.BackColor = Color.Yellow;
                    break;
            }
            txt_Status.Caption = message;
            txt_Status.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            timerStatus.Start();
        }
        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            timerDateTime.Interval = 1000;
            txt_Time.Caption = DateTime.Now.ToString();
        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            try
            {
                txt_Status.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                timerStatus.Stop();
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }
        private void CreateForm(XtraForm form)
        {
            try
            {
                for (int i = 0; i < tab_main.TabPages.Count; i++)
                {
                    if (tab_main.TabPages[i].Name == form.Name)
                    {
                        tab_main.SelectedTabPage = tab_main.TabPages[i];

                        return;
                    }
                }
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                if (AddNewTabPage(form))
                {
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }
        public bool ExistsFormInTabpage(XtraForm form)
        {
            try
            {
                foreach (XtraTabPage tp in tab_main.TabPages)
                {
                    if (tp.Name == form.Name)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
                return false;
            }
        }
        public bool AddNewTabPage(XtraForm form)
        {
            try
            {
                if (ExistsFormInTabpage(form))
                {
                    return false;
                }
                XtraTabPage tpage = new XtraTabPage();
                tpage.Name = form.Name;
                tpage.Text = form.Text;
                tpage.BorderStyle = BorderStyle.None;
                tpage.BackColor = Color.Transparent;
                tab_main.TabPages.Add(tpage);
                tab_main.SelectedTabPage = tpage;
                tab_main.Visible = tab_main.TabPages.Count > 0;
                return true;
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
                return false;
            }
        }

        private void tab_main_CloseButtonClick(object sender, EventArgs e)
        {
            try
            {
                var arg = e as ClosePageButtonEventArgs;
                var tab = arg.Page as XtraTabPage;
                var form = Application.OpenForms[tab.Name];
                form.Close();
                tab_main.TabPages.Remove(tab);
                tab_main.Visible = tab_main.TabPages.Count > 0;
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void tab_main_Click(object sender, EventArgs e)
        {
            try
            {
                if (tab_main.SelectedTabPage == null)
                    return;
                var nameTabCurrent = tab_main.SelectedTabPage.Name;
                var form = Application.OpenForms[nameTabCurrent];
                form.Focus();
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void Main_MdiChildActivate(object sender, EventArgs e)
        {
            try
            {
                var form = this.ActiveMdiChild;
                if (form == null)
                {
                    return;
                }
                form.FormClosed += ChildForm_FormClosed;
                foreach (XtraTabPage tab in tab_main.TabPages)
                {
                    if (tab.Name == form.Name)
                    {
                        tab_main.SelectedTabPage = tab;
                    }
                }
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var form = sender as XtraForm;
                if (form != null)
                {
                    tab_main.TabPages.Remove(tab_main.TabPages.FirstOrDefault(t => t.Name == form.Name), true);
                }
                tab_main.Visible = tab_main.TabPages.Count > 0;
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                QLNV nv = new QLNV(this);
                CreateForm(nv);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                QLNCC nv = new QLNCC(this);
                CreateForm(nv);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void tab_main_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            try
            {
                if (tab_main.SelectedTabPage == null)
                    return;
                var nameTabCurrent = tab_main.SelectedTabPage.Name;
                var form = Application.OpenForms[nameTabCurrent];
                if (form == null)
                {
                    return;
                }
                form.Focus();
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                QLLoaiThuoc nv = new QLLoaiThuoc(this);
                CreateForm(nv);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                QlThuoc thuoc = new QlThuoc(this);
                CreateForm(thuoc);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                NhapHang nhap = new NhapHang(this);
                CreateForm(nhap);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var dlResult = XtraMessageBox.Show("Bạn có muốn đăng xuất không ?", "Đăng Xuất", MessageBoxButtons.YesNo);
                if (dlResult == DialogResult.Yes)
                {
                    Login lg = new Login();
                    lg.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ThongTinTaiKhoan tt = new ThongTinTaiKhoan(this);
                CreateForm(tt);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ThongTinThuoc tt = new ThongTinThuoc(this);
                CreateForm(tt);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                BanHang b = new BanHang(this);
                CreateForm(b);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.traphaco.com.vn/");
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {

            System.Diagnostics.Process.Start("https://www.facebook.com/duydeptrai.dethuong");
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                NhapHang nh = new NhapHang(this);
                CreateForm(nh);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.ProcessStartInfo st = new System.Diagnostics.ProcessStartInfo();
            st.FileName = "WINWORD.EXE";
            System.Diagnostics.Process.Start(st);
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\calc.exe");
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\notepad.exe");
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ThongKeNhapThuoc tk = new ThongKeNhapThuoc(this);
                CreateForm(tk);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Thống_Kê_Bán_Hàng tk = new Thống_Kê_Bán_Hàng(this);
                CreateForm(tk);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            var dlResult = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo);
            if (dlResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                TroGiup t = new TroGiup();
                CreateForm(t);
            }
            catch (Exception ex)
            {
                Status(TypeStatus.Error, ex.Message);
            }
        }
    }
}
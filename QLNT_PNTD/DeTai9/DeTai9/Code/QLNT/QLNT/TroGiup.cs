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
    public partial class TroGiup : DevExpress.XtraEditors.XtraForm
    {
        Main m;
        public TroGiup()
        {
            InitializeComponent();
        }
        public TroGiup(Main m)
        {
            InitializeComponent();
            this.m = m;
        }
        private void TroGiup_Load(object sender, EventArgs e)
        {
            
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
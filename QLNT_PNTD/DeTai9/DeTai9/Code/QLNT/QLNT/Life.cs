using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    public partial class Life : Form
    {
        public Life()
        {
            InitializeComponent();
            Login frmlogin = new Login();
            frmlogin.Show();
            //this.Visible = false;
            Opacity = 0;
            ShowInTaskbar = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    public partial class ButtonCirculer : Button
    {
        public ButtonCirculer()
        {
            InitializeComponent();
        }

        public ButtonCirculer(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0,0,ClientSize.Width,ClientSize.Height);
            this.Region =new System.Drawing.Region(g);
            base.OnPaint(pevent);
        }
    }
}

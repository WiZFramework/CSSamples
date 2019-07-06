using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawShape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point[] ps = {
                 new Point(20, 20),
                 new Point(220, 20),
                 new Point(220, 220),
                 new Point(20, 220),
                 new Point(20, 20)
             };
            Graphics g = this.CreateGraphics();
            g.DrawLines(Pens.Black, ps);
            g.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawEllipse(Pens.Black, 240, 20, 200, 200);
            g.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Point centerTop = new Point(560, 20);
            Point centerBottom = new Point(560, 220);
            int spanX = (int)(200 / 1.7320508); 
            Point leftBottom = new Point(560 - spanX, centerBottom.Y);
            Point rightBottom = new Point(560 + spanX, centerBottom.Y);
            Point[] ps = {
                centerTop,
                leftBottom,
                rightBottom,
                centerTop
            };
            Graphics g = this.CreateGraphics();
            g.DrawLines(Pens.Black, ps);
            g.Dispose();
        }
    }
}

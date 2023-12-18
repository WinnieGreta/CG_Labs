using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            Paint += AboutForm_Paint;
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.GreenYellow, 2);

            g.DrawLine(myPen, 20, 130, 60, 130);
            g.DrawLine(myPen, 40, 130, 40, 170);
            g.DrawLine(myPen, 60, 145, 60, 200);
            g.DrawCurve(myPen, new Point[] { new Point(60, 145), new Point(70, 145), new Point(75, 155), new Point(70, 165), new Point(60, 165) });
            g.DrawCurve(myPen, new Point[] { new Point(80, 145), new Point(83, 160), new Point(90, 165) });
            g.DrawCurve(myPen, new Point[] { new Point(100, 145), new Point(90, 165), new Point(85, 190), new Point(80, 200), new Point(75, 195) });
            g.DrawCurve(myPen, new Point[] { new Point(110, 145), new Point(110, 165), new Point(120, 165), new Point(120, 145), new Point(120, 165), 
                new Point(130, 165), new Point(130, 145), new Point(130, 165), new Point(135, 165), new Point(137, 175), new Point(133, 175), 
                new Point(135, 165), new Point(140, 165) });
            g.DrawCurve(myPen, new Point[] { new Point(160, 145), new Point(145, 145), new Point(145, 165), new Point(155, 165), new Point(160, 145), 
                new Point(160, 165), new Point (165, 165) });
            g.DrawLine(myPen, 170, 145, 170, 170);
            g.DrawLine(myPen, 170, 145, 170, 170);
            g.DrawLine(myPen, 180, 145, 170, 155);
            g.DrawLine(myPen, 180, 170, 170, 155);

        }
    }
}

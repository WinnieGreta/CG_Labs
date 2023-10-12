using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        Graphics g;

        int x1 = 0;
        int y1 = 0;
        int x2 = 80;
        int y2 = 80;

        Bitmap mypic;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point t1 = new Point(x1, y1);
            Point t2 = new Point(x1, y2);
            Point t3 = new Point(x2, y2);
            Point t4 = new Point(x2, y1);

            mypic = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = mypic;
            g = Graphics.FromImage(mypic);
            g.DrawPolygon(new Pen(Color.BurlyWood, 5), new Point[] { t1, t2, t3, t4 });

        }
    }
}

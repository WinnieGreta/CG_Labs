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

        int x1 = 20;
        int y1 = 20;
        int x2 = 200;
        int y2 = 20;
        int x3 = 200;
        int y3 = 200;
        int x4 = 20;
        int y4 = 200;

        Bitmap mypic;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point t1 = new Point(x1, y1);
            Point t2 = new Point(x2, y2);
            Point t3 = new Point(x3, y3);
            Point t4 = new Point(x4, y4);

            mypic = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = mypic;
            g = Graphics.FromImage(mypic);
            g.DrawPolygon(new Pen(Color.BurlyWood, 2), new Point[] { t1, t2, t3, t4 });

            float p = 0.08f;

            for (int i = 0; i < 50; i++)
            {
                float x1new = x1 + (x2 - x1) * p;
                float y1new = y1 + (y2 - y1) * p;
                float x2new = x2 + (x3 - x2) * p;
                float y2new = y2 + (y3 - y2) * p;
                float x3new = x3 + (x4 - x3) * p;
                float y3new = y3 + (y4 - y3) * p;
                float x4new = x4 + (x1 - x4) * p;
                float y4new = y4 + (y1 - y4) * p;

                x1 = (int)x1new;
                y1 = (int)y1new;
                x2 = (int)x2new;
                y2 = (int)y2new;
                x3 = (int)x3new;
                y3 = (int)y3new;
                x4 = (int)x4new;
                y4 = (int)y4new;

                Point t1new = new Point(x1, y1);
                Point t2new = new Point(x2, y2);
                Point t3new = new Point(x3, y3);
                Point t4new = new Point(x4, y4);

                g.DrawPolygon(new Pen(Color.BurlyWood, 2), new Point[] { t1new, t2new, t3new, t4new });
            }
            
            x1 = 20;
            y1 = 20;
            x2 = 200;
            y2 = 20;
            x3 = 200;
            y3 = 200;
            x4 = 20;
            y4 = 200;

        }
    }
}

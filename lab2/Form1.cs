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

        Bitmap mypic1;
        Bitmap mypic2;

        int squares;
        int triangles;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 50;
            if (int.TryParse(textBox1.Text, out squares))
            {
                n = squares;
            }

            int x1 = 20;
            int y1 = 20;
            int x2 = 200;
            int y2 = 20;
            int x3 = 200;
            int y3 = 200;
            int x4 = 20;
            int y4 = 200;

            Point t1 = new Point(x1, y1);
            Point t2 = new Point(x2, y2);
            Point t3 = new Point(x3, y3);
            Point t4 = new Point(x4, y4);

            mypic1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = mypic1;
            g = Graphics.FromImage(mypic1);
            g.DrawPolygon(new Pen(Color.BurlyWood, 1), new Point[] { t1, t2, t3, t4 });

            float p = 0.08f;

            for (int i = 0; i < n; i++)
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

                g.DrawPolygon(new Pen(Color.BurlyWood, 1), new Point[] { t1new, t2new, t3new, t4new });
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int m = 5;
            if (int.TryParse(textBox2.Text, out triangles))
            {
                m = triangles;
            }

            Pen mypen2 = new Pen(Color.Crimson, 1);

            int x1 = 20;
            int y1 = 20;
            int x2 = 160;
            int y2 = 150;
            int x3 = 200;
            int y3 = 50;

            Point t1 = new Point(x1, y1);
            Point t2 = new Point(x2, y2);
            Point t3 = new Point(x3, y3);

            mypic2 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Image = mypic2;
            g = Graphics.FromImage(mypic2);
            g.DrawPolygon(new Pen(Color.Crimson, 1), new Point[] { t1, t2, t3 });

            float p = 0.5f;

            DrawTriangles(x1, y1, x2, y2, x3, y3, mypen2, m, p);

        }

        private void DrawTriangles(int x1, int y1, int x2, int y2, int x3, int y3, Pen mypen, int depth, float p)
        {
            if (depth != 0)
            {
                float x1new = x1 + (x2 - x1) * p;
                float y1new = y1 + (y2 - y1) * p;
                float x2new = x2 + (x3 - x2) * p;
                float y2new = y2 + (y3 - y2) * p;
                float x3new = x3 + (x1 - x3) * p;
                float y3new = y3 + (y1 - y3) * p;

                Point t1 = new Point(x1, y1);
                Point t2 = new Point(x2, y2);
                Point t3 = new Point(x3, y3);
                Point t1new = new Point((int)x1new, (int)y1new);
                Point t2new = new Point((int)x2new, (int)y2new);
                Point t3new = new Point((int)x3new, (int)y3new);

                g.DrawPolygon(mypen, new Point[] { t1, t1new, t3new });
                g.DrawPolygon(mypen, new Point[] { t1new, t2, t2new });
                g.DrawPolygon(mypen, new Point[] { t2new, t3, t3new });

                depth--;

                DrawTriangles(x1, y1, (int)x1new, (int)y1new, (int)x3new, (int)y3new, mypen, depth, p);
                DrawTriangles((int)x1new, (int)y1new, x2, y2, (int)x2new, (int)y2new, mypen, depth, p);
                DrawTriangles((int)x3new, (int)y3new, (int)x2new, (int)y2new, x3, y3, mypen, depth, p);

            }
        }

    }
}

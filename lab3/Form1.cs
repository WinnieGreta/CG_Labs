using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab3
{
    public partial class Form1 : Form
    {
        Graphics g;

        Bitmap mypic1;
        int d;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out d))
            {
                d = 3;
            }

            Pen mypen1 = new Pen(Color.DarkOliveGreen, 1);

            Point t1 = new Point(100, 310);
            Point t2 = new Point(250, 50);
            Point t3 = new Point(400, 310);

            mypic1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = mypic1;
            g = Graphics.FromImage(mypic1);

            LinkedList<Point> list = new LinkedList<Point>();
            Point center = new Point(250, 223);
            list = CountPoints(t1, t2, t3, d, center);
            Point[] points = list.ToArray();
            g.DrawPolygon(mypen1, points);

        }

        private void DrawSnowflake(Point t1, Point t2, Point t3, Pen mypen, int depth)
        {
            while (depth != 0)
            {
                Point t4 = new Point((int)((t2.X + 2 * t1.X) / 3), (int)((t2.Y + 2 * t1.Y) / 3));
                Point t5 = new Point((int)((t1.X + 2 * t2.X) / 3), (int)((t1.Y + 2 * t2.Y) / 3));
                Point tc = new Point((int)((t1.X + t2.X) / 2), (int)((t1.Y + t2.Y) / 2));
                Point tv = new Point((int)((4 * tc.X - t3.X) / 3), (int)((4 * tc.Y - t3.Y) / 3));

                g.DrawLine(mypen, t4, tv);
                g.DrawLine(mypen, tv, t5);
                depth--;

                Point t7 = new Point((int)((t3.X + 2 * t1.X) / 3), (int)((t3.Y + 2 * t1.Y) / 3));
                DrawSnowflake(t4, t1, t7, mypen, depth);

                Point t6 = new Point((int)((t3.X + 2 * t2.X) / 3), (int)((t3.Y + 2 * t2.Y) / 3));
                DrawSnowflake(t6, t2, t5, mypen, depth);
                DrawSnowflake(t4, tv, t5, mypen, depth);
                DrawSnowflake(tv, t5, t4, mypen, depth);
            }
        }

        private LinkedList<Point> CountPoints(Point t1, Point t2, Point t3, int depth, Point cent)
        {
            LinkedList<Point> points = new LinkedList<Point>();
            LinkedListNode<Point> tt1 = points.AddLast(t1);
            LinkedListNode<Point> tt2 = points.AddLast(t2);
            LinkedListNode<Point> tt3 = points.AddLast(t3);
            int gDepth = depth;
            if (depth != 0)
            {

                bool isFirst = true;
                while (depth != 0)
                {
                    bool needsNext = false;
                    for (LinkedListNode<Point> node = points.First; node != null; node = node.Next.Next.Next.Next)
                    {
                        Point p1 = node.Value;
                        Point p2;
                        Point p3;
                        if (isFirst)
                        {
                            if (node.Next == null)
                            {
                                p2 = points.First.Value;
                                p3 = points.First.Next.Next.Next.Next.Value;
                            }
                            else if (node.Next.Next == null)
                            {
                                p2 = node.Next.Value;
                                p3 = points.First.Value;
                            }
                            else
                            {
                                p2 = node.Next.Value;
                                p3 = node.Next.Next.Value;
                            }
                            AddSide(points, node, p1, p2, p3, cent);
                        }
                        else
                        {
                            if (needsNext)
                            {
                                if (node.Next == null)
                                {
                                    p2 = points.First.Value;
                                    p3 = points.First.Next.Next.Next.Next.Value;
                                }
                                else if (node.Next.Next == null)
                                {
                                    p2 = node.Next.Value;
                                    p3 = points.First.Value;
                                }
                                else
                                {
                                    p2 = node.Next.Value;
                                    p3 = node.Next.Next.Value;
                                }
                                AddSide(points, node, p1, p2, p3, cent);
                                needsNext = false;
                            }
                            else
                            {
                                if (node.Previous == null)
                                {
                                    p2 = node.Next.Value;
                                    p3 = points.Last.Value;
                                }
                                else
                                {
                                    p3 = node.Previous.Previous.Previous.Previous.Value;
                                    p2 = node.Next.Value;
                                }
                                AddSide(points, node, p1, p2, p3, cent);
                                needsNext = true;
                            }
                        }
                        
                    }
                    isFirst = false;
                    depth--;
                }

            }
            return points;
        }

        private void AddSide(LinkedList<Point> points, LinkedListNode<Point> tt1, Point t1, Point t2, Point t3, Point c)
        {
            Point t4 = new Point((t2.X + 2 * t1.X) / 3, (t2.Y + 2 * t1.Y) / 3);
            Point t5 = new Point((t1.X + 2 * t2.X) / 3, (t1.Y + 2 * t2.Y) / 3);
            Point tc = new Point((t1.X + t2.X) / 2, (t1.Y + t2.Y) / 2);
            int x1 = (4 * tc.X - t3.X) / 3;
            int y1 = (4 * tc.Y - t3.Y) / 3;
            int x2 = (tc.X - t3.X) / 3;
            int y2 = (tc.Y - t3.Y) / 3;
            Point tv;
            if ( ((x1 - c.X)*(x1 - c.X) + (y1 - c.Y)*(y1 - c.Y)) < ((x2 - c.X) * (x2 - c.X) + (y2 - c.Y) * (y2 - c.Y)))
            {
                tv = new Point(x1, y1);
            }
            else
            {
                tv = new Point (x2, y2);
            }
            
            LinkedListNode<Point> tt4 = new LinkedListNode<Point>(t4);
            LinkedListNode<Point> ttv = new LinkedListNode<Point>(tv);
            LinkedListNode<Point> tt5 = new LinkedListNode<Point>(t5);
            points.AddAfter(tt1, tt4);
            points.AddAfter(tt4, ttv);
            points.AddAfter(ttv, tt5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out d))
            {
                d = 3;
            }

            Pen mypen2 = new Pen(Color.MediumPurple, 1);
            //Brush eraser = new SolidBrush(Color.AntiqueWhite);

            Point t1 = new Point(100, 310);
            Point t2 = new Point(250, 50);
            Point t3 = new Point(400, 310);

            mypic1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = mypic1;
            g = Graphics.FromImage(mypic1);

            g.DrawPolygon(mypen2, new Point[] { t1, t2, t3 });
            DrawSnowflake(t1, t2, t3, mypen2, d);
            DrawSnowflake(t2, t3, t1, mypen2, d);
            DrawSnowflake(t3, t1, t2, mypen2, d);
            DrawSnowflake(t3, t2, t1, mypen2, d);
            DrawSnowflake(t2, t1, t3, mypen2, d);
            DrawSnowflake(t1, t3, t2, mypen2, d);
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out d))
            {
                d = 3;
            }

            Pen mypen2 = new Pen(Color.DarkCyan, 1);
            Brush eraser = new SolidBrush(Color.AntiqueWhite);

            Point t1 = new Point(100, 310);
            Point t2 = new Point(250, 50);
            Point t3 = new Point(400, 310);

            mypic1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = mypic1;
            g = Graphics.FromImage(mypic1);

            Kochflake(g, d, t1, t2);
            Kochflake(g, d, t2, t3);
            Kochflake(g, d, t3, t1);
            
        }

        private void Kochflake(Graphics g, int depth, Point t1, Point t2)
        {
            Pen pen1 = new Pen(Color.Crimson, 1);
            if (depth != 0)
            {
                Point t4 = new Point((t2.X + 2 * t1.X) / 3, (t2.Y + 2 * t1.Y) / 3);

                Kochflake(g, depth - 1, t1, t4);

                Point t5 = new Point((t1.X + 2 * t2.X) / 3, (t1.Y + 2 * t2.Y) / 3);
                Point tc = new Point((t1.X + t2.X) / 2, (t1.Y + t2.Y) / 2);
                
                double x = (t2.Y - t1.Y) * Math.Cos(Math.PI / 3)/ 2;
                double y = (t1.X - t2.X) * Math.Cos(Math.PI / 3)/ 2;

                Point tv = new Point((int)Math.Round(tc.X + x), (int)Math.Round(tc.Y + y));
                //g.DrawLine(new Pen(Color.BlueViolet, 1), tc, tv);

                Kochflake(g, depth - 1, t4, tv);
                Kochflake(g, depth - 1, tv, t5);
                Kochflake(g, depth - 1, t5, t2);
            }
            else
            {
                g.DrawLine(new Pen(Color.Crimson, 1), t1, t2);
            }
        }
    }
}

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

namespace lab3
{
    public partial class Form1 : Form
    {
        Graphics g;

        Bitmap mypic1;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen mypen1 = new Pen(Color.DarkOliveGreen, 1);

            Brush eraser = new SolidBrush(Color.AntiqueWhite);

            Point t1 = new Point(100, 310);
            Point t2 = new Point(250, 50);
            Point t3 = new Point(400, 310);

            mypic1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = mypic1;
            g = Graphics.FromImage(mypic1);
            //g.DrawPolygon(mypen1, new Point[] { t1, t2, t3});

            
            //DrawSnowflake(t1, t2, t3, mypen1, eraser, 4);
            //DrawSnowflake(t2, t3, t1, mypen1, eraser, 4);
            //DrawSnowflake(t3, t1, t2, mypen1, eraser, 4);
            LinkedList<Point> list = new LinkedList<Point>();
            list = CountPoints(t1, t2, t3, 3);
            Point[] points = list.ToArray();
            g.DrawPolygon(mypen1, points);

        }

        private void DrawSnowflake(Point t1, Point t2, Point t3, Pen mypen, Brush myeraser, int depth)
        {
            while (depth != 0)
            {
                Point t4 = new Point((int)((t2.X + 2 * t1.X) / 3), (int)((t2.Y + 2 * t1.Y) / 3));
                Point t5 = new Point((int)((t1.X + 2 * t2.X) / 3), (int)((t1.Y + 2 * t2.Y) / 3));
                Point tc = new Point((int)((t1.X + t2.X) / 2), (int)((t1.Y + t2.Y) / 2));
                Point tv = new Point((int)((4 * tc.X - t3.X) / 3), (int)((4 * tc.Y - t3.Y) / 3));

                //g.DrawPolygon(mypen, new Point[] { t4, tv, t5 });
                g.DrawLine(mypen, t4, tv);
                g.DrawLine(mypen, tv, t5);
                g.DrawLine(new Pen(Color.AntiqueWhite, 2), t4, t5);
                //g.FillPolygon(myeraser, new Point[] { t1, t4, tv, t5, t2, t3 });
                depth--;

                DrawSnowflake(t4, tv, t5, mypen, myeraser, depth);
                DrawSnowflake(tv, t5, t4, mypen, myeraser, depth);
            }
        }

        private LinkedList<Point> CountPoints(Point t1, Point t2, Point t3, int depth)
        {
            LinkedList<Point> points = new LinkedList<Point>();
            LinkedListNode<Point> tt1 = points.AddLast(t1);
            LinkedListNode<Point> tt2 = points.AddLast(t2);
            LinkedListNode<Point> tt3 = points.AddLast(t3);
            int gDepth = depth;
            if (depth != 0)
            {

                //Point t4 = new Point((int)((t2.X + 2 * t1.X) / 3), (int)((t2.Y + 2 * t1.Y) / 3));
                //Point t5 = new Point((int)((t1.X + 2 * t2.X) / 3), (int)((t1.Y + 2 * t2.Y) / 3));
                //Point tc = new Point((int)((t1.X + t2.X) / 2), (int)((t1.Y + t2.Y) / 2));
                //Point tv = new Point((int)((4 * tc.X - t3.X) / 3), (int)((4 * tc.Y - t3.Y) / 3));
                //LinkedListNode<Point> tt4 = new LinkedListNode<Point>(t4);
                //LinkedListNode<Point> ttv = new LinkedListNode<Point>(tv);
                //LinkedListNode<Point> tt5 = new LinkedListNode<Point>(t5);
                //points.AddAfter(tt1, tt4);
                //points.AddAfter(tt4, ttv);
                //points.AddAfter(ttv, tt5);

                //Point t6 = new Point((int)((t3.X + 2 * t2.X) / 3), (int)((t3.Y + 2 * t2.Y) / 3));
                //Point t7 = new Point((int)((t2.X + 2 * t3.X) / 3), (int)((t2.Y + 2 * t3.Y) / 3));
                //Point tc2 = new Point((int)((t2.X + t3.X) / 2), (int)((t2.Y + t3.Y) / 2));
                //Point tv2 = new Point((int)((4 * tc2.X - t1.X) / 3), (int)((4 * tc2.Y - t1.Y) / 3));
                //LinkedListNode<Point> tt6 = new LinkedListNode<Point>(t6);
                //LinkedListNode<Point> ttv2 = new LinkedListNode<Point>(tv2);
                //LinkedListNode<Point> tt7 = new LinkedListNode<Point>(t7);
                //points.AddAfter(tt2, tt6);
                //points.AddAfter(tt6, ttv2);
                //points.AddAfter(ttv2, tt7);

                //Point t8 = new Point((int)((t1.X + 2 * t3.X) / 3), (int)((t1.Y + 2 * t3.Y) / 3));
                //Point t9 = new Point((int)((t3.X + 2 * t1.X) / 3), (int)((t3.Y + 2 * t1.Y) / 3));
                //Point tc3 = new Point((int)((t3.X + t1.X) / 2), (int)((t3.Y + t1.Y) / 2));
                //Point tv3 = new Point((int)((4 * tc3.X - t2.X) / 3), (int)((4 * tc3.Y - t2.Y) / 3));
                //LinkedListNode<Point> tt8 = new LinkedListNode<Point>(t8);
                //LinkedListNode<Point> ttv3 = new LinkedListNode<Point>(tv3);
                //LinkedListNode<Point> tt9 = new LinkedListNode<Point>(t9);
                //points.AddAfter(tt3, tt8);
                //points.AddAfter(tt8, ttv3);
                //points.AddAfter(ttv3, tt9);

                //AddSide(points, tt1, t1, t2, t3, depth);
                //AddSide(points, tt2, t2, t3, t1, depth);
                //AddSide(points, tt3, t3, t1, t2, depth);
                bool isFirst = true;
                while (depth != 0)
                {
                    bool needsNext = false;
                    //LinkedList<Point> oldPoints = new LinkedList<Point>(points);
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
                            AddSide(points, node, p1, p2, p3);
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
                                AddSide(points, node, p1, p2, p3);
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
                                AddSide(points, node, p1, p2, p3);
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

        private void AddSide(LinkedList<Point> points, LinkedListNode<Point> tt1, Point t1, Point t2, Point t3)
        {
            Point t4 = new Point((int)((t2.X + 2 * t1.X) / 3), (int)((t2.Y + 2 * t1.Y) / 3));
            Point t5 = new Point((int)((t1.X + 2 * t2.X) / 3), (int)((t1.Y + 2 * t2.Y) / 3));
            Point tc = new Point((int)((t1.X + t2.X) / 2), (int)((t1.Y + t2.Y) / 2));
            Point tv = new Point((int)((4 * tc.X - t3.X) / 3), (int)((4 * tc.Y - t3.Y) / 3));
            LinkedListNode<Point> tt4 = new LinkedListNode<Point>(t4);
            LinkedListNode<Point> ttv = new LinkedListNode<Point>(tv);
            LinkedListNode<Point> tt5 = new LinkedListNode<Point>(t5);
            points.AddAfter(tt1, tt4);
            points.AddAfter(tt4, ttv);
            points.AddAfter(ttv, tt5);
        }
    }
}

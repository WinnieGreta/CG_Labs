using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        //private Point[] points = new Point[] { new Point(50, 160), new Point(180, 110), new Point(250, 210), new Point(50, 160) };
        //int leftText = 200;
        //int topText = 200;
        //static FontFamily fontFamily = new FontFamily("Arial");
        //Font font = new Font(fontFamily, 25, FontStyle.Bold);
        //string text = "CG&M";

        Graphics g;

        Bitmap mypic1;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen mypen1 = new Pen(Color.DarkOliveGreen, 1);

            Point t1 = new Point(200, 10);
            Point t2 = new Point(275, 110);
            Point t3 = new Point(200, 210);
            Point t4 = new Point(125, 110);

            mypic1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = mypic1;
            g = Graphics.FromImage(mypic1);

            g.DrawPolygon(mypen1, new PointF[] { t1, t2, t3, t4 });
            //g.FillPolygon(Brushes.DarkCyan, new PointF[] { t1, t2, t3, t4 });
            

            //Graphics g = CreateGraphics();
            //g.Clear(Color.White);
            //g.FillPolygon(Brushes.Black, points);
            //Matrix myMatrix = new Matrix();
            //double xScale = Convert.ToDouble(txtXScale.Text);
            //double yScale = Convert.ToDouble(txtYScale.Text);
            //myMatrix.Scale((float)xScale, (float)yScale, MatrixOrder.Append);
            //g.Transform = myMatrix;
            //g.FillPolygon(Brushes.Red, points);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.TranslateTransform(50, 0);
            Invalidate();
            

            //Graphics g = CreateGraphics();
            //g.Clear(Color.White);
            //g.DrawString(text, font, Brushes.Black, leftText, topText);
            //int angle = Convert.ToInt32(txtTextRotate.Text);
            //GraphicsPath path = new GraphicsPath(FillMode.Winding);
            //path.AddString(text, fontFamily, (int)FontStyle.Bold, 50, new Point(leftText + 100, topText + 100), StringFormat.GenericDefault); // додавання тексту
            //Matrix matrix = new Matrix();
            //matrix.RotateAt(angle, new PointF(leftText + 100, topText + 100)); //обертання
            //path.Transform(matrix); // застосування матриці перетворень до об’єкту path
            //g.FillPath(Brushes.Red, path);
        }
    }
}

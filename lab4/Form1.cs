using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        int _starSpeed = 1;
        bool movingUp1 = false;
        bool movingUp2 = true;
        bool movingUp3 = false;
        bool isAutomatic;
        int x = 5;
        int y = 5;
        int x1 = 10;
        int y1 = 10;
        Image im1 = Image.FromFile("sprite5.png");
        Image im2 = Image.FromFile("sprite3.png");

        public Form1()
        {
            InitializeComponent();

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (isAutomatic)
            {
                puff.Top += y;
                if (puff.Top <= 0 || puff.Top + 1.5 * puff.Height >= this.Height || puff.Bounds.IntersectsWith(star1.Bounds) || puff.Bounds.IntersectsWith(star2.Bounds) || puff.Bounds.IntersectsWith(star3.Bounds))
                {
                    y = 0 - y;
                }
                puff.Left += x;
                if (puff.Left <= 0 || puff.Left + 1.5 * puff.Width >= this.Width || puff.Bounds.IntersectsWith(star1.Bounds) || puff.Bounds.IntersectsWith(star2.Bounds) || puff.Bounds.IntersectsWith(star3.Bounds))
                {
                    x = 0 - x;
                }
            }

            movingUp1 = MoveStar(star1, _starSpeed, movingUp1);
            movingUp2 = MoveStar(star2, _starSpeed, movingUp2);
            movingUp3 = MoveStar(star3, _starSpeed, movingUp3);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }


        public bool MoveStar(PictureBox star, int speed, bool movingUp)
        {
            if (movingUp)
            {
                if (star.Top >= star.Height)
                {
                    star.Top -= speed;
                }
                else
                {
                    movingUp = false;
                    star.Top += speed;
                }
            }
            else
            {
                if (star.Top <= this.Height - 2 * star.Height)
                {
                    star.Top += speed;
                }
                else
                {
                    movingUp = true;
                    star.Top -= speed;
                }
            }
            return movingUp;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.M:
                    if(isAutomatic)
                    {
                        isAutomatic = false;
                    }
                    else
                    {
                        isAutomatic= true;
                    }
                    break;
                case Keys.Up:
                    if(!isAutomatic && !(puff.Bounds.IntersectsWith(star1.Bounds) || puff.Bounds.IntersectsWith(star2.Bounds) || puff.Bounds.IntersectsWith(star3.Bounds)))
                    {
                        puff.Top -= Math.Abs(y)*2;
                    }
                    break;
                case Keys.Down:
                    if (!isAutomatic && !(puff.Bounds.IntersectsWith(star1.Bounds) || puff.Bounds.IntersectsWith(star2.Bounds) || puff.Bounds.IntersectsWith(star3.Bounds)))
                    {
                        puff.Top += Math.Abs(y)*2;
                    }
                    break;
                case Keys.Left:
                    if (!isAutomatic && !(puff.Bounds.IntersectsWith(star1.Bounds) || puff.Bounds.IntersectsWith(star2.Bounds) || puff.Bounds.IntersectsWith(star3.Bounds)))
                    {
                        puff.Left -= Math.Abs(x)*2;
                    }
                    break;
                case Keys.Right:
                    if (!isAutomatic && !(puff.Bounds.IntersectsWith(star1.Bounds) || puff.Bounds.IntersectsWith(star2.Bounds) || puff.Bounds.IntersectsWith(star3.Bounds)))
                    {
                        puff.Left += Math.Abs(x)*2;
                    }
                    break;
                case Keys.C:
                    if(puff.Image != im2)
                    {
                        puff.Image = im2;
                    }
                    else
                    {
                        puff.Image = im1;
                    }
                    break;
                    
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            timer2.Start();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if(!isAutomatic)
            {
                Point p1 = this.PointToClient(Cursor.Position);

                if (p1.X - puff.Location.X - puff.Width / 2 >= 0 && !(puff.Bounds.IntersectsWith(star1.Bounds) || puff.Bounds.IntersectsWith(star2.Bounds) || puff.Bounds.IntersectsWith(star3.Bounds)))
                {
                    puff.Left += Math.Abs(x1);
                }
                else if(puff.Location.X - p1.X + puff.Width / 2 >= 0 && !(puff.Bounds.IntersectsWith(star1.Bounds) || puff.Bounds.IntersectsWith(star2.Bounds) || puff.Bounds.IntersectsWith(star3.Bounds)))
                {
                    puff.Left -= Math.Abs(x1);
                }

                if (p1.Y - puff.Location.Y - puff.Height / 2 >= 0 && !(puff.Bounds.IntersectsWith(star1.Bounds) || puff.Bounds.IntersectsWith(star2.Bounds) || puff.Bounds.IntersectsWith(star3.Bounds)))
                {
                    puff.Top += Math.Abs(y1);
                }
                else if (puff.Location.Y - p1.Y + puff.Height / 2 >= 0 && !(puff.Bounds.IntersectsWith(star1.Bounds) || puff.Bounds.IntersectsWith(star2.Bounds) || puff.Bounds.IntersectsWith(star3.Bounds)))
                {
                    puff.Top -= Math.Abs(y1);
                }

            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            timer2.Stop();
        }
    }
}

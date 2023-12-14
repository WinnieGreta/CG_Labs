using System.Drawing;

namespace lab4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.puff = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.star1 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.star3 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.puff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).BeginInit();
            this.SuspendLayout();
            // 
            // puff
            // 
            this.puff.BackColor = System.Drawing.Color.Transparent;
            this.puff.Image = ((System.Drawing.Image)(resources.GetObject("puff.Image")));
            this.puff.Location = new System.Drawing.Point(333, 178);
            this.puff.Name = "puff";
            this.puff.Size = new System.Drawing.Size(64, 64);
            this.puff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.puff.TabIndex = 0;
            this.puff.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // star1
            // 
            this.star1.BackColor = System.Drawing.Color.Transparent;
            this.star1.Image = ((System.Drawing.Image)(resources.GetObject("star1.Image")));
            this.star1.Location = new System.Drawing.Point(101, 56);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(73, 67);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star1.TabIndex = 1;
            this.star1.TabStop = false;
            // 
            // star2
            // 
            this.star2.BackColor = System.Drawing.Color.Transparent;
            this.star2.Image = ((System.Drawing.Image)(resources.GetObject("star2.Image")));
            this.star2.Location = new System.Drawing.Point(324, 328);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(73, 67);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star2.TabIndex = 2;
            this.star2.TabStop = false;
            // 
            // star3
            // 
            this.star3.BackColor = System.Drawing.Color.Transparent;
            this.star3.Image = ((System.Drawing.Image)(resources.GetObject("star3.Image")));
            this.star3.Location = new System.Drawing.Point(539, 56);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(73, 67);
            this.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star3.TabIndex = 3;
            this.star3.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.puff);
            this.Name = "Form1";
            this.Text = "Puff Hunt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.puff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox puff;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.PictureBox star3;
        private System.Windows.Forms.Timer timer2;
    }
}


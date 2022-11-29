using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace drawPictures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics gr;
        Font f;
        Pen p;
        Brush b;

        private void Form1_Load(object sender, EventArgs e)
        {
            gr = CreateGraphics();
            f = Font;
            p = new Pen(Color.Black,2);
            b = new SolidBrush(Color.Black);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            gr.Clear(BackColor);
            //gr.DrawEllipse(p, 100, 100, 200, 200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Square s = new Square(25);
            //s.location.X = 200;
            //s.location.Y = 200;
            s.Color = Color.Black;
            //s.size = 25;
            s.Draw(this.gr);

            gr.DrawString(s.Size.ToString() + " : " + s.Location.X.ToString() + " : " + s.Location.Y.ToString(), f, b, 10, 10);
          
            //gr.DrawRectangle(p, s.Location.X, s.Location.Y, s.Size , s.Size);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Circle c = new Circle(24);
            //c.location.X = 200;
            //c.location.Y = 200;
            c.Color = Color.Black;
            //c.radius = 45;
            c.Draw(this.gr);

            gr.DrawString(c.Radius.ToString() + " : " + c.Location.X.ToString() + " : " + c.Location.Y.ToString(), f, b, 10, 30);
        

            //gr.DrawEllipse(p, c.Location.X, c.Location.Y, c.Radius, c.Radius);
        }
    }
}

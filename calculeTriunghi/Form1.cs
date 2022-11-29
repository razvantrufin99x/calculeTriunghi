using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculeTriunghi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        Font f;
        Pen p;
        Brush b;

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            f = Font;
            p = new Pen(Color.Black, 2);
            b = new SolidBrush(Color.Black);


        }



        public  void drawTriunghi()
        {
            g.Clear(Color.White);
            g.DrawLine(p, dotControl1.Left, dotControl1.Top, dotControl2.Left, dotControl2.Top);
            g.DrawLine(p, dotControl2.Left, dotControl2.Top, dotControl3.Left, dotControl3.Top);
            g.DrawLine(p, dotControl3.Left, dotControl3.Top, dotControl1.Left, dotControl1.Top);

            //g.Clear(BackColor);
            label1.Text = fdistanta(label1, dotControl1, dotControl2).ToString();
            label1.Text += " : " + unghiul(dotControl1, dotControl2);
            g.DrawLine(p, dotControl1.Left, dotControl1.Top, dotControl2.Left, dotControl2.Top);
            //g.DrawLine(pen0, dotctrl1.Left+10, dotctrl1.Top+10, dotctrl2.Left+10, dotctrl2.Top+10);
            //g.DrawLine(pen0, dotctrl1.Left - 10, dotctrl1.Top - 10, dotctrl2.Left - 10, dotctrl2.Top - 10);
            g.DrawString(dotControl1.Left.ToString() + " : " + dotControl1.Top.ToString(), f, b, dotControl1.Left, dotControl1.Top);
            g.DrawString(dotControl2.Left.ToString() + " : " + dotControl2.Top.ToString(), f, b, dotControl2.Left, dotControl2.Top);


            //g.Clear(BackColor);
            label2.Text = fdistanta(label2, dotControl2, dotControl3).ToString();
            label2.Text += " : " + unghiul(dotControl2, dotControl3);
            g.DrawLine(p, dotControl2.Left, dotControl2.Top, dotControl3.Left, dotControl3.Top);
            //g.DrawLine(pen0, dotctrl1.Left+10, dotctrl1.Top+10, dotctrl2.Left+10, dotctrl2.Top+10);
            //g.DrawLine(pen0, dotctrl1.Left - 10, dotctrl1.Top - 10, dotctrl2.Left - 10, dotctrl2.Top - 10);
            g.DrawString(dotControl3.Left.ToString() + " : " + dotControl3.Top.ToString(), f, b, dotControl3.Left, dotControl3.Top);
            g.DrawString(dotControl2.Left.ToString() + " : " + dotControl2.Top.ToString(), f, b, dotControl2.Left, dotControl2.Top);



            //g.Clear(BackColor);
            label3.Text = fdistanta(label3, dotControl1, dotControl3).ToString();
            label3.Text += " : " + unghiul(dotControl1, dotControl3);
            g.DrawLine(p, dotControl1.Left, dotControl1.Top, dotControl3.Left, dotControl3.Top);
            //g.DrawLine(pen0, dotctrl1.Left+10, dotctrl1.Top+10, dotctrl2.Left+10, dotctrl2.Top+10);
            //g.DrawLine(pen0, dotctrl1.Left - 10, dotctrl1.Top - 10, dotctrl2.Left - 10, dotctrl2.Top - 10);
            g.DrawString(dotControl1.Left.ToString() + " : " + dotControl1.Top.ToString(), f, b, dotControl1.Left, dotControl1.Top);
            g.DrawString(dotControl3.Left.ToString() + " : " + dotControl3.Top.ToString(), f, b, dotControl3.Left, dotControl3.Top);

           // updatepositions(dotControl1, dotControl2, dotControl3);
        }

        public int Min(int a, int b)
        {
            if (a < b) return a;
            else return b;
        }
        public double fdistanta(Label l, dotControl a, dotControl b)
        {
            try
            {

                l.Left = 20 + Min(a.Left, b.Left) + Convert.ToInt16(Math.Sqrt(Math.Pow(Math.Abs(a.Left - b.Left), 2)) / 2);
                l.Top = Min(a.Top, b.Top) + Convert.ToInt16(Math.Sqrt(Math.Pow(Math.Abs(a.Top - b.Top), 2)) / 2);

             }
            catch { }
            return Math.Sqrt(Math.Abs(a.Left - b.Left) * Math.Abs(a.Left - b.Left) + Math.Abs(a.Top - b.Top) * Math.Abs(a.Top - b.Top));
        }

        public void updatepositions(dotControl a, dotControl b, dotControl c)
        {
            try
            {

                label1.Left = 20 + Min(a.Left, b.Left) + Convert.ToInt16(Math.Sqrt(Math.Pow(Math.Abs(a.Left - b.Left), 2)) / 2);
                label1.Top = Min(a.Top, b.Top) + Convert.ToInt16(Math.Sqrt(Math.Pow(Math.Abs(a.Top - b.Top), 2)) / 2);

                label2.Left = 20 + Min(c.Left, b.Left) + Convert.ToInt16(Math.Sqrt(Math.Pow(Math.Abs(c.Left - b.Left), 2)) / 2);
                label2.Top = Min(c.Top, b.Top) + Convert.ToInt16(Math.Sqrt(Math.Pow(Math.Abs(c.Top - b.Top), 2)) / 2);

                label3.Left = 20 + Min(a.Left, c.Left) + Convert.ToInt16(Math.Sqrt(Math.Pow(Math.Abs(a.Left - c.Left), 2)) / 2);
                label3.Top = Min(a.Top, c.Top) + Convert.ToInt16(Math.Sqrt(Math.Pow(Math.Abs(a.Top - c.Top), 2)) / 2);
            }
            catch { }
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            drawTriunghi();

            
        }

        public double unghiul(dotControl a, dotControl b)
        {
            double degrees;
            if (b.Left - a.Left == 0)
            {
                if (b.Top > a.Top)
                {
                    degrees = 90;
                }
                else
                {
                    degrees = 270;
                }
            }
            else
            {
                double riseoverrun = Convert.ToDouble(Math.Abs((b.Top - a.Top)) / Convert.ToDouble(Math.Abs(b.Left - a.Left)));
                double radians = Math.Atan(riseoverrun);
                degrees = radians * Convert.ToDouble(180 / Math.PI);
            }
            if (Math.Abs(b.Left - a.Left) < 0 || Math.Abs(b.Top - a.Top) < 0)
            {
                degrees += 180;
            }
            if (Math.Abs(b.Left - a.Left) > 0 && Math.Abs(b.Top - a.Top) < 0)
            {
                degrees -= 180;
            }
            if (degrees < 0)
            {
                degrees += 360;
            }



            return degrees;

        }


    }
}

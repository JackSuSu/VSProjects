using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _15GDI_
{

    /// <summary>
    /// 
    /// GDI+ 绘图装置的接口
    /// 
    /// 应用程序和硬件分离
    /// 
    /// 例子：电脑很卡的时候，然后拖动窗体会出现 虚屏幕的情况
    /// 
    /// 拖动窗体是重新绘制了一个图像
    /// 
    /// 自己绘制的直线：拖动会消失
    /// 
    /// 调用窗体：paint事件 重新绘制直线，移动一点点 绘制一点点，移动的慢  效果越明显
    /// 
    /// </summary>

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // 生活中画一条直线

            // 一支笔 一张纸 两点 绘制直线的人 

           


        }

        private void button1_Click(object sender, EventArgs e)
        {

            //创建GDI对象

            Graphics g = this.CreateGraphics();

            Pen pennew = new Pen(Brushes.Red);

            Point p1 = new Point(30, 50);

            Point p2 = new Point(250, 250);

            g.DrawLine(pennew, p1, p2);

        }


        /// <summary>
        /// 
        /// 窗体重新绘制窗体事件
        /// 
        /// 重新绘制直线
        /// 
        /// 一点点的绘制
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        int i = 0;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            i++;

            Graphics g = this.CreateGraphics();

            Pen pennew = new Pen(Brushes.Red);

            Point p1 = new Point(30, 50);

            Point p2 = new Point(250, 250);

            g.DrawLine(pennew, p1, p2);

            label1.Text = i.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Graphics g = this.CreateGraphics();

            Pen pennew = new Pen(Brushes.Red);

            Point p1 = new Point(30, 50);

            Point p2 = new Point(250, 250);

            Rectangle rec = new Rectangle(new Point(50, 50), new Size(50, 50));

            g.DrawRectangle(pennew, rec);

            //g.DrawLine(pennew, p1, p2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen pennew = new Pen(Brushes.Red);

            Point p1 = new Point(30, 50);


            Point p2 = new Point(250, 250);

            Rectangle rec = new Rectangle(new Point(50, 50), new Size(80, 80));

            g.DrawPie(pennew, rec, 100, 200);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics gg = this.CreateGraphics();

            string paintstr = "12315";

            Font ft = new Font("宋体", 10, FontStyle.Italic);

            PointF pt = new PointF();

            Rectangle rec = new Rectangle(new Point(50, 50), new Size(50, 50));

            gg.DrawString(paintstr, ft, Brushes.Red, rec);

            //gg.DrawString("1585",new Font(new FontFamily("宋体"),FontStyle.Bold),Brushes.Red,new PointF()); 
        }


        /// <summary>
        /// 
        /// 操作系统 都是位图；
        /// 
        /// 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button5_Click(object sender, EventArgs e)
        {

            Random r = new Random();

           int ramNum=  r.Next(10000, 99999);

           Bitmap bmp = new Bitmap(200,50);


            //Graphic向位图上 画图片

            //向指定的图片画新的图像

           Graphics g = Graphics.FromImage(bmp);

            //将图片显示到PictureBox

           Color[] colors = { Color.Red, Color.Blue, Color.Gray, Color.DarkCyan, Color.Black };

            Font ft=new Font("宋体", 15,FontStyle.Bold);


            string rastr = ramNum.ToString();

            for (int i = 0; i < rastr.Length; i++)
            {
                g.DrawString(rastr[i].ToString(),ft, new SolidBrush(colors[r.Next(0,colors.Length)]), new PointF(i*20+30,20));

            }


            for (int i = 0; i < 50; i++)
            {
                Point p1=new Point(r.Next(0,bmp.Width),r.Next(0,bmp.Height));

                Point p2=new Point(r.Next(0,bmp.Width),r.Next(0,bmp.Height));

                g.DrawLine(new Pen(Brushes.Green), p1, p2);

            }

            for (int i = 0; i < 500; i++)
            {

                Point pt = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));

                bmp.SetPixel(pt.X, pt.Y, colors[r.Next(0, colors.Length)]);

            }
           

           pictureBox1.Image = bmp;


        }
    }
}

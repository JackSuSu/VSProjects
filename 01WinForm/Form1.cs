using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _01WinForm
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// 
        /// 初始化构造函数
        /// 
        /// 同时 初始化控件
        /// 
        /// 同名的Class名称 partial Form1
        /// 
        /// design.cs 里面的 partial class 里面的内容
        /// 
        /// Button 控件的调试1.属性工具面板 2.手动Desing.cs 文件修改代码
        /// 
        ///1. Name 后台获取前台的控件需要name 属性 快捷键F4
        ///2. Anchor 是控件的相对位置 上下左右拉伸窗体后执行
        ///3. BackGround Color  背景色
        ///4. BackGroundImageLayout title 原尺寸显示 zoom 居中显示 strech 拉伸 center 居中 zoon 等比拉伸
        /// 5.Cusor鼠标形状
        /// 6.Visible 可见 enable
        /// 7.FlatStyle button的样式
        /// 
        /// </summary>

        public Form1()
        {
            InitializeComponent();

        //    Button btn = new Button();

           
        }


        /// <summary>
        /// 
        /// 事件
        /// 
        ///1. 注册事件
        /// 
        /// 2.出发事件
        /// 
        /// </summary>
        /// <param name="sender">出发事件对象</param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = sender as Button;

                MessageBox.Show(btn.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //在内存中创建窗体对象

            Form2 f2 = new Form2();

            //在窗体中展示

            f2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ai Simida");
        }


        /// <summary>
        /// 
        /// 坐标体系（从左向右为增大x轴，从上往下为y轴增大）
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            int x = this.ClientSize.Width - button4.Width;

            int y = this.ClientSize.Height - button4.Height;

            Random r = new Random();

            button4.Location = new Point(new Size(r.Next(x+1), r.Next(y+1)));

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = this.ClientSize.Width - button4.Width;

            int y = this.ClientSize.Height - button4.Height;

            Random r = new Random();

            button4.Location = new Point(new Size(r.Next(x), r.Next(y)));

            

            
        }
    }
}

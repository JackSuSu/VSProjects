using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _12多线程概念
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        Thread thred ;

        private void button1_Click(object sender, EventArgs e)
        {

            ///所有的内容都可以使用主线程 执行
            ///界面 拖动 文本 Test 主线程执行 所以会卡

            thred = new Thread(Test);

            //应用程序接收后 同时关闭啊Thread线程

            thred.IsBackground = true;

            //标记线程准备就绪 可以被执行

            //什么时候执行 是由CPU决定的 CPU忙碌 依然无法执行

            //线程分为：前台线程后台线程

            //前台线程：只有所有的前台线程都关闭了（Thread） 应用程序主线程才能关闭

            //后台线程：只要应用程序线程结束，后台线程才会自动结束（把Thread设置为后台线程）

            //单线程：如果单线程做更多事情就会出现假死现象，做多件事情 节约时间

            //线程：Win7和Win8不一样（WIN8报错 Dispose 释放资源） 当关闭当前应用程序时由于延时，并没有立即关闭子线程

            //但是，文本框控件已经被Dispose了，所以子线程无法访问 文本框控件

            //解决方法：关闭窗体的时候

           //Sleep() 主线程的方法 主线程睡眠

            thred.Start();


            //Test();
        }

        private void Test()
        {
            for (int i = 0; i < 100000; i++)
            {
              
                //NET 中不允许跨线程访问

                //Console.WriteLine(i);

                textBox1.Text = i.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //如果取消跨线程访问呢？？？？？

            // Control是所有空间的基类型，这个时候就不检查子线程 跨线程访问的使用

            Control.CheckForIllegalCrossThreadCalls = false;

        }


        /// <summary>
        /// 
        /// 关闭窗体的时候 判断新线程是否为NULL值
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (thred != null)
            {

                //关闭后不能Start的了

                thred.Abort();
            }

        }

    }
}

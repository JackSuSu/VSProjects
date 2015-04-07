using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace _01TextBoxDLabel
{
    /// <summary>
    /// 
    /// TextBox Mutitext 多行文本显示
    /// 
    /// WordWrap 是否自动换行
    /// 
    /// ScrollBar 水平和垂直
    /// 
    /// timer 事件 是不停的在做一个事件 持续性的每隔多长时间 进行一次
    /// 
    /// </summary>

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox txb = sender as TextBox;

                label1.Text = txb.Text;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();

            if (DateTime.Now.Second == 1)
            {
                SoundPlayer sp = new SoundPlayer();

                sp.SoundLocation = @"D:\data.wav";

                sp.Play();

            }

        }

    }
}

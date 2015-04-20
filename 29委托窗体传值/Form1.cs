using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _29委托窗体传值
{


    delegate  void DelTest();

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// 使用：委托把方法从一个窗体 传到另外一个窗体，也就是从一个类 转到另一个类
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(ShowMessage);
            
            f2.Show();
        }

        void ShowMessage(string str)
        {
            label1.Text = str;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            DelTest del = T1;

            del += T2;

            del += T3;

            del -= T3;

            del();
        }

        void T1()
        {
            label1.Text += "T1";
        }


        void T2()
        {
            label1.Text += "T2";
        }



        void T3()
        {
            label1.Text += "T3";
        }


    }
}

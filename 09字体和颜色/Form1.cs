using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _09字体和颜色
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// 字体对话框
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void button1_Click(object sender, EventArgs e)
        {

            FontDialog fd = new FontDialog();

            fd.ShowDialog();

            textBox1.Font = fd.Font;

        }


        /// <summary>
        /// 
        /// 颜色对话框
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button2_Click(object sender, EventArgs e)
        {

            ColorDialog cd = new ColorDialog();

            cd.ShowDialog();

            textBox1.ForeColor = cd.Color;

        }
    }
}

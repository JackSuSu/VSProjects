using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _29委托窗体传值
{


    public delegate void OnClickData(string str);


    public partial class Form2 : Form
    {

        public OnClickData _clicked;

        public Form2(OnClickData click)
        {

            _clicked = click;
            InitializeComponent();

        }


        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _clicked(textBox1.Text);
        }
    }
}

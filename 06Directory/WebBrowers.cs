using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _06Directory
{
    public partial class WebBrowers : Form
    {
        public WebBrowers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

            webBrowser1.Url = new Uri(textBox1.Text);
        }
    }
}

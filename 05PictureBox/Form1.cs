using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _05PictureBox
{
    public partial class Form1 : Form
    {

        string[] path;

        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            i--;

            if (i < 0)
            {
                i = path.Length - 1;
            }

            pictureBox1.Image = Image.FromFile(path[i]);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            i++;

            if (i == path.Length)
            {
                i = 0;
            }

            pictureBox1.Image = Image.FromFile(path[i]);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            path = Directory.GetFiles(@"F:\PersonalDream\NET基础\slider-master\slider-master\img\landscape");


            pictureBox1.Image = Image.FromFile(path[i]);

      



        }
    }
}

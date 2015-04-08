using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _06Directory
{

    /// <summary>
    /// 
    /// Path 路径
    /// 
    /// FIle 文件
    /// 
    /// FileStream 文件流的处理
    /// 
    /// Directory 文件夹 剪切创建方法
    /// 
    /// Create/Delete 删除文件夹/Move剪切文件夹/exist 文件夹 /GetFiles 获取指定路径下全部路径 /Getdirecties 指定的所有文件夹
    /// 
    /// 
    /// 
    /// </summary>

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Directory.CreateDirectory(@"C:\users\sulongfeng\desktop\aaaaaa");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Directory.Delete(@"C:\users\sulongfeng\desktop\aaaaaa", true);

            Directory.Move(@"C:\users\sulongfeng\desktop\aaaaaa", @"C:\aaaaaa");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] paths = Directory.GetFiles(@"C:\users\sulongfeng\desktop");


            /// 获取文件名 筛选参数

            string[] paths2= Directory.GetFiles(@"C:\users\sulongfeng\desktop","*.jpg");

            MessageBox.Show(paths2[0]);


            // 获取文件夹

            string[] dirs3 = Directory.GetDirectories(@"C:\users\sulongfeng\desktop");

            MessageBox.Show(dirs3[1]);

            if (Directory.Exists(@"C:\aaaaaa"))
            {

                MessageBox.Show("YOU");

            }
            else
            {
                MessageBox.Show("WU");
            }


            //File Delete/Directory Delete 彻底删除


        }
    }
}

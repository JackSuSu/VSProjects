using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _08SaveOpenDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 
        /// 打开文件对话框
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            
            //打开标题

            openFileDialog1.Title = "请选择要打开的文件";

            //是否支持多选

            openFileDialog1.Multiselect = true;

            //初始化目录

            openFileDialog1.InitialDirectory = @"C:\";

            //指定文件格式

            openFileDialog1.Filter = "文本文件|*.txt|图片文件|*.jpg|所有文件|*.*";


            //选择对话框

            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {

                

                using (FileStream fs = new FileStream(@"C:\users\sulongfeng\desktop\stringtest.txt", FileMode.Open, FileAccess.Read))
                {

                    byte[] buffer = new byte[1024 * 1024 * 1];

                    fs.Read(buffer, 0, (int)fs.Length);

                    string strdata = Encoding.Default.GetString(buffer);

                    MessageBox.Show(strdata);
 
                }

                //pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }


        /// <summary>
        /// 
        /// 保存事件对话框
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button2_Click(object sender, EventArgs e)
        {

            //创建保存的对象

            SaveFileDialog svd = new SaveFileDialog();


            svd.Title = "请选择要保存的路径。";

            svd.Filter = "文本文件|*.txt";

            

            svd.ShowDialog();

            if (svd.FileName != string.Empty)
            {

                string datastr = ".NET高级工程开发";

                string filename = svd.FileName;

                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] btys = Encoding.Default.GetBytes(datastr);

                    fs.Write(btys, 0, btys.Length);
                }

                MessageBox.Show("保存成功！");

            }

      

        


        }





    }
}

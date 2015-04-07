using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _10Panel的使用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //panel1.Visible = false;
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opg = new OpenFileDialog();

            opg.Title = "请选择文件路径";

            opg.Filter = "文本文件|*.txt";

            opg.Multiselect = false;

       

            opg.ShowDialog();

            if (opg.FileName != string.Empty)
            {

                string filerecorder = Path.GetFileName(opg.FileName);

                打开记录ToolStripMenuItem.DropDownItems.Add(filerecorder);

                using (FileStream fs = new FileStream(opg.FileName,FileMode.OpenOrCreate,FileAccess.Read))
                {
                    byte[] buffer = new byte[fs.Length];

                    int r = fs.Read(buffer, 0, buffer.Length);

                    textBox2.Text = Encoding.Default.GetString(buffer);
                }

            }

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog sg = new SaveFileDialog();

            sg.Title = "请选择要保存的路径";

            sg.Filter = "文本文件|*.txt";

            sg.ShowDialog();

            string path = sg.FileName;

            if (path != string.Empty)
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = Encoding.Default.GetBytes(textBox2.Text);

                    fs.Write(buffer, 0, buffer.Length);

                }
            }

        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox2.WordWrap == true)
            {
                textBox2.WordWrap = false;
            }
            else
            {
                textBox2.WordWrap = true;
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fg = new FontDialog();

            fg.ShowDialog();

            textBox2.Font = fg.Font;
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ColorDialog cl = new ColorDialog();

            cl.ShowDialog();

            textBox2.ForeColor = cl.Color;

        }
    }
}

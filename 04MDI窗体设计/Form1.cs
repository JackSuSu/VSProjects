using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _04MDI窗体设计
{

    /// <summary>
    /// 
    /// MDI窗体设计 
    /// 
    /// 大的窗体嵌套小的窗体
    /// 
    /// 类似JqueryUI
    /// 
    /// </summary>

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 显示子窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A a = new A();

            a.MdiParent = this;

            a.Show();

            B b = new B();

            b.MdiParent = this;

            b.Show();

            C c = new C();

            c.MdiParent = this;

            c.Show();

        }

        private void 横向排序ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void 纵向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}

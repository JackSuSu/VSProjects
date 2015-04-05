using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _01WinForm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// 
        /// 在Main函数当中，创建的窗体对象 我们称之为主窗体
        /// 
        /// 也就是将主窗体关闭的时候 整个应用程序就关闭了
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 fr = new Form1();
            Test.fmMain = fr;
            Application.Run(fr);
        }
    }
}

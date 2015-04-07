using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _11进程概念
{
    class Program
    {

        /// <summary>
        /// 
        /// 进程
        /// 
        /// 操作进程类 Process
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {

            Process pro = new Process();


            //获取当前所有正在运行的进程

           Process[] pros=  Process.GetProcesses();


            //进程打开应用程序


           Process.Start("calc");

            //画图工具

           Process.Start("mspaint");


            //打开记事本

           Process.Start("notepad");


            //打开网页

           //Process.Start("http://www.baidu.com");


            //通过进程打开指定文件

           Process ps = new Process();

           ps.StartInfo = new ProcessStartInfo(@"C:\users\sulongfeng\desktop\stringtest.txt");

           ps.Start();



           //foreach (var item in pros)
           //{

           //    //关闭进程           

           //    Console.WriteLine(item);


           //}

           //pros[0].Kill();
          

           Console.Read();

        }
    }
}

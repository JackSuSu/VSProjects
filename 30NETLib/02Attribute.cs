using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace _30NETLib
{

    [Serializable]
    class _02Attribute
    {

        [DllImport("User32.dll")]

        public static extern int MessageBox(int hparent, string Message, string cation, int type);

        static void Mains(string[] args)
        {
            //MessageBox(0, "Hello", "Message", 0);

            DisplayRuningMsg();

            DisplayDebugMsg();

            Person p = new Person();

            p.GetPersonInfo();

            Console.ReadKey();
        }

        [Conditional("Debug")]
        static void DisplayRuningMsg()
        {
            Console.WriteLine("开始运行Main子程序当前时间为：", DateTime.Now);
        }


        [Conditional("Debug")]
        //[Obsolete]
        static void DisplayDebugMsg()
        {
            Console.WriteLine("开始Main子程序");
        }

        

     

    }


    /// <summary>
    /// 
    /// 只能当道类上面使用
    /// 
    /// </summary>

    [AttributeUsage(AttributeTargets.Class)]
    public class ClassTargetAttribute : Attribute
    {

        public ClassTargetAttribute(string name)
        {
           
        }
 
    }



    public class MyFirstAttribute : Attribute
    {

        private string msg;

        public string MSG
        {
            get { return msg; }
            set { msg = value; }
        }


        public MyFirstAttribute(string _msg)
        {
            MSG = _msg;
        }

    }

    [MyFirstAttribute("第一个Attribute")]
    public class Person
    {

       public void GetPersonInfo()
        {
            var attributes = typeof(Person).GetCustomAttributes(typeof(MyFirstAttribute), true);

            MyFirstAttribute mytrri=attributes[0] as MyFirstAttribute;

            if (attributes != null)
            {
                Console.WriteLine(mytrri.MSG);             
            }

        }
 
    }







}

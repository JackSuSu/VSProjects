using _17访问修饰符02;
using System;
using System.Collections.Generic;
using System.Text;

namespace _17访问修饰符
{
    class Program
    {

        /// <summary>
        /// 
        /// 已经解除的访问修饰符
        /// 
        /// public :公开的
        /// 
        /// private :私有的
        /// 
        /// protect：只能在自身或者子类中使用
        /// 
        /// internal:只有程序集本身可以访问
        /// 
        /// protected internall 共五个访问修饰符
        /// 
        /// 能修饰类的修饰符只有public 和 internal
        /// 
        /// Class 默认的Internal 当前程序集可以使用
        /// 
        /// 同一个程序集中：internal 比 projected 访问权限高
        /// 
        /// 不同程序集中：继承类的protected的修饰级别 可以传递跨程序集
        /// 
        /// 可访问性不一致
        /// 
        /// 子类的访问的权限不能高于父类的访问权限
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {

            Test test = new Test();

            if (test.NullData == null)
            {
                Console.WriteLine("NUllData 是没有赋值的类型！");
            }
            else
            {
                Console.WriteLine("NullData 赋值了！");
            }

            Console.ReadKey();

         }



    }


    public class Test : Student
    {
        public void showdata()
        {
            _name = string.Empty;
        }
    }



    public class Parent
    {
 
    }

    public class Child : Parent
    {
 
    }




}

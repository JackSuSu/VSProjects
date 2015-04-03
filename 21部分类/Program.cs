using System;
using System.Collections.Generic;
using System.Text;

namespace _21部分类
{

    /// <summary>
    /// 
    /// Partial 部分类
    /// 
    /// 两个类都是Person的一部分 相互使用 相互利用
    /// 
    /// 两个人可以同时操作同一个类而且方便（方法名一样 编译通过 调用会指向不明）
    /// 
    /// Sealed 密封类
    /// 
    /// 密封类不能被继承，但是可以继承别人
    /// 
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            p1.Print();

            p1.ToString();

            Console.ReadKey();
        }
    }


    public partial class Person
    {

        private string _name;

        private int intdata;

        public int IntData
        {
            get { return intdata; }
            set { intdata = value; }
        }


        //public void Print()
        //{
        //    Console.WriteLine("lisi");
        //}

    }



    public partial class Person
    {
        public void Print()
        {
            _name = "zhangsan";

            Console.WriteLine(_name);
        }

        public override string ToString()
        {

            return _name;
            //return base.ToString();
        }



 
    }



    public sealed class PersonMan
    {
 
    }


    //public class Student : PersonMan
    //{
 
    //}


}

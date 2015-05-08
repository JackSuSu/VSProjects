using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _30NETLib
{


    /// <summary>
    /// 
    /// 总结一下：==  和equal区别
    /// 
    /// == 判断类型和值内容一致方可
    /// 
    /// equal 是对比两个对象Object类型
    /// 
    /// </summary>

    class Program
    {
        static void Mains(string[] args)
        {

            #region 代码

            
            //EquasExample ex = new EquasExample();

            //int hascode=ex.GetHashCode();

            //EquasExample ex2 = new EquasExample();

            //int hascode2 = ex2.GetHashCode();

            ////Console.WriteLine("EX1 HashCode:{0},EX2 Hashcode:{1}", hascode, hascode2);

            ////Console.WriteLine(ex.Equals(ex2));

            ////Console.WriteLine(Object.ReferenceEquals(ex, ex2));

            //int age = 10;

            //short newage = 10;

            //Console.WriteLine(age == newage);


            //string aa = "123456";

            //string bb = "123456";

            //int hs1 = aa.GetHashCode();

            //int hs3 = bb.GetHashCode();

            //Console.WriteLine(aa == bb);

            //Console.WriteLine(aa.Equals(bb));

            //string strb = string.Copy(bb);

            //Console.WriteLine(object.ReferenceEquals(aa, bb));

            //Console.WriteLine(object.ReferenceEquals(strb, bb));

            //object ob = ex;

            //Console.WriteLine(ex2 == ex);

            //Console.WriteLine(ex2.Equals(ex));


            //aa = aa + "123456";

            //Console.WriteLine(aa + bb);

            //StringBuilder stb = new StringBuilder();

            //stb.Append("1234");

            //stb.Append("56789");


            //int data1 = 100;

            //short data2 = 100;

            //int data3 = (int)data2;

            ////string data3 = "100";

            //int datahc1 = data1.GetHashCode();

            //int dataHc2 = data2.GetHashCode();

            ////Console.WriteLine(data1 .Equals(data3));

            //Console.WriteLine(object.Equals(data2, data1));

            //Console.WriteLine(data1.Equals(data2));


            //class1 c1 = new class1();

            //c1.Age = 10;

            //class1 c2 = new class1();

            //c2.Age = 10;

            //Console.WriteLine(c1.Equals(c2));

            //Console.WriteLine(object.ReferenceEquals(c1, c2));


            //string strA = "Hello";

            //string strB = string.Copy(strA);

            //Console.WriteLine(strA == strB);         //True

            //Console.WriteLine(strA.Equals(strB));    //True

            //Console.WriteLine(object.Equals(strA, strB));    //True

            //Console.WriteLine(object.ReferenceEquals(strA, strB));       //False


            #endregion



            #region 其他方法使用


            //1.对于值类型 ==和equal等价，比较存储信息

            int data1 = 10;

            short data2 = 10;

            Console.WriteLine(data1 == data2);

            Console.WriteLine(data1.Equals(data2));

            Console.WriteLine(data2.Equals(data1));

            //2.对于string 类要做特殊处理，他是一个已经封装好的equals方法和==的类，故==和equals等价，都是比较存储信息的内容


            string string1 = "abc";

            string string2 = "abc";

            string string3 = string.Copy(string1);

            Console.WriteLine(string1==string2);

            Console.WriteLine(string1.Equals(string2));


            Console.WriteLine(string3 == string1);

            Console.WriteLine(string3.Equals(string1));





            //3.对于引用类型 ==比较的栈中的地址 equals方法比较的是引用类型托管堆中的存储信息内容


            class1 c1 = new class1();

            c1.Age = 10;

            class1 c2 = new class1();

            c2.Age = 10;

            Console.WriteLine(c1 == c2);

            Console.WriteLine(c1.Equals(c2));


           




            #endregion





            Console.ReadKey();

        }
    }

    #region Equals实质

    class EquasExample
    {

        public int AA = 10;

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }


    class class1
    {

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

 
    }

    


    #endregion
}

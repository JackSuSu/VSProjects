using System;
using System.Collections.Generic;
using System.Text;

namespace _19值类型和引用类型
{



    class Program
    {

        /// <summary>
        /// 
        /// 1.值类型：bool int double decimal char struct enum
        /// 
        /// 2.引用类型：string 数组 class 集合 object 接口
        /// 
        /// 内存三块：栈+堆+静态存储区
        /// 
        /// 类似C语言的指针
        /// 
        /// 在内存栈 数据是不停的开辟，堆是共享数据类型
        /// 
        /// 类的数据定义实在栈上，而示例对象是在堆上数据 GC自动回收
        /// 
        /// 对象赋值给一个类型是 把这个类型指向堆中的内存地址
        /// 
        /// </summary>
        /// 
        /// <param name="args"></param>

        static void Main(string[] args)
        {

            //值数据示例

            int n1 = 10;

            int n2 = n1;

            n2 = 20;

            Console.WriteLine(n1);

            Console.WriteLine(n2);


            //引用类型示例

            Person p1 = new Person();

            p1.Name = "张三";

            Person p2 = p1;

            p2.Name = "李四";


            Console.WriteLine(p1.Name+p2.Name);


            //特殊引用类型示例String

            //字符串是引用类型，但是字符串是特殊的 ，值不可变性

    

           

            string str1 = "zhangsan";

            string str2 = str1;

            str2 = "lisi";

            Console.WriteLine(str1+str2);


            //Ref 讲解：

            //Ref 是将栈中的地址复制一份给另外一个变量

            //栈中操作的同一块地址（Ref把值类型转换引用地址）

            int number = 10;

            TestNum(ref number);




            Console.WriteLine(number);


            Console.ReadKey();           

        }


        static int TestNum(ref int data)
        {
            data += 10;

            return data;
        }


        /// <summary>
        /// 
        /// 实参是上面传递的
        /// 
        /// 形参是函数的（形参类型在内存栈上开辟空间）
        /// 
        /// </summary>
        /// <param name="pp"></param>


        static void Test(Person pp)
        {

            Person p = pp;

            p.Name = "王五";
 
        }


    }


    public class Person
    {

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


 
    }


}

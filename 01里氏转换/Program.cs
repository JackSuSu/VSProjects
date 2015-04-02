using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01里氏转换
{

    /// <summary>
    /// 
    ///     里氏转换
    ///     
    /// 1.子类可以赋值给父类(如果有一个地方需要一个父类作为参数，我们可以给一个子类代替)
    /// 
    /// 2.如果父类中装的是子类对象，那么可以将父类强转为子类对象
    /// 
    /// 
    ///     子类父类方法
    /// 
    /// 1.子类可以调用父类的方法
    /// 
    /// 2.但是父类永远只能调用自己的方法
    /// 
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();

            stu.SayHello();

            stu.StuSayHello();


            ///子类赋值给父类 典型代表 Object

            Person per = stu;

            //等同

            Person pers = new Student();

            //如果父类中装的是子类对象

            //那么可以将父类强转为子类对象(里氏转换)

            Student ss = (Student)per;

            ss.StuSayHello();


            //不能转换，转化错误 per 是Student 类

            //Teacher tea = (Teacher)per;

            //tea.TeaSayHello();



            //使用关键字 

            //is (类型转换) as（类型转化）

            //如果转化成功就是true 否则返回一个false


            // is 用法

            if (per is Teacher)
            {

                Teacher tea = (Teacher)per;

                Console.WriteLine("转换成功！");

                tea.TeaSayHello();

            }
            else
            {
                Console.WriteLine("转换失败！");
            }



            //as 用法 null 否则转换成功


            Teacher teacher = per as Teacher;

            if (teacher == null)
            {
                Console.WriteLine("里氏转换不成功！");
            }
            else
            {
                Console.WriteLine("里氏转换成功！");

            }


            //String.Join的方法 数组object

            string output = string.Join("|", new string[] { "1", "2", "3" });

            Console.WriteLine(output);


            Random rm = new Random();


            //1~7随机数产生 1～6 个数字 随机数


            int number = rm.Next(1, 7);

            Console.WriteLine(number);



            Console.ReadKey();


        }
    }



    public class Person
    {
        public void SayHello()
        {
            Console.WriteLine("Hello 我是人类");
        }
    }

    public class Student : Person
    {
        public void StuSayHello()
        {

            Console.WriteLine("Hello 我是学生");
 
        }
    }




    public class Teacher : Person
    {
        public void TeaSayHello()
        {

            Console.WriteLine("Hello 我是老师");

        }
    }



}

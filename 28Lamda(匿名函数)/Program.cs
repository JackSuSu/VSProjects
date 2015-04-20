using System;
using System.Collections.Generic;
using System.Text;

namespace _28Lamda_匿名函数_
{

    public delegate void DelOne();

    public delegate void DelTwo(string name);

    public delegate string DelThree(string name);

    class Program
    {
        static void Main(string[] args)
        {

            //实质：匿名函数，lamda表达式 匿名函数更为简洁的写法

            DelOne delone2 = delegate() { };

            DelOne delone1 = () => { };


            //第二种写法

            DelTwo deltwo = delegate(string name) { };

            DelTwo deltwo2 = (string name) => { };


            //第三种写法

            DelThree delthree = delegate(string name) { return name; };

            DelThree delthree2 = (string name) => { return name; };


            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //移出大于4的所有 数据

            list.RemoveAll(n =>  n > 4);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

           

        }
    }
}

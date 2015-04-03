using System;
using System.Collections.Generic;
using System.Text;

namespace _18简单工厂模式示例
{

    /// <summary>
    /// 
    /// 1.设计模式：设计项目的一种方式。
    /// 
    /// 盖楼图纸，开发设计图纸，牛人总计23中设计模式，23个
    /// 
    /// 简单工厂模式（用户需求：定制）
    /// 
    /// 示例：买电脑-->各种各样的品牌（宏基，联想，IBM笔记本等等）
    /// 
    /// 抽象多态 实现 父类是抽象出来的笔记本，子类重写父类的方法实现多态
    /// 
    /// 
    /// 打折：各种折扣 父类--子类
    /// 
    /// 
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("请输入你想要的笔记本：");

            NoteBook nbook=GetNoteBook(Console.ReadLine());

            nbook.SayHello();

            Console.ReadKey();



        }

        static NoteBook GetNoteBook(string inputdata)
        {


            NoteBook nbook=null;

            switch (inputdata)
            {
                case "1":
                    nbook = new Acer();
                    break;

                case "2":
                    nbook = new IBM();
                    break;

                case "3":
                    nbook = new Lenove();
                    break;                   
            }

            return nbook;

        }

    }


    internal abstract class NoteBook
    {
        public abstract void SayHello();      
    }


    internal class Acer : NoteBook
    {

        public override void SayHello()
        {

            Console.WriteLine("我是宏基笔记本电脑！");

        }
    }





    internal class IBM : NoteBook
    {

        public override void SayHello()
        {

            Console.WriteLine("我是IBM笔记本电脑！");

        }
    }


    internal class Lenove : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是联想笔记本电脑！");
        }
    }

}

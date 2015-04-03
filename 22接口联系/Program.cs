using System;
using System.Collections.Generic;
using System.Text;

namespace _22接口联系
{
    class Program
    {

        /// <summary>
        /// 
        /// 麻雀会飞，鹦鹉会飞，鸵鸟不会飞，企鹅会飞，直升飞机会飞（有飞的能力）
        /// 
        /// 用多态实现
        /// 
        /// 需要方法，抽象类，接口
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
        }


    }


    public class Bird
    {
        public string wings
        {
            get;
            set;
        }
        public void EatDrink()
        {
            Console.WriteLine("吃喝拉撒");
        }
    }

    public class MaQue : Bird,IFlyable
    {

        public void Fly()
        {
            Console.WriteLine("我麻雀我会飞");          
        }
    }

    public class YingWu : Bird, IFlyable,ISpeak
    {

        public void Fly()
        {
            Console.WriteLine("鹦鹉会飞");
            //throw new NotImplementedException();
        }

        public void Speak()
        {
            Console.WriteLine("鹦鹉会说话");
            //throw new NotImplementedException();
        }
    }

    public class TuoNiao : Bird
    {
 
    }

    public class QiE : Bird
    {
 
    }



    /// <summary>
    /// 
    /// 接口能力1.IFly,ISpeak
    /// 
    /// </summary>

    public interface IFlyable
    {
        void Fly();
 
    }


    public interface ISpeak
    {
        void Speak();
    }

}

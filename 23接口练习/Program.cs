﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _23接口练习
{
    class Program
    {
        /// <summary>
        /// 
        /// 
        /// 前提已经提供给我们几个类了 
        /// 
        /// A.什么时候用虚方法实现多态
        /// 
        /// 如果能找出一个父类，并且父类必须写出子类共有的方法，且父类知道怎么写这个方法，父类需要创建对象，这个时候用虚方法。
        /// 
        /// 1.父类和子类有共同信息和行为，父类需要实例化，父类和子类的行为不确定
        /// 
        /// 动物（可以吃饭）人（吃米饭）猪（吃粗粮）狗（狗粮）猫（猫粮）
        /// 
        /// 
        /// B.什么时候用抽象类实现多态
        /// 
        /// 
        /// 如果能抽象出一个父类，并且父类必须写出子类共有的方法，然后又不是很清楚什么方法，这个时候用抽象类。
        /// 
        ///  例：人类（说语言） 中国人（基本信息+说中国话）日本人（基本信息+日语）
        /// 
        /// 
        ///C. 什么时候使用接口实现多态
        /// 
        /// 
        /// 给定的类中根本找不出父类，但是他们都有一个共同的行为，功能的能力，这个时候就可以用接口
        /// 
        /// 例：麻雀会飞，鹦鹉会飞，直升飞机会飞（会飞是一种能力，但是这几个类没有父类）
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {

            //真的鸭子会游泳 木头鸭子不会游泳 橡皮鸭子会游泳（侧重能力用接口）

            ISwimming sw = new RealDuck();

            sw.Swim();

            ISwimming sw2 = new XPDuck();

            sw2.Swim();

            Console.ReadKey();

        }


        public class RealDuck:ISwimming
        {

            public void Swim()
            {
                Console.WriteLine("真的鸭子会游泳！");
            }
        }


        public class MuDuck
        {
 
        }


        public class XPDuck :  ISwimming
        {

            public void Swim()
            {
                Console.WriteLine("橡皮鸭子飘着游泳！");
            }
        }


        public interface ISwimming
        {
            void Swim();

        }

    }
}

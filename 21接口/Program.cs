using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21接口
{
    class Program
    {

        /// <summary>
        /// 
        ///     多态的另一种形式叫做接口
        /// 
        /// 理解：
        /// 
        /// 1.接口即使一种规范
        /// 
        /// （USB各个厂家，品牌必须遵循USB的规范，必须能使用USB的拓展）
        /// 
        /// 2接口也是一种能力
        /// 
        /// 继承一个接口就可以用了，就有这个能力了
        /// 
        /// 语法：[public] interface 名称（以I....able 表示某种能力）
        /// 
        /// 问题：一个人类即想扣篮又想做学生
        /// 
        /// 什么时候使用接口？
        /// 
        /// 1.多继承的时候 即想这样又想那样
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {


         
        }
    }


    /// <summary>
    /// 
    ///  自动属性和普通属性的区别
    /// 
    /// ildasm
    /// 
    /// </summary>

    public class Person
    {



        private string name;

        /// <summary>
        /// 
        /// 普通属性
        /// 
        /// </summary>

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        /// <summary>
        /// 
        /// 自动属性
        /// 
        /// 编译后系统会自动生成私有属性
        /// 
        /// </summary>
        public string NameData
        {
            get;
            set;
        }
        

        public void CHLS()
        {
            Console.WriteLine("吃喝拉撒睡！");
        }
    }

    public class NBAPlayer : Person
    {
        public void couLan()
        {
            Console.WriteLine("我会扣篮！");
        }
    }



    public class Student : Person,ICouLanable
    {

        public void KouLan()
        {
            Console.WriteLine("我可以扣篮！");
        }
    }


    /// <summary>
    /// 
    /// able 在英语中是拥有某种能力
    /// 
    /// </summary>

    public interface ICouLanable
    {
        void KouLan();
    }


    /// <summary>
    /// 
    /// 接口的定义
    /// 
    /// </summary>

    public interface IFlyable
    {
        /// <summary>
        /// 
        /// 接口方法默认PUBLIC
        /// 
        /// 方法可以有返回值
        /// 
        /// </summary>

        void Fly();

        //没有方法体

        //不能写字段

        //可以写属性

        string name
        {
            get;
            set;
        }

    }

}

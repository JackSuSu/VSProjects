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
        /// 理解：接口可以集成接口,接口显示实现可以避免接口和类的方法名相同的情况，类中默认的访问修饰符是 private 接口中默认的是public
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
        /// 什么时候使用接口？(面向接口的编程，手机APP 天机APP，数据从哪里？中央气象台，从中央气象实现接口，就可以拿到信息，就可以拿到信息)
        /// 
        /// （支付宝接口，图书商场淘宝，实现接口就可以实现里面的功能）
        /// 
        /// 1.多继承的时候 即想这样又想那样
        /// 
        /// 2.
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //ICouLanable coulan = new NBAPlayer();

            //coulan.KouLan();

            IFlyable ip = new Person();

            ip.Fly();

            IFlyable ib = new Bird();

            ib.Fly();

            IFlyable iss = new Student();

            iss.Fly();

            Console.ReadKey();
         
        }
    }


    /// <summary>
    /// 
    ///  自动属性和普通属性的区别
    /// 
    /// ildasm
    /// 
    /// </summary>

    public class Person:IFlyable
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

        public void Fly()
        {

            Console.WriteLine("人类在飞！");
           // throw new NotImplementedException();
        }

        string IFlyable.name
        {
            get;
            set;
        }
    }

    public class NBAPlayer : Person,ICouLanable,IFlyable
    {
     

        public void KouLan()
        {
            Console.WriteLine("我会扣篮！");
        }

        void IFlyable.Fly()
        {

            Console.WriteLine("学生在飞！");

           // throw new NotImplementedException();
        }
        string IFlyable.name
        {
            get;
            set;
        }
    }



    public class Student : Person, ICouLanable, IFlyable
    {

        public void KouLan()
        {
            Console.WriteLine("我可以扣篮！");
        }

        public void Fly()
        {

            Console.WriteLine("学生在飞！");
          //  throw new NotImplementedException();
        }

        public string name
        {
            get;
            set;
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
    /// 接口不能被实例化（静态类，接口，抽象类）
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

        //可以写属性(自动属性)

        string name
        {
            get;
            set;
        }

    }


    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟在飞！");
          //  throw new NotImplementedException();
        }

        public string name
        {
            get;
            set;
        }
    }



    public interface M1
    {
        void Test1();
    }

    public interface M2
    {
        void Test2();
    }

    public interface M3
    {
        void Test3();
    }


    public interface SupperInterface : M1, M2, M3
    {
 
    }


    public class TestClass : SupperInterface
    {

        public void Test1()
        {
            throw new NotImplementedException();
        }

        public void Test2()
        {
            throw new NotImplementedException();
        }

        public void Test3()
        {
            throw new NotImplementedException();
        }
    }

    public class Test2Class : TestClass 
    {

    }



}

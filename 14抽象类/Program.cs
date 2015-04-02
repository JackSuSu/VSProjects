using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14抽象类
{
    class Program
    {

        /// <summary>
        /// 
        /// 案例提示：狗狗会叫，猫猫也会叫，将来可能会有其他动物加入，但是都是叫 没有共同点
        /// 
        /// 当父类的方法不知道如何去实现的时候
        /// 
        /// Visual 方法没有 父类，可以考虑将父类类写成抽象类，把虚拟方法写成抽象方法
        /// 
        /// </summary>
        /// 
        /// 抽象类不允许创建对象
        /// 
        /// 接口类也不允许创建对象
        /// 
        /// 抽象类是有构造函数的虽然 么能创建对象实例化
        /// 
        /// 抽象类方法签名必须一致（也就是方法的类型和方法的参数必须一致）
        /// 
        /// 多态实现：
        /// 
        /// 1.父类方法中有默认的实现，并且父类需要被实例化，这时候将父类看成一个普通的类，用虚方法实现多态
        /// 
        /// 2.如果父类中没有默认实现，并且不需要被实例化，则可以将该类定义为抽象类
        /// 
        /// 
        /// 如果类中有抽象的成员，抽象方法就是用抽象类，如果没有就使用普通的方法
        /// 
        /// <param name="args"></param>

        static void Main(string[] args)
        {

            //Dog dog = new Dog();

            //dog.Bark();

            //Cat cat = new Cat();

            //cat.Bark();



            //虚方法和抽象的区别：抽象方法没有实现，虚方法里面有实现


            Animal an = new Dog();

            an.Bark();

            an = new Cat();

            an.Bark();



            Console.ReadKey();

        }


        public abstract class Animal
        {

            /// <summary>
            /// 
            /// 为什么写成抽象方法，因为我们根本不知道方法怎么实现
            /// 
            /// 没有方法体{  }大括号代表方法体
            /// 
            /// 使用抽象方法，不知道怎么去写，但是要做 比如所有的人都说话，但是说的话是什么语言不知道，但是每个国家都有自己的语言，
            /// 
            /// 自然的就可以拿一个人出来就可以说一个国家的语言（都知道的事情，但是只有结合具体情况才能说出口）
            /// 
            /// 抽象类中可以添加非抽象成员（子类可以使用，继承方法使用）
            /// 
            /// 如果子类也是抽象类，那么就不用重写父类的方法和属性
            /// 
            /// </summary>

            public abstract void Bark();



            public virtual void TestVisual()
            {

                Console.WriteLine("动物有生命！");
 
            }



            /// <summary>
            /// 
            /// 抽象属性
            /// 
            /// </summary>

            public abstract string Name
            {
                get;
                set;
            }



            private string barkup;

            public string BarkUp
            {
                get { return barkup; }
                set { barkup = value; }
            }


            public abstract string TestString(string strname);
           



        }




        public abstract class Test : Animal
        {

            public override void Bark()
            {
                throw new NotImplementedException();
            }

            public override string Name
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public override string TestString(string strname)
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// 
        /// Dog类的使用
        /// 
        /// </summary>

        public class Dog : Animal
        {


            public override void Bark()
            {

                Console.WriteLine("狗狗叫：汪汪汪");

                //throw new NotImplementedException();
            }


            public override string Name
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }



            public override string TestString(string strname)
            {
                throw new NotImplementedException();
            }
        }


        public class Cat : Animal
        {
            public override void Bark()
            {

                Console.WriteLine("猫猫叫：喵喵喵");
                //throw new NotImplementedException();
            }

            public override string Name
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }
            }

            public override string TestString(string strname)
            {
                throw new NotImplementedException();
            }
        }



    }
}

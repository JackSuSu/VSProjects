using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13面向对象多态
{
    class Program
    {

        /// <summary>
        /// 
        ///  多态：让一个对象表现出多个状态
        /// 
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {


            

            Person cn1 = new Person("韩梅梅");

            Person cn2 = new Person("李雷");

            Janpanese j1 = new Janpanese("树下君");

            Janpanese j2 = new Janpanese("树下君2");

            Korea k1 = new Korea("锦绣苋");

            Korea k2 = new Korea("锦绣苋2");

            American a1 = new American("科比");

            American a2 = new American("奥尼尔");

            Person[] pers = { cn1, cn2, j1, j2, k1, k2, a1, a2 };

            for (int i = 0; i < pers.Length; i++)
            {

                //虚方法的多态

                //虚方法可以实现子类的重写，子类赋值给父类可以用父类类型，调用子类的方法

                pers[i].SayHello();
         

            }




            // 如果一个想表现出父类的方法  加上一拖判断方法

            // 多态可以表现出来类型

            //多态有三种表示方法

            //A.虚方法 （子类可以重写） 

            //Visual 和 Override 调用的方法依然是父类的SayHello,但是子类Override重新写了一遍 这是执行的是子类的方法，
            
            //具体是那个子类那么那么看父类装的是那个子类
            


            //1.调用依然是父类的sayhello
            
            //2.先判断是否是虚方法 
            
            //3.判断父类里面装载的是那个子类 
            
            //4.执行子类的SayHello

            //子类可以重写也可以不重写 在继承关系中 父类和子类都有类似的方法 称之为多态
            
            //这样就减少很多的代码 案例 真的鸭子嘎嘎叫，木头鸭子嘎嘎叫，橡皮鸭子嘎嘎叫




            //B.抽象类 

            //3.接口

            //如果想用父类 调用 子类的方法（假象） 这样就实现多个类型同时调用 多态

            //减少类型的判断 将父类的方法标记为虚方法




            Console.ReadKey();

        }





        public class Person
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }


            private int age;

            public int Age
            {
                get { return age; }
                set { age = value; }
            }


            public Person(string names)
            {

                this.Name = names;

            }

            public virtual void SayHello()
            {
                Console.WriteLine("我是人类，我叫：{0}", Name);
            }


        }


        public class Chinese : Person
        {
            public Chinese(string names)
                : base(names)
            {
 
            }

            public override void SayHello()
            {
                Console.WriteLine("我是中国人，我叫：{0}", Name);
            }
        }


        public class Janpanese : Person
        {
            public Janpanese(string names)
                : base(names)
            {
 
            }

            public override void SayHello()
            {
                Console.WriteLine("我是日本人,我叫：{0}", Name);
            }
        }


        public class Korea : Person
        {

             public Korea(string names)
                : base(names)
            {
 
            }

            public override void SayHello()
            {
                Console.WriteLine("我是韩国人,我叫：{0}", Name);
            }
 
        }
        

        public class American : Person
        {

            public American(string names)
                : base(names)
            {
 
            }

            public override void SayHello()
            {
                Console.WriteLine("我是美国人,我叫：{0}", Name);
            }
 
        }



    }
}

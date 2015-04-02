using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendClass
{
    class Program
    {
        static void Main(string[] args)
        {


            Person stu = new Person("Sulongfeng", 25);

            //stu.PrintInfo();


            // Stu的其他方法是Object里面的方法

            //stu.GetHashCode();

            //stu.GetType();

            //stu.ToString();

            stu.SayHello();

            Teacher tea = new Teacher("liyadan", 24, 3500);

            //tea.PrintInfo();

            tea.SayHello();
            
            Console.ReadKey();

           

        }

    }


    public class Person
    {

        public int Age { get; set; }
        public string Name { get; set; }
        public Person(string name, int age)
        {
            this.Age = age;

            this.Name = name;
        }


        private  int myVar;

        protected int ProtecteData
        {
            get { return myVar; }
            set { myVar = value; }
        }

   

        public virtual void PrintInfo()
        {
            Console.WriteLine("我是父类，我的名字叫:{0},年龄{1}", Name, Age);
        }

        public void SayHello()
        {
            Console.WriteLine("Same Function 父类~");
        }

        /// <summary>
        /// 
        /// 析构函数 结束时调用垃圾回收器 
        /// 
        /// </summary>

        ~Person()
        {
            Console.WriteLine("析构函数 结束时调用垃圾回收器");
        }

        /// <summary>
        /// 
        /// 构造函数 调用本地构造函数 自动填充
        /// 
        /// 防止代码冗余
        /// 
        /// </summary>
        /// <param name="age"></param>

        public Person(int age)
            : this(string.Empty, 15)
        {

        }



        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡叫！");
        }


    }


    /// <summary>
    /// 
    /// 集成的好处的
    /// 
    /// 1.减少代码的融入
    /// 
    /// 2.父类修改比较容易
    /// 
    /// 3.Protect 只允许在子类的方法中使用
    /// 
    /// 4.只能继承一个父类/单根性
    /// 
    /// 5.集成具有传递性 子类可以一直传递下去
    /// 
    /// 6.查看类图
    /// 
    /// 7.构造函数父类必须有一个 无参数的构造函数
    /// 
    /// （默认是包含无参数构造函数，书写一个构造函数后会把 有参数的函数给覆盖掉）
    /// 
    /// 8.继承中子类没有集成父类的构造函数 且 父类必须有一个 空的构造函数
    /// 
    /// 9.继承构造函数执行过程：创建子类对象 会在 子类中创建一个父类的对象 这个时候子类才能使用
    /// 
    /// 父类内的属性方法（所以参考第8点） 所以构造函数执行方法为：子类先执行构造函数 然后 立即跳到父类的构造函数
    /// 
    /// 然后再回到子类的构造函数 这样就生成两个对象即：父类对象和子类对象 因为只有两个一起才完整
    /// 
    /// 10.子类调用父类的构造函数方法使用Base() 
    /// 
    /// 11.子类可以重写父类的虚拟方法
    /// 
    /// 12.子类方法和父类方法同名，子类方法覆盖了父类方法 产生警告 使用new  关键字屏蔽掉警告（开发过程中避免重名）
    /// 
    /// </summary>


    public class Teacher:Person
    {

        private int salary;

        public int Sarlary
        {
            get { return salary; }
            set { salary = value; }
        }


        /// <summary>
        /// 
        /// 这个构造函数是使用父类的构造函数
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="sarylay"></param>


        public Teacher(string name, int age, int sarylay) : base(name,age) 
        {

            this.Sarlary = sarylay;

        }




        public new void SayHello()
        {
            Console.WriteLine("Same Function 子类~");
        }




        public override void PrintInfo()
        {
            //base.PrintInfo();

            base.PrintInfo();

            Console.WriteLine("我是子类类，我的名字叫:{0},年龄{1},薪水{2},保护数据{3}", Name, Age, this.Sarlary,this.ProtecteData);

            
        }


        //protected override void PrintInfo()
        //{
        //    base.PrintInfo();

        //    Console.WriteLine("我是子类类，我的名字叫:{0},年龄{1},薪水{2}", Name, Age, this.Sarlary);


        //}

 
    }




}

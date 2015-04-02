using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台
{





    #region 枚举类 和结构体
    
    

    public enum Gender
    {
        Male,
        Famal
    }


    public struct Persion
    {
        public string name;

        public int Age;

        public Gender gender;
    }



    #endregion



    class PersionClass
    {
        public int Age { get; set; }

        public string Name { get; set; }

        private string firstName = "无";

        private string secondeName = "无";

        public string ShareData
        {
            get { return "12345678"; }
        }

        public string this[int index]
        {
            get 
            {

                if (index == 1)
                {
                    return firstName;
                }
                else
                {
                    return secondeName;
                }

            }

            set 
            {
                if (index == 1)
                {
                    firstName = value;
                }
                else
                {
                    secondeName = value;
                }
            }
        }


    }



    class Program
    {


        static void Main(string[] args)
        {

            //占位符

            int aaa = 100;

            Console.WriteLine("我艹还是～HelloWorld!{0}", aaa);



            //枚举类

            Gender gender = Gender.Male;

            Console.WriteLine("枚举类使用占位符：{0}", gender);




            //字符转化枚举类

            string genders = "Male";

            Gender gender2 = (Gender)Enum.Parse(typeof(Gender), genders);

            Console.WriteLine("字符串转换成枚举类:{0}", gender2);



            //结构体

            Persion zhangsan;

            zhangsan.name = "zhangsan";

            zhangsan.Age = 21;

            zhangsan.gender = Gender.Male;

            Console.WriteLine("Person结构体 姓名{0},年龄:{1},性别{2}", zhangsan.name, zhangsan.Age, zhangsan.gender);


            //Ref参数

            PersionClass personClass = new PersionClass();

            SetPersion(ref personClass);

            Console.WriteLine("Ref参数的实际使用:姓名{0},年龄{1}", personClass.Name, personClass.Age);


            //可变数组参数参数 多个Params 不允许有多个参数而且必须是最后一个

            ParamTest(22, 11);


            //OUT参数

            int outstringdata;

            if (OutPamams("1234", out  outstringdata))
            {
                Console.WriteLine("Out参数输出stirng转化成INT {0}", outstringdata);
            }
            else
            {
                Console.WriteLine("Out参数输出stirng转化成INT {0}", outstringdata);
            }


            //String 类型 和string 类型的区别


            String UpCaseString = "大写String 类型(这个是.NET 平台的String 类型 各个语言最终生成的类型。（包括C#,VB,F#等等）)";

            string lowcaseString = "小写的string 类型 这个是C#语法语言中特有的关键字，最终string 会转化成 String System.String 下载.net平台运行";

            Console.WriteLine("String System.String 区别{0}", UpCaseString);

            Console.WriteLine("string 关键字数据类型{0}", lowcaseString);

            Console.WriteLine("同理适应其他C#关键字");


            //显示类型转换、自动类型转换

            //int--double   double--int（强制类型准换）

            string str = "123456";

            //将字符串转换成int double

            double dd = Convert.ToDouble(str);

            Console.WriteLine("Convert string 转化成 Double 使用方法{0}", dd);

            int intdata = Convert.ToInt32(str);

            Console.WriteLine("Convert string 转成INt 使用方法{0}", intdata);



            //Convert 数据转换




            //索引器 对比数组


            int[] intarrayData = { 1, 2, 3, 4, 5 };

            int GetOne = intarrayData[1];

            PersionClass p1 = new PersionClass();

            p1[1] = "zhangzhangzhang";

            //属性只读属性

            //p1.ShareData = "ddddd";

            p1[2] = "susususu";


            //常用的String Char取值

            string stringdata = "建设社会主义和谐社会";

            char chardata = stringdata[5];

            Console.WriteLine("索引器的使用：为一个类里面的初始化参数赋值，同时取出内部参数值，多数只只读属性，String 类中，初始化使用String 的方法，但是把内容散花使用索引器,常用的是Char 和 string[N]{0},{1},{2}", p1[1], p1[2], chardata);



            //方法重载

            Add(2.32, 2.12);

            Add(123, 345);


            //泛型交互彼此内容

            string strone = "stringdata1";

            string strtwo = "stringdata2";

            Swap<string>(ref  strone, ref  strtwo);

            Console.Write("泛型交换数据后strone的值为{0},strtwo的值为{1}", strone, strtwo);

            int intdata1 = 123;

            int intdata2 = 456;

            Swap<int>(ref intdata1, ref intdata2);

            Console.Write("泛型交换数据后strone的值为{0},strtwo的值为{1}", strone, strtwo);

            PrintData<int>("泛型交换数据后strone的值为{0},strtwo的值为{1}", intdata2, intdata1);




            #region 字符串的不可变性

            //string names = "苏龙峰呢个";

            //string names3 = "苏龙峰呢个";

            //names = "李鸭蛋";

            #endregion


            //string strdatatata = "K";

            StringBuilder sb = new StringBuilder();

            //创建一个计时器


            //区别 String StringBuilder 

            //String 赋值一次在内存空间开辟一块空间  10万次要开辟十万次空间

            //StringBuilder 操作同一块空间

            Stopwatch SW = new Stopwatch();

            SW.Start();

            //for (int i = 0; i < 100000; i++)
            //{
            //    //strdatatata += i;

            //    sb.Append(i);
            //}

            SW.Stop();

            Console.WriteLine("" + SW.Elapsed);


            string lessonone = "C数学";

            string lessontwo = "c数学";

            if (lessonone == lessontwo)
            {
                Console.WriteLine("你们喜欢的喜欢的课程一致！（==比较）");
            }
            else
            {
                Console.WriteLine("你们喜欢的喜欢的课程不一致！（==比较）");
            }

            if (lessontwo.Equals(lessontwo, StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("你们喜欢的喜欢的课程一致Equal比较）");
            }
            else
            {
                Console.WriteLine("你们喜欢的喜欢的课程一致！（Equal比较）");
            }

            ///String Split

            string filepath = @"C:\Users\sulongfeng\Desktop\stringtest.txt";

            string[] txtstring = File.ReadAllLines(filepath, Encoding.Default);

            for (int i = 0; i < txtstring.Length; i++)
            {
                string[] datastringsss = txtstring[i].Split('\t');

                Console.WriteLine("String的Split方法:{0}|{1}", datastringsss[0], datastringsss[1]);

            }

            ///String Join的使用

            string datastringss = "Hello World Ni Hao!";

            string[] datastringssAarry = datastringss.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("String.Join的使用方法"+string.Join("|", datastringssAarry));


            string emails = "zhangsanfeng@163.com";

            string[] dataemail = emails.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);

            //for (int i = 0; i < dataemail.Length; i++)
            //{


            Console.WriteLine("String的IndexOf方法:{0}|{1}", dataemail[0], dataemail[1]);

            //}

            //string sssss = "abcdefg";

            //char[] chadddd = sssss.ToCharArray();




            Console.ReadKey();
        }





        /// <summary>
        /// 泛型不同数据类型打印
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="words"></param>
        /// <param name="data"></param>

        static void PrintData<T>(string words,params T[] data)
        {

            if (data.Length > 0)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine(words + i.ToString()+":"+ data[i].ToString());
                }
            }

        }




        #region Params 多个参数
        
        

        /// <summary>
        /// 
        /// Params 多个参数参数
        /// 
        /// </summary>
        /// <param name="aa"></param>

        static void ParamTest(params int[] aa)
        {

            Console.WriteLine("Params多参数{0}" ,aa.First<int>() + aa.Last<int>());

        }



        #endregion


        #region Out参数

        static bool OutPamams(string strdata,out int intdata)
        {                     

            try
            {

                intdata = Convert.ToInt32(strdata);

               return true;

            }
            catch
            {

                intdata = 0;

                return false;
 
            }

           

        }

        #endregion


        #region Ref 参数


        static void SetPersion(ref  PersionClass pserson)
        {

            //pserson = new PersionClass();

            pserson.Age = 10;

            pserson.Age += 10;

            pserson.Name = "张三";

           

        }


        #endregion


        #region 方法重载(方法名+参数名 跟方法名的类型没有关系（比如方法中的类型 int add() 和 double add() 不构成重载）)


        static void Add(int n1, int n2)
        {
            Console.WriteLine("Add Int 相加{0}：", n1 + n2);
        }

        static void Add(double d1, double d2)
        {
            Console.WriteLine("Add Double 相加:{0}", d1 + d2);
        }

        static void Add(int n1, int n2, int n3)
        {
 
        }

        #endregion


        #region 泛型的使用


        //Teacher<Student> teacher = new Teacher<Student>();

        static void Swap<T>(ref T one, ref T two) 
        {

            T temp;

            temp = one;

            one = two;

            two = temp;

        }


        #endregion


    }



    public class Student
    {

        public int Age { get; set; }
        public string Name { get; set; }
        public Student(string name, int age)
        {
            this.Age = age;

            this.Name = name; 
        }

        public Student()
        {
            this.Age = 0;

            this.Name = string.Empty;
        }


        /// <summary>
        /// 
        /// 析构函数 结束时调用垃圾回收器 
        /// 
        /// </summary>

        ~Student()
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

        public Student(int age)
            : this(string.Empty, 15)
        {
 
        }

    }




    /// <summary>
    /// 
    /// 构造函数是天然的方法
    /// 
    /// </summary>

    public class Ticket
    {
        //写一个Ticket类,有一个距离属性(本属性只读,在构造方法中赋值),
        //不能为负数,有一个价格属性,价格属性只读,
        //并且根据距离distance计算价格Price (1元/公里):
        //        0-100公里        票价不打折
        //101-200公里    总额打9.5折
        //201-300公里    总额打9折
        //300公里以上    总额打8折

        private double _distance;
        public double Distance
        {
            get { return _distance; }
        }

        public Ticket(double distance)
        {
            if (distance < 0)
            {
                distance = 0;
            }
            this._distance = distance;
        }

        private double _price;
        //        0-100公里        票价不打折
        //101-200公里    总额打9.5折
        //201-300公里    总额打9折
        //300公里以上    总额打8折
        public double Price
        {
            get
            {
                if (_distance > 0 && _distance <= 100)
                {
                    return _distance * 1.0;
                }
                else if (_distance >= 101 && _distance < 200)
                {
                    return _distance * 0.95;
                }
                else if (_distance >= 201 && _distance < 300)
                {
                    return _distance * 0.9;
                }
                else
                {
                    return _distance * 0.8;
                }
            }
        }


        public void ShowTicket()
        {
            Console.WriteLine("{0}公里需要{1}元", Distance, Price);
        }

    }


    public class Teacher<T> where T : class, new()
    {

        public List<T> Students
        {
            get;

            set;
        }

    }


    



}

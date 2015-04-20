using System;
using System.Collections.Generic;
using System.Text;

namespace _27委托
{


    //声明一个委托

    //和方法的类型一样

    public delegate void DelSayHi(string name);

    public delegate int Compare<T>(T o1,T o2);

    class Program
    {

        

        static void Main(string[] args)
        {
            //为什么要使用委托?

            //1.将一个字符串数组中的每个元素 都转换成大写

            //2.将一个字符串数组中每个元素都转换成小写

            //3.将一个字符串数据每个元素的两边都加上双引号

            //三个函数 只有一个地方不一样，而且不能重载参数名一直

            // 所有考虑一个问题：代码冗余

            //写成一个方法：那么就要做一件事情，传递参数，把一个方法作为参数（方法的类型就是委托类型 比如Int a ,string strdata,方法的类型就是委托）

            //委托的概念是什么？

            //委托所指向的函数，必须跟委托具有相同的函数

            //委托实际是把方法名 作为 参数去传递（只想内存的一个方法所在内存地址）


            string[] names = { "abcDEFgH", "IjkLmN", "XyZ" };

            DelSayHi del=new DelSayHi(SayHello);

            //和上个等价

            //DelSayHi del2 = SayHello;

            Test("jack", del);

            Test("Jack", SayHello);






            //匿名函数

            //只用一次没有名字的函数


            Test("Lisi", delegate(string name) { Console.WriteLine("你好，"+name); });


            DelSayHi dles = delegate(string name) { Console.WriteLine("Hellow" + name); };

            dles("Ni Ma!");


            //lamada 表达式 其实 lamada是一个委托匿名函数的简写 =>意思是 goes to

            DelSayHi lamada = (string name) => { Console.WriteLine("Lamada:" + name); };

            lamada("张三三三lamda");


            //泛型委托


            int[] nameint = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            //第一步： 定义集合

            //第二部：调用泛型函数

            //第四步：传入参数和委托要执行的内容

            //第五步：获取结果

            //总结：集合遍历=>然后把共同条件 换成委托 函数=>调用委托函数 返回符合的结果=>返回给集合判断条件=>返回返回值

           int resultint=  GetMaxData<int>(nameint, (int o1, int o2) => {

                return o1 - o2;

            });

            


            Console.WriteLine(resultint);


            string[] namestr={"dafa","dafasdfas","adfasdfasdfas"};

            string stringdata=GetMaxData<string>(names,(string str1,string str2)=>{
            
                return str1.Length-str2.Length;

            });


            Console.WriteLine(stringdata);


            Console.ReadKey();

        }


        static void ProcessToUStr(string[] str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                str[i] = str[i].ToUpper();
            }

        }
        
        static void ProcessToLStr(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = str[i].ToLower();
            }        
        }
        
        static void ProcessGetStr(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = "\"" + str[i] + "\'";
            }
        }


        static void SayHello(string name)
        {
            Console.WriteLine("吃了吗？"+name);
        }

        static void SayHello2(string name)
        {
            Console.WriteLine("Nice to meet you？" + name);
        }


        //接受参数

        static void Test(string name,DelSayHi delsayhi)
        {
            delsayhi(name);
        }



        //泛型委托


        /// <summary>
        /// 
        /// 定义泛型委托返回值
        /// 
        /// </summary>
        /// <typeparam name="T">返回值类型</typeparam>
        /// <param name="nums">传入的</param>
        /// <param name="data">委托类型传入</param>
        /// <returns></returns>


        //第三步定义泛型函数

        static T GetMaxData<T>(T[] nums, Compare<T> data)
        {

            T maxdata = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if(data(maxdata,nums[i])<0)
                {
                    maxdata=nums[i];
                }
            }
            return maxdata;
        }



    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09装箱和拆箱
{
    class Program
    {

        /// <summary>
        /// 
        /// 装箱和拆箱的区别
        /// 
        /// 1.装箱：将值类型转换为引用类型
        /// 
        /// 2.拆箱：将引用类型转换为值类型
        /// 
        /// 3.两种类型是否发生装箱拆箱，要看，这两种类型是否存在继承关系。（要先看他们有没有继承关系，有继承关系有可能有继承）
        /// 
        /// 4.接口也属于引用类型
        /// 
        /// 5.代码中避免装箱和拆箱
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {

            //Stopwatch


            //这个过程装箱 (数值类型转换为引用类型 即 n转换为obj)

            int n = 10;

            object obj = n;


            //这个拆箱 (引用类型转换为值类型 即 obj 转换为 nn)

            int nn = (int)obj;

            ArrayList arryalist = new ArrayList();

            List<int> intdata = new List<int>();


            Stopwatch sp = new Stopwatch();

            sp.Start();

            for (int i = 0; i < 20000000; i++)
            {

                //arryalist.Add(i);

                intdata.Add(i);
                
            }

            sp.Stop();


            //这个地方没有发生任何装箱和拆箱


            string str = "123";

            int num = Convert.ToInt32(str);

            Console.WriteLine(num);


            //有继承关系， Int32 : IComparable 同时只类型转化成引用类型

            int num2 = 100;

            IComparable inmu = num2; //装箱

            //装箱占据很大的时间

            //Console.WriteLine(sp.Elapsed);

            Console.ReadKey();

         



        }
    }
}

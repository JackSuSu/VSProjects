using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ArrayList使用
{


    /// <summary>
    /// 
    /// 集合类的使用
    /// 
    ///  1.ArrayList集合使用
    /// 
    /// 
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            //创建一个集合对象

            //集合 很多东西数据的集合比数组更优越

            //数组：瓶颈 长度不可变，类型单一 同一种类型

            //集合的两大好处 

            //1.长度可以任意改变 类型不固定

            ArrayList arraylist = new ArrayList();

            //里氏转换 放什么类型都可以

            //很爽的地方：放数据

            //不爽的地方：取数据

            //Reverse 反转元素

            //Sort 排序要保证里面的类型相同的 升序排列

            //InsertRange 插入集合累

            //Contains内容包含 是一个Object 类 不区分数据类型 整型的 1 和string "1" 一致

            arraylist.Add(1);

            arraylist.Add(3.124);

            arraylist.Add(true);

            arraylist.Add("zhangsanfeng");

            arraylist.Add(500m);

            arraylist.Remove(true);


            //添加集合用AddRange 添加单个用 Add

            arraylist.AddRange(new string[] { "1", "2", "3" });

            //arraylist.RemoveAt(0);

            //arraylist.Remove(3.124);

            //arraylist.Reverse();



            //arraylist.Sort();

            arraylist.Insert(1, "插入的内容");

            //if (arraylist.Contains(1))
            //{
            //    Console.Write("包含内容");
            //}
            //else
            //{
            //    Console.Write("不包含内容");
            //}
            

            arraylist.InsertRange(2, new List<string> { "zhangsisi", "zhangwuwu" });

      

            //arraylist.Clear();

            for (int i = 0; i < arraylist.Count; i++)
            {
                //Console.WriteLine(arraylist[i]);
            }

    


            // Count  实际集合中的元素个数

            // Capcity 表示集合中可以包含的元素个数

            //ArrayList 每次 COunt 超过 Capcity时候 集合会向内存申请多一倍的空间，来保证集合的长度一直可用

            //ArrayList 优于数组的在于：长度可变


            ArrayList arrayList = new ArrayList();

            Console.WriteLine(arrayList.Count);

            Console.WriteLine(arrayList.Capacity);

            arrayList.Add(1);
            arrayList.Add(1);
            arrayList.Add(1);
            arrayList.Add(1);
            arrayList.Add(1);
            arrayList.Add(1);
            arrayList.Add(1);
            arrayList.Add(1);
            arrayList.Add(1);

            Console.WriteLine(arrayList.Count);

            Console.WriteLine(arrayList.Capacity);


            

           

            Console.ReadKey();
            
        }

    }
}

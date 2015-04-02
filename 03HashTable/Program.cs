using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03HashTable
{
    class Program
    {

        /// <summary>
        /// 
        /// HashTable 跟 ArrayList 使用规则不一致
        /// 
        /// HashTable 称为键值对集合（新华字典 拼音查找法 孙 找 Sun）
        /// 
        /// Var 使用方法（JavaScript 不一致）
        /// 
        /// C# 是一门强类型语言/JS是弱类型语言
        /// 
        /// 强类型语言：在代码当中必须对每一个变量有一个明确定义！
        /// 
        /// int data=15;(每一个变量必须有一个类型)
        /// 
        /// Js弱类型 var data=15; 都可以用var定义
        /// 
        /// C# var 可以使用弱类型 意思是：var可以推断出类型，智能
        /// 
        /// 唯一不爽的地方是什么？答案：var 使用方法是必须初始化 用之前还是要确定类型的
        /// 
        /// 比如：var input;  此行代码无法执明类型，必须初始化 实际上也就执明了类型
        /// 
        /// input ="zhangsan"; 报错 所以很少用 var是推断类型
        /// 
        /// HasTable 【键】 键值唯一 值可以多个
        /// 
        /// </summary>
        /// 
        /// <param name="args"></param>

        static void Main(string[] args)
        {


            #region Var的使用
            
            


            //Var 推断类型

            var vardata = "dsdfasdfs";

            var n = 10;

            var bb = "123";

            var tt = 'b';

            var ts = false;

            var dm = 100m;

            Console.WriteLine(n.GetType());
            Console.WriteLine(bb.GetType());
            Console.WriteLine(tt.GetType());
            Console.WriteLine(ts.GetType());
            Console.WriteLine(dm.GetType());
            Console.WriteLine(vardata.GetType());


            #endregion





            #region Hashtable的使用
            
            


            //创建键值结合对象

            Hashtable ht = new Hashtable();

            ht.Add(1, "zhangsan");


            //不可添加相同键值


            //ht.Add(1, "hahah");

            ht.Add(2, "lisi");

            ht.Add(3, "wangwei");

            ht.Add(false, "又问题");

            ht.Add("4", "Error");

            //如果包含键值 4 那么就可以替换掉

            //如果没有键值 4 那么就添加一个新的键值

            ht[4] = "这也是添加数据的方式";

            //在键值对集合中 是根据键找对应的值

            // HT 下标不是代表元素索引

            //HT 下标代表KEY

            for (int i = 0; i < ht.Count; i++)
            {
                //Console.WriteLine(ht[i]);
            }

            //根据键 去 值

            //ht.IsReadOnly = true;

            ht.Add("dd", "123");

            //foreach 使用 和 for的使用 在数据很小的时候相差不大

            //数据大的时候 for的效率会很高，Foreach会慢

            foreach (var item in ht.Keys)
            {
                Console.WriteLine(ht[item]);
            }

            ht["abc"] = "123";

            if (ht.ContainsKey("abc"))
            {

                ht["abc"] = "1234567";

                Console.WriteLine(ht["abc"]);

               
            }
            else
            {
                Console.WriteLine("没有啊");
            }

            ht.Remove("abc");




            #endregion





            #region for和foreach的区别




            int[] intertgerarry = new int[10000];

            Stopwatch stw = new Stopwatch();

            //02.727

            stw.Start();

            for (int i = 0; i < intertgerarry.Length; i++)
            {
                //Console.WriteLine(intertgerarry[i]);                
            }

            stw.Stop();



            Console.WriteLine(stw.Elapsed);

            stw.Start();

           

            foreach (var item in intertgerarry)
            {
                //Console.Write(item);
            }

            stw.Stop();

            Console.WriteLine(stw.Elapsed);

            //Console.WriteLine(ht[0]);
            //Console.WriteLine(ht[1]);
            //Console.WriteLine(ht[2]);
            //Console.WriteLine(ht[3]);
            //Console.WriteLine(ht[false]);


            #endregion



            #region 根据繁体转换成简体


            string stringdata1 = "123456789";

            string stringdata2 = "ABCDEFGHI";

            Hashtable hts = new Hashtable();

            for (int i = 0; i < stringdata1.Length; i++)
            {
                hts.Add(stringdata1[i], stringdata2[i]);
            }

            //foreach (var item in hts.Keys)
            //{
            //    Console.WriteLine(hts[item]);
                
            //}


            while (true)
            {

                string data = Console.ReadLine();

                if (hts.ContainsKey(data[0]))
                {
                    Console.WriteLine(hts[data[0]]);
                }

                if (data[0] == 'e')
                {
                    break;
                }
                
            }



            #endregion



            Console.ReadLine();

        }
    }
}

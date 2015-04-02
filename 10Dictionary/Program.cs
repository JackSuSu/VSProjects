using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Dictionary
{
    class Program
    {

        /// <summary>
        /// 
        /// 1.
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {

            //定义一个Dictionary的集合

            Dictionary<int, string> dicNaty = new Dictionary<int, string>();

            dicNaty.Add(1, "zhangsan");

            dicNaty.Add(2, "llisi");

            dicNaty.Add(3, "wangwu");



            //dicNaty[1] = "新来的";


            // 键值对集合 和 HashTable 类似

            foreach (KeyValuePair<int, string> kv in dicNaty)
            {
                Console.WriteLine(kv.Key + kv.Value);
            }


            //foreach (var item in dicNaty.Keys)
            //{

            //    Console.WriteLine(item+dicNaty[item]);

            //}


            //将一个数组中的奇数放到一个集合中，将一个偶数放到一个集合中

            //最终将两个结合现实成一个集合，奇数现实在左边，偶数现实在右边


            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> oushu = new List<int>();

            List<int> jishu = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    oushu.Add(nums[i]);
                }
                else
                {
                    jishu.Add(nums[i]);
                }
            }

            jishu.AddRange(oushu);

            //List<int> sum = new List<int>();

            //sum.AddRange(oushu);

            //sum.AddRange(jishu);

            //foreach (int item in sum)
            //{
            //    Console.WriteLine(item);
            //}


            foreach (int item in jishu)
            {
                Console.Write(item);
            }





            //提示用户输入一个字符串，通过Foreach 循环将用户输入的字符串赋值给一个字符数组

            Console.WriteLine("请输入一个字符串");

            string input = Console.ReadLine();

            char[] chs = new char[input.Length];

            int idex = 0;

            foreach (char item in input)
            {
                chs[idex] = item;

                idex++;
            }

            foreach (var item in chs)
            {
                Console.Write(item);
            }



            //统计Welcome to china 中每个字符出现的次数，不考虑大小写。

            string inpudata = "Welcome to china";

            //字符出现的次数

            //键-----》值

            Dictionary<char, int> dicdata = new Dictionary<char, int>();

            foreach (char item in inpudata)
            {
                if (dicdata.ContainsKey(item.ToString().ToLower()[0]))
                {
                    dicdata[item]++;
                }
                else
                {
                    if(item!=' ') //过滤空格
                    dicdata.Add(item, 1);
                }
            }

            Console.WriteLine("请输入内容字符");

            string strinput = Console.ReadLine();

            
            //if (dicdata.ContainsKey(strinput[0]))
            //{
            //    char dd = strinput[0];

            //    Console.WriteLine(dicdata[dd]);
            //}

            foreach (KeyValuePair<char,int> item in dicdata)
            {
                Console.WriteLine("字符{0}出现的次数：{1}次",item.Key,item.Value);
            }


            Console.ReadKey();

        }
    }
}

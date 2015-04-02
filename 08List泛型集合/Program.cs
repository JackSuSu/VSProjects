using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08List泛型集合
{

    /// <summary>
    /// 
    /// List泛型定义 和数据类型类似 int [] aa 里面存放的是 int 类型
    /// 
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {

            //创建泛型集合类型


            List<int> list = new List<int>();

            list.Add(1);

            list.Add(2);

            list.Add(3);

            list.AddRange(new int[] { 4, 5, 6, 7, 8, 9 });

            list.AddRange(list);


            list.Reverse();

            //list.RemoveAll() //拉么大表达式

            foreach (int item in list)
            {

                //Console.WriteLine(item);
                
            }

            //List泛型集合可以转换为数组

            //长度可变，类型固定 集合和数组相互转换


            int[] changeint = list.ToArray();

            List<int> listintchage= changeint.ToList();

            foreach (int item in listintchage)
            {

                Console.WriteLine(item);

            }

            Console.ReadKey();
            


        }
    }
}

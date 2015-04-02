using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12StreamReadWriter
{
    class Program
    {

        /// <summary>
        /// 
        /// File操作小文件
        /// 
        /// 必须知道:FileStream
        /// 
        /// StreamReader SteamWrite
        /// 
        /// StreamRead Write 是操作字符的 文本文件
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {


            //StreamReader 读取一个文件

            string filepath = @"C:\a\b.txt";

            using (StreamReader str = new StreamReader(filepath,Encoding.Default))
            {
                while (!str.EndOfStream)
                {
                    Console.WriteLine(str.ReadLine());
                }   
            }


            //StreamWriter 写入一个文件

            using (StreamWriter strw = new StreamWriter(filepath,true))
            {
                strw.Write("今天天气好晴朗！");
 
            }

            Console.ReadKey();

        }
    }
}

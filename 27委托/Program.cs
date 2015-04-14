using System;
using System.Collections.Generic;
using System.Text;

namespace _27委托
{
    class Program
    {
        static void Main(string[] args)
        {
            //为什么要使用委托

            //1.将一个字符串数组中的每个元素 都转换成大写

            //2.将一个字符串数组中每个元素都转换成小写

            //3.将一个字符串数据每个元素的两边都加上双引号


            string[] names = { "abcDEFgH", "IjkLmN", "XyZ" };

        }


        static void ProcessToUStr(string[] str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                str[i] = str[i].ToUpper();
            }

            //foreach (string item in str)
            //{
            //    item = item.ToUpper();
            //}
        }


        static void ProcessToLStr(string[] str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                str[i] = str[i].ToUpper();
            }

            //foreach (string item in str)
            //{
            //    item = item.ToUpper();
            //}
        }

    }
}

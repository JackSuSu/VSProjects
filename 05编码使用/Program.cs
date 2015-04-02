using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05编码使用
{
    class Program
    {

        /// <summary>
        /// 
        /// 文本文件编码，文本文件有不同的存储方式，将字符串以什么样的形式保存为二进制
        /// 
        /// 就是编码，UTF-8，ASCII,Unicode
        /// 
        /// 计算机产生：二进制存储比如 A：1000110
        /// 
        /// 2.ASC 128 位（美国人够用了）
        /// 
        /// 3.ASC11 256 (东欧国家够用了)
        /// 
        /// 4.全世界都开始用了(GB2312)第一个编码 只有简体字 港澳台（繁体字）
        /// 
        /// 5.BIG5 包括繁体字
        /// 
        /// 最后：美国发现麻烦了，统一编码 Unicode 统一使用，使用很慢，互联网飞速发展后来出来一个Web的编码格式(UTF-8)
        /// 
        /// 将字符串 以怎样的格式保存为二进制。
        /// 
        /// 乱码：原因保存文件所采用的编码和打开文件的编码格式不一致，产生乱码
        /// 
        /// 保存文件采用UTF-8 打开采用的是GB2312 打开后就是乱码
        /// 
        /// 字节数组转换成 字符串 使用
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {


            #region 编码的使用Encoding
            
            

            string strdingdata = "藏";

            byte[] databyte = Encoding.UTF8.GetBytes(strdingdata);

            string resultdata = Encoding.UTF8.GetString(databyte);

            Console.WriteLine(resultdata);


            #endregion




            #region 文件编码的使用



            byte[] readbtye = File.ReadAllBytes(@"C:\a\bbb.txt");

            string dataread = Encoding.Default.GetString(readbtye);

            //Default 是保存时候的编码

            string datagb = Encoding.GetEncoding("GB2312").GetString(readbtye);

            //Unicode 国际统一标准 是由UTF-8 UTF32等等编码格式组成的

            //UTF-8   GB2312 Unicode ASCII

            //GBK 既包含简体又包含繁体 GB2312 只包含


            //有文件覆盖，没有文件创建一个文本文件

            string writestring = "今天天气好晴朗，处处好风光；";

            byte[] writebtye = Encoding.Default.GetBytes(writestring);


            //把字节数组写入到文本文件 其实写了一个字符串

            File.WriteAllBytes(@"C:\a\d.txt", writebtye);




            Console.WriteLine(dataread);





            #endregion


            

            Console.ReadKey();
            


            //Encoding.Default.GetString()
        }
    }
}

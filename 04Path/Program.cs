using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Path
{


    /// <summary>
    /// 
    /// Path类型和文件操作类
    /// 
    /// 
    /// 
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {



            #region System.IO.Path的用法
            
            

            string filepath = @"C:\Users\sulongfeng\Desktop\EIPD服务端安装文件\Data.txt";

            int indexdata = filepath.LastIndexOf("\\");

            string result = filepath.Substring(indexdata + 1);

            Console.WriteLine(result);

            //Path 获取文件名 包含 扩展名

            Console.WriteLine(Path.GetFileName(filepath));

            //Path 获取文件名 文件的全路径

            Console.WriteLine(Path.GetFullPath(filepath));

            //Path 获得文件名不包含扩展名

            Console.WriteLine(Path.GetFileNameWithoutExtension(filepath));

            //Path 获取文件的扩展名

            Console.WriteLine(Path.GetExtension(filepath));

            //Path 获取文件的文件夹的名字

            Console.WriteLine(Path.GetDirectoryName(filepath));

            //Path Combine 组合路径

            Console.WriteLine(Path.Combine(@"c:\a\" + @"b.txt"));


            #endregion


            #region System.IO.File用法


            //创建一个文件，那么重复执行两次代码 创建时间不变，修改时间变了

            //string strdata=@"C:\a\b.txt";

            //string strdata2 = @"C:\a\bbb.txt";

            //File.Create(strdata);

            //File.Delete(strdata);

            //Console.WriteLine("删除成功！");

            //File.Copy(strdata, strdata2);

            #endregion

            //Path Combine 组合路径

            //Console.WriteLine(Path.GetInvalidFileNameChars());


            #region File文件读写

            //File 读取字节数 ReadAllBytes

            byte[] readbtye = File.ReadAllBytes(@"C:\a\bbb.txt");

            string dataread = Encoding.Default.GetString(readbtye);

            //Default 是保存时候的编码

            string datagb = Encoding.GetEncoding("GB2312").GetString(readbtye);

            //Unicode 国际统一标准 是由UTF-8 UTF32等等编码格式组成的

            //UTF-8   GB2312 Unicode ASCII

            //GBK 既包含简体又包含繁体 GB2312 只包含


            //有文件覆盖，没有文件创建一个文本文件

            string writestring = "今天天气好晴朗，处处好风光；\r 好风光；\r 锋二忙忙 路也忙忙;\r 百花苍苍路由苍苍;";

            

            byte[] writebtye = Encoding.Default.GetBytes(writestring);


            //把字节数组写入到文本文件 其实写了一个字符串

            File.WriteAllBytes(@"C:\a\d.txt", writebtye);

            //File读取所有行 字符数组

            string[] readlines = File.ReadAllLines(@"C:\a\d.txt", Encoding.Default);

            foreach (string item in readlines)
            {
                //Console.WriteLine(item);
            }


            //File读取所有的文本


            string stringtext = File.ReadAllText(@"C:\a\d.txt", Encoding.Default);

            Console.WriteLine(stringtext);



            //Console.WriteLine(dataread);


            //问题来 什么时候用什么方法？？？？？

            // 文本文件无所谓，多媒体文件就又问题了 ReadAllText 读取所有的，如果对具体的行操作那么需要使用ReadAllLines

            //文件写入

            File.WriteAllBytes(@"C:\a\e.txt", readbtye);

            File.WriteAllLines(@"C:\a\f.txt", readlines);

            File.WriteAllText(@"C:\a\g.txt", "sdfsdfsdfsdfsdfsdfsdfsd");


            //文件追加内容

            //File只能读取小文件 一下子全部读入（浪费内存的使用）

            File.AppendAllText(@"C:\a\f.txt", "追加的内容");



            #endregion



            #region 绝对路径和相对路径


            //绝对路径:绝对路径

            //相对路径 相对于应用程序的路径是绝对路径

            //相对路径可以在应用程序下直接加载 为什么使用相对路径（便于移植开发过程中尽量使用相对路径）


            #endregion



            Console.ReadKey();

        }
    }
}

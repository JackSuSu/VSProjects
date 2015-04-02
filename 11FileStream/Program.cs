using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11FileStream
{
    class Program
    {

        /// <summary>
        /// 
        /// 文件流
        /// 
        /// 1.File 一次读取文件大战内存
        /// 
        /// 两缸水 大桶水两个相互交换，File类是直接举起来导入，FileStream 是一飘水的
        /// 
        /// 读取文件的方式（File与FileStream区别）
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {



            //小文件使用File 类


            //File


            #region FIlestrem 读取数据
            
            

            //操作字节，可以操作任何文件

            //创建FileStream对象 （新的东西，学习新的类，学习方法，学习参数 大牛会的类比你多）

            //FileMode Open和OpenCreate 区别，Open有的话打开，没有的话就创建打开

            //参数：文件路径，文件的操作，文件内容

            FileStream filestream = new FileStream(@"C:\a\b.txt", FileMode.OpenOrCreate, FileAccess.Read);

            byte[] buffer=new byte[1024*1024*5]; //有上限 战内存

            // 参数：一次性读取多少字节数(字节数组)，从什么地方开始读取（offset），字节数的长度(Count)


            //返回值 : 读取的实际有效字节 比如说 文件3.8M但是，一次性读取 5M 那么实际返回值只有 3.8M 说明文件结束

            //解码超出了 不解码

            int intdate = filestream.Read(buffer, 0, buffer.Length);

            //释放资源类 GC 不回收 FileStream;

            filestream.Close();

            filestream.Dispose();

            string readstring = Encoding.Default.GetString(buffer, 0, intdate);


            Console.WriteLine(readstring.Trim());



            #endregion




            #region 写入文件


           // using 创建文件流 自动释放文件流内存 GC


            //using(FileStream filewrite=new FileStream(@"C:\a\b.txt",FileMode.OpenOrCreate,FileAccess.Write))
            //{
            //    string wirtestr = "看我怎么把你干掉！";

            //    byte[] bufferdata = Encoding.Default.GetBytes(wirtestr);

            //    filewrite.Write(bufferdata, 0, bufferdata.Length);

            //    Console.WriteLine("写入OK");

            //}



            #endregion



            #region 多媒体文件的复制

            string bigdata = @"C:\a\data.exe";

            string destbigdata = @"D:\a\bigdata.exe";


            CopyFile(bigdata, destbigdata);

            Console.WriteLine("复制成功！");


            #endregion


            //操作字符的 文本文件 StreamReader; 一对的  StreamWriter 

            //StreamReader streamread = new StreamReader();

            //StreamWriter streamWrite = new StreamWriter();


            Console.ReadKey();         

   
        }

        public static void CopyFile(string sourcefilepath, string destfilepaht)
        {

            using (FileStream readfile = new FileStream(sourcefilepath, FileMode.Open, FileAccess.Read))
            {


                using (FileStream writefile = new FileStream(destfilepaht, FileMode.OpenOrCreate, FileAccess.Write))
                {

                    byte[] bufferdata = new byte[1024 * 1024 * 5];

                    //因文件可能很大，所有读取文件时候应该循环读取 


                    while (true)
                    {

                        //如果读取为0 break;

                        int realdata = readfile.Read(bufferdata, 0, bufferdata.Length);

                        if (realdata == 0)
                        {
                            break;
                        }
                        writefile.Write(bufferdata, 0, realdata);


                    }
 
                }

                
 
            }

        

           

 
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16电脑外设
{
    class Program
    {
        static void Main(string[] args)
        {

            //用多态的方法模拟实现将：移动硬盘，或者U盘，或者MP3查到电脑上进行读、写数据
            
            //（包含 内在的设备 电脑 没电脑没法读写）

            //找出父类 没有 抽象出一个类，电脑外设

            //1.电脑类（电脑进行读写）

            //2.抽象出来的电脑外设l

            //3.电脑外设出来的子类

            //思维：一大批同类用户 和 一个设备的发生关系 传递类型参数



            MovibeStorage mdisk = new MDisk();

            Computer cpu = new Computer();

            cpu.CPURead(mdisk);

            cpu.CPUWrite(mdisk);

            Console.ReadKey();

        }

        public abstract class MovibeStorage
        {

            public abstract void Read();

            public abstract void Write();
 
        }



        /// <summary>
        /// 
        /// 拿到父类移动设备
        /// 
        /// 操作存储设备
        /// 
        /// </summary>

        public class MDisk : MovibeStorage
        {

            public override void Read()
            {
                Console.WriteLine("移动硬盘读取数据");              
            }

            public override void Write()
            {
                Console.WriteLine("移动硬盘写数据");
            }

        }







        public class UDisk : MovibeStorage
        {

            public override void Read()
            {

                Console.WriteLine("U盘读取数据");
                // throw new NotImplementedException();
            }

            public override void Write()
            {
                Console.WriteLine("U硬盘写数据");
            }
        }




        public class Mp3 : MovibeStorage
        {

            public override void Read()
            {

                Console.WriteLine("Mp3盘读取数据");
                // throw new NotImplementedException();
            }

            public override void Write()
            {
                Console.WriteLine("Mp3硬盘写数据");
            }


            public void PalyMusic()
            {
                Console.WriteLine("MP3播放音乐");
            }

        }




        /// <summary>
        /// 
        /// 另外一个需要 使用上述类的一个类
        /// 
        /// 
        /// 外设--电脑
        /// 
        /// </summary>


        public class Computer
        {
            public void CPURead(MovibeStorage ms)
            {
                ms.Read();
            }

            public void CPUWrite(MovibeStorage ms)
            {
                ms.Write();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _30NETLib
{
    class _01Thread
    {
     
        static void Mains(string[] args)
        {

            Thread thread = new Thread(new ThreadStart(ThreadProcess));

            Thread thread2 = new Thread(new ThreadStart(ThreadProcess2));            

            //thread.Start();

            //thread2.IsBackground = true;

            thread2.Start();

           

            int data1;

            int data2;

            ThreadPool.SetMaxThreads(200, 300);

            ThreadPool.GetMaxThreads(out data1, out data2);

            Console.WriteLine("MaxThreadWorker:{0},MaxCompersion:{1}", data1, data2);
            



            //中止处于 waitsleep Join线程

            //thread2.Interrupt();


            //Thread.Sleep(2000);


            //thread2.Interrupt();


            //杀死线程


        

            //Join用法是暂停 主线程执行 直到子线程去完成

            //thread.Join();


            //挂起线程(暂停线程)

            thread2.Suspend();

            Thread.Sleep(2000);

            //继续已经挂起的线程

            thread2.Resume();


            //if (thread2.IsAlive)

            //    thread2.Abort();

            Console.WriteLine("MainThread Excuted!");

            string data = TryCathFinally();
          
            

            Console.ReadKey();

        }

        static void ThreadProcess()
        {

            Console.WriteLine("Thread1 BeforeSleep:");

            Thread.Sleep(2000);

            Console.WriteLine("Thread1 Process Data Result!");
        }


        static void ThreadProcess2()
        {

            Console.WriteLine("Thread2 BeforeSleep:");

            Thread.Sleep(5000);



            Console.WriteLine("Thread2 Process Data Result!");
        }

        /// <summary>
        /// 
        /// Test
        /// 
        /// </summary>

        static string TryCathFinally()
        {

            try
            {
                string aa = "123456";

                return aa;
            }
            catch
            {
                string bb = "123456";

                return bb;


            }
            finally 
            {
                Console.WriteLine("Try Catch FinallyData");
            }

            
 
        }

        

    }
}

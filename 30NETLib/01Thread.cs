using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _30NETLib
{
    class _01Thread
    {
        static void Main()
        {

            Thread thread = new Thread(new ThreadStart(ThreadProcess));

            thread.Start();

            Console.ReadKey();

        }

        static void ThreadProcess()
        {
            Console.WriteLine("Thread Process Data Result!");
        }
    }
}

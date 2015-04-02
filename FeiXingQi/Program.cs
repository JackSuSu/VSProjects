using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeiXingQi
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowGameHeader();

            Console.ReadKey();
        }

        static void ShowGameHeader()
        {
           

            Console.WriteLine("************************");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("*******001飞行棋********");

            Console.WriteLine("************************");
        }
    }
}

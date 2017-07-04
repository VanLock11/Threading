using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void WriteSecond()
        {
            Random rd = new Random();
            while (true)
            {
                Console.ForegroundColor = (ConsoleColor)rd.Next(1, 16);
            }
        }
        static void Main(string[] args)
        {
            ThreadStart writesecond = new ThreadStart(WriteSecond);
            Thread thredinger = new Thread(writesecond);
            thredinger.Start();
            Console.WriteLine("Enter your Text");
            string s = Console.ReadLine();
            thredinger.Abort();
            Console.ResetColor();
        }
    }
}

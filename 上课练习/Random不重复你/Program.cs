using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random不重复你
{
    class Program
    {
        public static Random randomitzer = new Random();
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                int number = randomitzer.Next(0,10);
                System.Threading.Thread.Sleep(10);
                Console.WriteLine(number);

            }
            Console.ReadLine();
        }
    }
}

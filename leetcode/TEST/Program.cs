using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array= { 1, 4, 2, 3 };
            List<int> numbers = new List<int>(array);
            numbers.Sort();
            numbers.Reverse();
            foreach(int item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

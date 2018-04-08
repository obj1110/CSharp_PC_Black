using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基于Icomparer的比较函数
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList =new List<int> { 2, 3, 54, 13, 3, 100 };
            numberList.Sort(new ComparerMachine());
            foreach (int item in numberList)
            {
                Console.WriteLine(item);
            }
        }
    }
    class ComparerMachine : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x.CompareTo(y);
        }
    }
}
//上述udes东西同样使用与任意类型，只要你声明比较类型就行了。

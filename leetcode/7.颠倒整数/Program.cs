using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.颠倒整数
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Solution.Reverse(13579);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    //这个题就是注意：输出的东西也应该是int32，所以在C#就用long来接收，之后进行数据类型的强制性转换。
    class Solution
    {
        public static int Reverse(int x)
        {
            int temp = 0;
            if((x > Int32.MaxValue)|| (x < Int32.MinValue)||(x ==0)){
                return temp;
            }
            List<int> Array = new List<int>();
            while (x != 0)
            {
                Array.Add(x %10);
                x = x / 10;
            }
            Int64 result = Array[0];
            for(int i = 1; i < Array.Count; i++)
            {
                result *= 10;
                result += Array[i];
            }
            if ((result>Int32.MaxValue) || (result < Int32.MinValue))
            {
                result = 0;
            }
            int resultA = System.Convert.ToInt32(result);
            return resultA;
        }
    }
}

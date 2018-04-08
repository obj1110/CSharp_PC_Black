using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[4];
            //nums[0] = 2;
            //nums[1] = 7;
            //nums[2] = 11;
            //nums[3] = 15;
            //int target = 9;
            //int[] result = new int[2];
            //result = Solution.TwoSum(nums,target);
            //Console.WriteLine(result[0].ToString());
            //Console.WriteLine(result[1].ToString());

            int[] nums = new int[4];
            nums[0] = 2;
            nums[1] = 7;
            nums[2] = 11;
            nums[3] = 15;
            int target = 9;
            int[] result = new int[2];
            result = Solution3.TwoSum(nums, target);
            Console.WriteLine(result[0].ToString());
            Console.WriteLine(result[1].ToString());

            Console.ReadLine();
       }
        public class Rolution
        {
            //现在想的就是如何尽量不使用for循环，尽量用控件换时间。
            public int[] TwoSum(int [] nums,int target)
            {
                return null;
            }
        }
}
    //注意break主要是用来跳出循环的。跳出当前循环。
    //第一种思路，做差，寻找这个差。
    //第二种思路，排序，大量的使用排序。


    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int sub = 0;
            int currentPosition = 0;
            int anotherPosition = 0;
            int indiceOne = 0;
            int indiceTwo = 0;
            bool statue = false;
            int[] result = new int[2];

            foreach (int item in nums)
            {
                indiceOne = currentPosition;
                sub = target - item;
                foreach (int somthing in nums)
                {
                    if ((somthing == sub) && (currentPosition != anotherPosition))
                    {
                        indiceTwo = anotherPosition;
                        statue = true;
                        break;
                    }
                    else
                    {
                        anotherPosition++;
                    }
                }
                if (statue == true)
                {
                    break;
                }
                else
                {
                    currentPosition++;
                    anotherPosition = 0;
                }
            }
            if (statue = true)
            {
                result[0] = currentPosition;
                result[1] = anotherPosition;
            }
            return result;
        }
    }

    //使用这个双指针来做
    public class Solution2
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            List<int> myList = new List<int>(nums);
            myList.Sort();
            int i = 0;//逻辑指针
            int j = myList.Count();//逻辑指针
            //注意，你这里打乱了顺序，以后还要查询位置。
            //首先做相减运算，然后进行输出
            while (myList[i] + myList[--j] > target) ;
            //if (myList[i] + myList[j] == target) break;
            while (myList[++i] + myList[j] < target) ;
            //if (myList[i] + myList[j] == target) break;

            //下面就是结合i j寻找具体的数值
            int[] ret = new int[2];
            int index = 0;

            int a = myList[i];
            int b = myList[j];
            int cts = 0;
            for (; cts < myList.Count; cts++)
            {
                if (myList[cts]==a ||myList[cts] == b)
                {
                    ret[index++] = cts;
                }
            }//只有实际操作之后才知道这东西有多么的简洁，多么的牛逼。
            return ret;
        }
    }
    //使用散列表来做
    public class Solution3
    {
        public static Hashtable myHT = new Hashtable();
        //静态方法只能引用静态参数或者是变量
        public static int[] TwoSum(int[] nums ,int target)
        {
            List<int> keys=new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                keys.Add(i);
                myHT.Add(keys[i],nums[i]);
            }
            
            for (int cts = 0; cts < myHT.Count; cts++)
            {
                int restValue = target - nums[i];
                //如何从C#中获取一个元素？？？也是iterator的形式吗？？？
                bool flag = myHT.ContainsValue(restValue);
                //这样我们就很快的获得了，到底这里面有没有对应值的判断，如果有，我们直接出去就行，然后就是输出这两个值。
                //如果没有这个值，就继续遍历，直到循环终止。
                //TO DO？？和C++中unordered_map似乎不一样，情深入研究，

            }
            //遍历元素的方式
            //foreach(DictionaryEntry item in myHT)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}


            int[] ret = {-1,-1};
            return ret;
        }
    }

}


//3
//15
//___________
//2
//11
//___________
//1
//7
//___________
//0
//2
//___________

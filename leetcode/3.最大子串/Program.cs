using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.最大子串
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "abcabcbc";
            //int number = Solution.LengthOfString(myString);
            //int number = Solution1A.LengthOfString(myString);
            int number = Solution1B.LengthOfString(myString);
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }







    public class Solution
    {
        public static int LengthOfString(string s)
        {
            int maxLength = 0;
            //判断空串的情况
            if (s.Length ==0 )
            {
                return maxLength;
            }

            List<char> myList=new List<char>();
            foreach (char item in s)
            {
                myList.Add(item);
            }
            //直接用List<char> myList = new List<char>(s);就是不行 ==mmp

            while (myList.Count>0)
            {
                char target = myList[0];
                myList.RemoveAt(0);
                if(myList.Count == 0)
                {
                    break;
                }
                //list在不断缩小
                //只需要判断剩下的List中是不是有这个元素。如果有返回当前的索引。
                //我们的问题就是是我们单纯是比较
                if (myList.Contains(target))
                {
                    //int indexOfTheSame = myList.FindIndex(s => s==target); 
                    for (int i = 0; i < myList.Count; i++)
                    {
                        if (myList[i].Equals(target))
                        {
                            maxLength = (maxLength > (i + 1)) ? maxLength : (i + 1);
                            break;
                        }
                        //else我们继续寻找下一个位置的元素。
                    }
                    //最后早晚会更新这个maxlength，因为只有存在，才会进入这个循环，然后进入这个循环之后，必定会给maxlength赋值。
                }
                else
                //这种情况比较少见，就是说当前的目标元素并不在下一个式子里面abcbb的形式。或者是abcccc形式，所以，单纯改变else的内容是不够的。
                //有没有可能ababcd，有，
                {
                    //a bccb型号的。怎么处理？？
                    List<char> anotherList = new List<char>();
                    anotherList.AddRange(myList);
                    //创建一个List的副本情况
                    while (anotherList.Count != 0)
                    {
                        
                    }
                    //因为我们删除了一个元素，剩下的元素必须是加上这个元素。
                }
            }
            return maxLength;
        }
    }
}

//给定字符串，找到不含有重复字符的最长子串的长度。
//子串必须是在原来的字符串中连续的东西。
//因为Ascii可以转化为byte，小写字母是97~122，大写字母是65~90.
//所以就相当于是寻找数字。数字串。

//应该是涉及到List的深入操作。以及数据类型的了解。

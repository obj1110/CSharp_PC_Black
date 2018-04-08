using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.最大子串
{
    class Solution1B
    {
        public static int LengthOfString(string s)
        {
            int maxLength = 0;
            if (s.Length == 0) return maxLength;

            //把元素增加到无顺序的hashTable里面，如果没有重复元素，直接输出长度
            HashSet<char> myHashSet = new HashSet<char>(s);
            if (myHashSet.Count == s.Length) return s.Length;
            myHashSet.Clear();

            //下面的情况，必定存在重复元素。
            List<char> myList = new List<char>(s);//用s初始化这个数组
            int i = 0;
            int j = 0;
            //用当前的两个指针之间的差距表示这个最大的长度  maxLength = max(maxLength, i-j);

            //注意这个i是最后执行的。
            for (; i < myList.Count; i++)
            {
                //i遍历的元素应该加到hashTable里面，判断是不是有重复
                bool flag = myHashSet.Add(myList[i]);
                //如果没有插入成功，说明当前的从j到i的这段东西里面，必定是存在一个元素和i重复，我们就是应该寻找这个重复元素
                if (flag == false)
                {
                    //从j开始寻找到i
                    
                    for (; j < i; j++)
                    {
                        if(myList[j] == myList[i])
                        {
                            break;
                        }
                    }

                    //for(int m = j; m < i; m++)
                    //{
                    //    if(myList[m] == myList[i])
                    //    {
                    //        j = m;
                    //    }
                    //}

                    j = j + 1;
                    i = j-1;//如果不减去一，就不会把当前的元素加入进去
                    myHashSet.Clear();//位置无所谓
                    //注意我觉得不应该移动i的位置 
                    //注意清空！！但也不是总清空！！
                }
                else
                {
                }
                maxLength = (maxLength > (i - j +1)) ? (maxLength) : (i - j +1);
            }
            return maxLength;
        }
    }
}
//List和STL中的vector很类似。
//KMP是字符串匹配算法，可以用贪心直接解决，但是复杂度高。
//我们这个是寻找最长不重复子串，二者是不一样的。

 //这个第一次寻找到重复啊，应该是第一次寻找到任何和刚才不一样的东西，只要你寻找到了任何一个和原来的东西不一样的


//大体的一个想法就是，i不断移动，然后，将i所遍历的元素都存储到一个hashTable里面，
//如果说出现了重复的问题，立马移动j寻找重复元素，寻找到了重复元素之后，将j移动到重复元素的下一个位置，并且将j赋值给i。然后重新开始运算。

    //而i的每次移动，都要统计一下maxlength。

    //问题就是i出现了大量的重复移动情况，很不科学。很浪费。
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TwoSum
{
    public class Solution1A
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            List<int> result =new List<int>();//存放最后的结果
            if ((l1.val ==0 )&&(l1.next ==null)) return l2;
            if ((l2.val ==0)&&(l2.next ==null)) return l1;
            
            int tempResult = 0;
            int advanceOne = 0;
            //目前的问题就是，如果最后一位进位是1，结果是0，就会直接跳出循环。。。
            while((l1!=null)&&(l2!=null)){
                tempResult = l1.val + l2.val+advanceOne;
                advanceOne = 0;
                if (tempResult > 9)
                {
                    advanceOne = 1;//进位数字，但是目前没有考虑到最后一次循环的情况 
                    result.Add(tempResult-10);
                }
                else
                {
                    advanceOne = 0;
                    result.Add(tempResult);
                }
                l1 = l1.next;
                l2 = l2.next;
            }


            if ((l1 == null)&&(l2!=null))
            {
                tempResult = l2.val + advanceOne;
                l2 = l2.next;
                advanceOne = 0;
                if (tempResult > 9)
                {
                    result.Add(tempResult - 10);
                    advanceOne = 1;
                }
                while ((l2 != null))
                {
                    result.Add(tempResult+advanceOne);
                    advanceOne = 0;
                    l2 = l2.next;
                }
                if (advanceOne == 1)
                {
                    result.Add(1);
                }
            }
            else if ((l2 == null)&&(l1!=null))
            {
                tempResult = l1.val + advanceOne;
                l1 = l1.next;
                advanceOne = 0;
                if (tempResult > 9)
                {
                    result.Add(tempResult - 10);
                    advanceOne = 1;
                }
                while ((l1!= null))
                {
                    result.Add(tempResult+advanceOne);
                    advanceOne = 0;
                    l1 = l1.next;
                }
                if(advanceOne == 1)
                {
                    result.Add(1);
                }
            }
            else if ((l1 == null) && (l2 == null) && (advanceOne == 1))
            {
                result.Add(1);
                advanceOne = 0;
            }

            //使用C#中的List会省事很多，类似的情况适用于C++ STL，但这一切都是建立在你认真的学习了数据结构的基础上。
            //接下来要改造剩下俩的部分，提取出来List中的东西。
            ListNode resultListNode = new ListNode(result[0]);
            ListNode realResult = resultListNode;//按照C++中的指针的观点，应该是指向同一个内存地址。
            //泛型变长数组的长度是count方法——List
            for (int i = 1; i < result.Count; i++){
                ListNode temp = new ListNode(result[i]);
                resultListNode.next = temp;
                resultListNode = temp;
            }
            return realResult;
        }
    }
}
//要考虑的东西有很多，包括两个式子是不是一样长，包括你这个东西是不是存在着天生的空的问题
//以及后续出现的，数据的赋值问题，加的和是10的时候，如果遇到最后的退出该怎么办？
//等等问题，都比较严重。

 //测试例子:
 //   18+0
 //   89+1
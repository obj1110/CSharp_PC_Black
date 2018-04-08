using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//一个成功的提交
//注意三点：
//最高位进位
//长度不一致。。。

namespace _2.TwoSum
{
    class Class3
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            bool l1null = (l1.val == 0) && (l1.next == null); //l1空为真
            bool l2null = (l2.val == 0) && (l2.next == null);//l2空为真
            if (l1null && l2null) //l1空并且l2空
            {
                return l1;
            }
            else if(l1null && !l2null) //l1空，l2不空
            {
                return l2;
            }
            else if(!l1null && l2null)
            {
                return l1;
            }
            int tempNumber = 0;
            int advanceNumber = 0;
            List<int> Array = new List<int>();
            //上面处理了单方面为0，双方面为0的问题
            //下面要处理，单方面长度不够，结束的时候还会进位的问题。
            //要考虑第一次循环和最后一次循环的情况
            while((l1!=null) && (l2 != null))
            {
                tempNumber = l1.val + l2.val + advanceNumber;
                advanceNumber = 0;
                //判断进位的问题
                if (tempNumber > 9) 
                {
                    Array.Add(tempNumber-10);
                    advanceNumber = 1;
                }
                else if(tempNumber<=9){
                    Array.Add(tempNumber);
                }
                l1 = l1.next;
                l2 = l2.next;
                tempNumber = 0;
            }

            //退出循环：l1空 +l2空 +l1 l2 都空
            //此时，可能存在几种情况，advanceNumber是1 。。。。
            //然后可能会出现结果进位的情况 == 
            int newTempNumber = 0;
            if ((l1==null) && (l2!=null)) //l2不是空的
            {
                while (l2 != null)
                {
                    newTempNumber = l2.val + advanceNumber;
                    advanceNumber = 0;
                    if (newTempNumber > 9)
                    {
                        Array.Add(newTempNumber - 10);
                        advanceNumber = 1;
                    }
                    else if (newTempNumber <= 9)
                    {
                        Array.Add(newTempNumber);
                    }
                    l2 = l2.next;
                }
            }
            else if ((l1!=null) && (l2==null)) //l1不是空的
            {
                while (l1 != null)
                {
                    newTempNumber = l1.val + advanceNumber;
                    advanceNumber = 0;
                    if (newTempNumber > 9)
                    {
                        Array.Add(newTempNumber - 10);
                        advanceNumber = 1;
                    }
                    else if (newTempNumber <= 9)
                    {
                        Array.Add(newTempNumber);
                    }
                    l1 = l1.next;
                }
            }
            //然后的情况就是l1和l2都是空的了。
            if(advanceNumber == 1)
            {
                Array.Add(1);
            }
            //然后下面是给数组赋值的操作。
            //上面的算法存在高度的重复性，可以参考CSDN的文章进行优化。
            ListNode l3 = new ListNode(Array[0]);
            ListNode Result = l3; //引用类型别名操作 
            for (int i = 1; i < Array.Count; i++)
            {
                ListNode temp = new ListNode(Array[i]);
                l3.next = temp;
                l3 = l3.next;
            }
            return Result;
        }
    }
}


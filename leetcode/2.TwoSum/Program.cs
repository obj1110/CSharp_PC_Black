using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListNode l1 = new ListNode(2);
            //l1.next = new ListNode(4);
            //l1.next.next = new ListNode(3);

            //ListNode l2 = new ListNode(5);
            //l2.next = new ListNode(6);
            //l2.next.next = new ListNode(4);

            //ListNode l3 = Class3.AddTwoNumbers(l1, l2);
            //Console.WriteLine(l3.val);
            //Console.WriteLine(l3.next.val);
            //Console.WriteLine(l3.next.next.val);

            //Console.WriteLine();
            //ListNode l4 = new ListNode(5);
            //l4.next = null;
            //ListNode l5 = new ListNode(5);
            //l5.next = null;
            //ListNode l6 = Class3.AddTwoNumbers(l4, l5);
            //Console.WriteLine(l6.val);
            //Console.WriteLine(l6.next.val);

            ListNode l7 = new ListNode(9);
            l7.next = new ListNode(8);
            ListNode l8 = new ListNode(1);

            ListNode l9 = Class3.AddTwoNumbers(l7, l8);
            Console.WriteLine(l9.val);
            Console.WriteLine(l9.next.val);

            //ListNode l10 = Class3.AddTwoNumbers(l8, l7);
            //Console.WriteLine(l10.val);
            //Console.WriteLine(l10.next.val);

            Console.ReadLine();
        }
    }

     public class ListNode {
        public int val;//当前存储的数值
        public ListNode next;//指向下一个类对象，感觉这样是不是非常占用系统的空间。。。。
        public ListNode(int x) { val = x; }//构造函数，对于每一个变量val进行初始化
    }

public class Solution {
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            ListNode l3 = new ListNode(0);//最后的结果
            int[] array;
            int number = 0;//用于表示进位的1
            int currentValue = 0;
            while ((l1.next!=null)&&(l2.next!=null))
                {
                    currentValue = l1.val + l2.val+number;
                    number = 0;
                    if (currentValue >= 10)
                            {
                                l3.val = currentValue - 9;
                                l3.next = new ListNode(0);
                                number = 1;
                            }
                    l1 = l1.next;//这里的操作，如果按照C的理解就是移动当前的指针的位置。
                    l2 = l2.next;
                }
            if ((l1 == null)&&(l2 ==null))
            {
                return l3;
            }
            else if((l1!=null)&&(l2 == null)){
                while (l1.next != null)
                {
                    l3 = l1;
                    l3 = l3.next;
                    l1 = l1.next;
                }
                return l3;
            }
            else{
                while (l2.next != null)
                {
                    l3 = l2;
                    l3 = l3.next;
                    l2 = l2.next;
                }
                return l3;
            }
            //l1为空或者l2为空或者l1+l2都是空的了。
    }
}
}
//其实两数相加最简单的结果就是直接改变其中的一个链表，另外的一个链表不断改变自己的数值。
//但是我对于C#的语法还是不熟悉，所以决定用一个数组来存储，然后就是再赋值。

//2018-3-27 23:27:30
//这个题你一定要周密的考虑，首先，两个链表并不一定就是非空的。
 //首先你要判断是不是非空。
 //  然后，其实最后的结果保存在一个数组里面就够了，我们保存在R1里面就行了。


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.TwoSum
{
    //上一个循环体有很严重的问题，所以直接重写
    class Class2
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ///如果这一个数字为空的话直接返回另一个数字，都为空则返回空
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            //这个东西就是直接加到一个原来的表格上面，和我们以前的加到一个数组，然后用数组给链表赋值的情况是不一样的 。
            //把相加后的结果存放于链表1，pre1是用于最后有进位时在其后new新结点  ，pre1仅仅适用于最后还接着进位的情况。
            ListNode ret = l1;//这个就是返回的结果
            ListNode pre1 = new ListNode(0);//初始化为0，不过最后不是0就是1.
            pre1.next = l1;

            int flag = 0;
            while (l1 != null && l2 != null)
            {
                l1.val = l1.val + l2.val + flag;  //l1用来保存结果
                flag = l1.val / 10;  //flag为进位数，如果l1大于10，则flag唯一，否则仍然为0
                l1.val = l1.val % 10;  //重新为l1赋值，除以10取余，相当于获得了个位
                pre1 = l1;  //原来pre1的next是l1，现在将l1赋值给pre1，相当于pre1的next为l1的next了【基本就是最高位】
                l1 = l1.next;  //将l1 l2的下一位赋值给l1 l2，继续循环计算
                l2 = l2.next;
            }

            //其实更新l1的表格和创建一个新的表格没有本质上的差别。。。。关键就是说。还是进位的问题。。。
            //此外要处理，如果l1很短的情况。


            //如果链表2有剩余，接到链表1的后面  
            if (l2 != null)
            {
                pre1.next = l2;
                l1 = l2;
            }

            while (l1 != null)
            {
                l1.val += flag;
                flag = l1.val / 10;
                l1.val = l1.val % 10;
                pre1 = l1;
                l1 = l1.next;
            }

            if (flag > 0)
            {
                ListNode node = new ListNode(1);
                pre1.next = node;
            }

            return ret;
        }
    }
}

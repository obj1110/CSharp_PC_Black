using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//似乎方法三就是KMP字符串寻找算法
//可以使用内置的HashTable
//leetcode可以额外定义函数的，只要都在这个类里面就行。
namespace _3.最大子串
{
    class Solution1A
    {
        public static int LengthOfString(string s)
        {
            int maxLength = 0;
            if (s.Length == 0)  return maxLength;
            //把元素增加到无顺序的hashTable里面，如果没有重复元素，直接输出长度
            HashSet<char> myHashSet = new HashSet<char>(s);
            if (myHashSet.Count == s.Length) return s.Length;
            myHashSet.Clear();
            //下面的情况，必定存在重复元素。
            List<char> myList = new List<char>(s);
            int i = 0;
            int j = 0;
            //逻辑上的指针= =
            //下面必定存在重复元素
            List<char> tempList = new List<char>();

            while (i < myList.Count)
            {
                bool flag = myHashSet.Add(myList[i]);
                tempList.Add(myList[i]);
                //HS abcdef     Labcdefc  i指向c4，j指向a0
                if (flag = false)
                {
                    //TO DO
                }
                i++;
            }
            return maxLength;
        }
    }
}



//这个题解法：
//1
//C++ STL unordered_map hash_table
// unordered_map<char,int> um；
//um记录遍历过程中每个字符最后出现的位置

//2
//C++ 数组 memset
//https://blog.csdn.net/lc_910927/article/details/36628201

//3
//https://blog.csdn.net/kenden23/article/details/16839757
//可以用指针实现的方法

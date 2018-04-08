using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List使用
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tempString = { "hello", "world", "ren", "chun", "zhe" };
            string[] tempString2 = { "goof", "bye", "zhang", "xiaoxiao", "farewell" };
            List<string> myList = new List<string>(tempString);

            myList.Add("xv");
            myList.AddRange(tempString2);

            myList.Insert(0,"zhangxiaoxiao");//注意第一个元素的位置就是0
            myList.Remove("ren");//根据value删除指定的元素
            myList.RemoveAt(0);//根据索引位置删除元素
            myList.RemoveRange(0, 3);//根据索引删除元素

            bool result = myList.Contains("ren");
            Console.WriteLine(result);

            myList.Clear();
            Console.WriteLine(myList.Count);
            myList.AddRange(tempString);
            myList.AddRange(tempString2);
            myList.Sort();//默认是根据第一个元素的值进行筛选，unicode.
            myList.Reverse();

            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }
            myList.Clear();
            //remove是根据条件删除，clear是无条件删除。
            Console.WriteLine("+++++++++++++++++++");
            myList.AddRange(tempString);
            myList.AddRange(tempString2);

            Console.ReadLine();

        }
    }
}
//泛型的好处，不需要对于值类型进行强制的Boxing和Unboxing，或者对引用类型进行向下的强制类型转化，性能得到了提高。

//List<T> 类是 ArrayList 类的泛型等效类。该类使用大小可按需动态增加的数组实现 IList<T> 泛型接口。

//在决定使用IList<T> 还是使用ArrayList类（两者具有类似的功能）时，记住IList<T> 类在大多数情况下执行得更好并且是类型安全的。

//List
//1. 声明
//List<string> mList = new List<string>();
//List<T> testList = new List<T>(IEnumerable<T> collection);
////用集合作为参数创建List
//string[] temArray = { "hello", "world", "justin", "zhangxiaoxiao" };
//List<string> testList = new List<string>(temArray);

//2. 添加元素
//List.Add("John");
//string[] temArray = { "hello", "world", "justin", "zhangxiaoxiao" };
//List.AddRange(temArray); 
////应该说这个List可以用一个集合进行初始化或者是用一个集合增加到后面。
//    List.insert(int index,T item);

//3. 遍历
//foreach (T element in mList)
//4. 删除
//List.Remove(T item);//删除一个元素
//List.RemoveAt(int index);//删除指定位置的一个元素
//List.RemoveRange(int index,int count);//从下表index开始，删除count个元素。

//5.判断元素是不是在list中
// List.Contains(T item) 判断元素是不是在List中，
//leetcode第三题主要就要用到这个东西

//6. 排序
//List.Sort();默认是元素第一个字母按照升序进行排序
//List.Reverse() 将List中的元素反转。
//List.clear()；
//List.Count();



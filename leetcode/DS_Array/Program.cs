using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[5];
            ArrayList my_ArrayList = new ArrayList();
            my_ArrayList.Add("ren chunzhe");

            //boxing
            string info = "zhangxiao";
            object myobj = (object)info;
            //unboxing 
            object myobj2 = "zhangxiaoxiao";
            string info2 = (string)myobj2;

        
        }
    }
}
//OOP语言你应该更专注于算法的实现，和数据结构的调用。
//JAVA System.Collections STL都是如此

//Array
//存储在连续的内存，都是相同的类型，可以通过下标进行直接访问。
//创建一个新的数组，将在CLR的托管堆中分配一块连续内存。如果是值类型，间会有size个未装箱的值被创建，如果是引用类型，将会创建size个引用。访问速度是1。


//ArrayList  是system.Collections 下面的部分，
//不需要在声明的时候指明长度，是动态增加长度的。
//可以存储不同类型的元素，因为ArrayList中的元素都是object类型的。索引操作。
//但是由于所有的对象都是object来存储的，所以会出现类型不匹配的情况。当插入的数据是值类型的时候，会出现boxing活动，使用index索引取值的时候，会unboxing。boxing：就是把值类型实例转换为对象。unboxing：就是将引用类型转换为值类型。消耗时间。

//List<T> 类型安全，不需要 boxing和unboxing。
//内部为Array，list<T> 继承和实现了很多interface
//List<T>的实现，需要resize 扩容操作以及compact操作在remove的时候需要使用。

//LinkedList<T> 链表，链表适合在需要有序的排序的情境下增加新的元素，但是由于排不顺序的影响，访问的时候很慢。
//链表适合元素数目不固定，并且两端存取并且经常增减节点的情况
//需要使用previous 和 next遍历list，而不可以用索引进行访问。

//Queue<T> 队列 ，先进先出。Enqueue和Dequeue实现队列的存取。
//Stack<T> 先进后出 ，push pop



//顺序存储结构
//array可以存在多个维度，而list<T>仅仅有一个维度，可以创建Array--list或则是list--list。
//在决定使用 List 还是使用ArrayList 类（两者具有类似的功能）时，记住List 类在大多数情况下执行得更好并且是类型安全的。如果对List<T> 类的类型T 使用引用类型，则两个类的行为是完全相同的。但是，如果对类型T使用值类型，则需要考虑实现和装箱问题。
//ArrayList和List除了类型是不是泛型之外都是差不多的动态数组。







//无序存储结构
//Dictionary<K,T> 增加 访问 删除都很方便，但是问题就是哈希冲突问题，也就是很多key对应一个value。
//创建Dictionary的时候，必须声明key和 value的类型。类型安全
//其实keys对应的是不同的buckets，这些bucket都是一个个的数组，数组的元素又都是一个一个的linkedList。

//hashset——表示值的集合——集运算——一组是一个集合，不包含重复元素，元素顺序不分先后。包括IntersectWith——交集，ExceptWith——减法，SymmetricExceptWith——于吉，unionwith就是union的操作。


//hashtable——用n的空间换区n的时间，所以访问数据是1.
//key用于快速查找，value用于存储对应的key的值。
//    key和value都是object类型。hashtable可以支持任何类型的key value类型。类型不安全。
//散列值HashCode = key.getHashCode()；
//    所有的查找操作都是基于HashCode来寻找key和value的。
//存在boxing和unboxing的开销。

//单线程用Dictionary，多线程用hashTable+++ because you can't insert any random object into it, and you don't have to cast the values you take out.



    //数据结构大纲
    //线性结构——数据元素之间是一对一的关系
    //树性结构——数据元素之间存在一对多的关系
    //图形结构——多对多的关系


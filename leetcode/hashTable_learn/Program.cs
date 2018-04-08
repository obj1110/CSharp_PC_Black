using System;
using System.Collections;
using System.Collections.Generic; //泛型内置数据结构
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTable_learn
{
    public class HashTable
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1","ren chunzhe");
            ht.Add("2","guantong");
            ht.Add("3","sunzhengzhong");
            
            Console.WriteLine("\t-KEY-\t-VALUE-");
            PrintKeysAndValues(ht);
            //也进一步说明这个访问的顺序是需要用DictionaryEntry进行遍历foreach的。

            string s = (string)ht[1];//hashTABLE直接根据key获取value
            if (ht.Contains(4)) Console.WriteLine("key-4-do exist");
            //也就是说一切都是key，key就是这里面的索引。
            ht.Clear();
            Console.WriteLine(ht[2]);

            //对于hashTable的遍历操作
            //需要声明类型为DictionaryEntry Object  

            //对于hashTable进行排序。。。我咋觉得没意义呢、。。
            ArrayList akeys = new ArrayList(ht.Keys);
            //使用ht.keys初始化这个ArrayList 
            akeys.Sort();//fast sort,按照key的字母数据进行排列。
            foreach (string skey in akeys)
            {
                Console.WriteLine(skey);
                Console.WriteLine(ht[skey]);
            }
            //我感觉hashTable的排序基本没有意义。。


                Console.ReadLine();
        }
        public static void PrintKeysAndValues(Hashtable myHT)
        {
            Console.WriteLine("\t-KEY-\t-VALUE-");
            //注意这个里面的元素的访问方式是需要用DictionaryEntry来进行的。
            //我看直接用var得了，但是结果不行，必须要是DictionaryEntry这种struct类型。
            foreach (DictionaryEntry de in myHT)
            {
                Console.WriteLine("\t{0}:\t{1}",de.Key,de.Value);
            }
        }
        
    }
    
}

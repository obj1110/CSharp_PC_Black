using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS6_String
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface IArray<T>
    {
        int GetLength();

    }

    public class StringDS:IArray<int>
    {
        //这个东西仅仅是一个引用变量，并不是实际的变量。
        private char[] data;
        
        //构造器
        public StringDS(char[] arr)
        {
            //将一个char[]赋值给另外一个char[]
            data = new char[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                data[i] = arr[i];
            }
        }


        public StringDS (int len)
        {
            char[] arr = new char[len];
            data = arr;
        }

        public StringDS()
        {
            data = null; 
        }

        //索引器，既然你可以用索引对于数据的下标访问，所以必定有对应的类定义，其实List<T>应该也有对应的实现，但是由于封装好的，所以你就直接用下标进行访问就行了。
        public char this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
        public int GetLength()
        {
            return data.Length;
            //return data.GetLength(1);
            
            //从这里可以看出来，内置的[]应该是有自己的属性的，类似于Length这种就是内置类型[]的属性，而不是方法、
        }
        //比较两个字符串，所以你肯定要输入一个字符串喽
        public int Compare(StringDS s)
        {
            int len = (this.GetLength() <= s.GetLength() ? this.GetLength() : s.GetLength());
            int i = 0;
            //其实在for循环里面++i和i++结果一样
            for(i = 0; i < len; ++i)
            {
                if (this[i] != s[i]) break;
            }
            if (i < len)
            {
                if (this[i] < s[i]) return -1;
                else if (this[i] > s[i]) return 1;
            }
            else if (this.GetLength() == s.GetLength()) return 0;
            else if (this.GetLength() < s.GetLength()) return -1;
            return 1;
        }
        //0——长度以及对应元素一致
        //-1——对应位置元素一致，s更长；对应位置元素s更大。
        //1 ——this更长，或者this元素的unicode值更大。

        public StringDS SubString(int index ,int len)
        {
            StringDS ret = new StringDS();
            if (index < 0 || index > this.GetLength() - 1 || len < 0 || len > this.GetLength() - 1) return ret;
            ret = new StringDS(len);
            for (int i = 0; i < len; i++)
            {
                ret[i] = this[index - 1+i];
                //要修改上面的索引器或者属性的说明，防止出现只读提示。
            }
            return ret;
        }

        //合并俩个串
        public StringDS CombineString(StringDS s)
        {
            StringDS ret = new StringDS(this.GetLength() + s.GetLength());
            for (int i = 0; i < this.GetLength(); i++)
            {
                ret.data[i] = this[i];
            }
            for (int j = 0; j < s.GetLength(); j++)
            {
                ret.data[this.GetLength() + j] = s[j];
            }
            return ret;
        }
        //
        public StringDS StringInsert(int index, StringDS s)
        {
            int len = s.GetLength();
            int len2 = s.GetLength() + this.GetLength();
            StringDS ret = new StringDS(len2);

            if (index < 0 || index > this.GetLength() - 1) return null;
            for (int i = 1; i < index; i++)
            {
                ret[i] = this[i];
            }
            for (int i = index; i < index + len; i++)
            {
                ret[i] = s[i];
            }
            for(int t = index + len; t < len2; t++)
            {
                ret[t] = s[t];
            }
            return ret;
        }

        //public StringDS stringDelete(int index, int len) { }
        //怎么能少的了著名的KMP字符串匹配算法？？？
    }

    
}
//串是字符串，是特殊的数据结构。
//数组中的元素可以是具有某种结构的数据，可以是数组，但是属于同一数据类型，数组在很多高级语言中被用作固定类型使用。
//数组是n个相同数据类型的数据元素的有限序列。
//一维数组可以看做是一个线性表，二维数组可以看做是一维数组的一维数组，三维数组可以看做是数据元素是二维数组的一维数组。


//数据元素通过唯一的下标来进行标识和访问。
//数组元素操作——赋值操作、排序操作。


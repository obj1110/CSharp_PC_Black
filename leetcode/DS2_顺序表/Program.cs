using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS2_顺序表
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public interface IListDS<T>
    {
        int GetLength();
        void Clear();
        bool isEmpty();
        void Append(T item);

        void Insert(T item, int index);
        T Delete(int i);
        T GetElem(int i);
        int Locate(T value);
    }//接口里面都是方法的签名,相当于是虚基类。
    
    //class里面就要详细的说明各种方法的实现，方法签名和上面的interface(虚基类）是一一对应的。
    public class SeqList<T> : IListDS<T>
        //表示我们是这个接口派生出来的东西。
    {
        private int maxsize;
        private T[] data;//存储元素用的
        private int last;//指使当前最后一个元素的位置，和maxsize组合效果很好。
        //可以吧maxize理解为物理内存，把last理解为逻辑内存。

        //???????
        public T this[int index] {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;//索引器和访问器自带的变量value
            }
        }

        public int Getlast
        {
            get
            {
                return last;
            }
        }

        public int MaxSize
        {
            get
            {
                return maxsize;
            }
            set
            {
                maxsize = value;
            }
        }
            
        //上面三个索引器实现字段的访问和修改
        //下面的构造器进行初始化
        public SeqList(int size)
        {
            data = new T[size];
            maxsize = size;
            last = -1;
        }
        public int GetLength()
        {
            return last + 1;
        }
        //顺序表的元素清空一直很有意思，直接更改尾指针的位置，逻辑上空。而Destroy是物理上空。
        public void Clear()
        {
            last = -1;
        }
        public bool isEmpty()
        {
            if (last == -1) return true;
            else return false;
        }
        //last指针和maxsize进行组合
        public bool isFull()
        {
            if (last == maxsize - 1) return true;
            else return false;
        }

        //增加方式是：1.表没有满 2 .尾端增加元素 3 .last+1
        public void Append(T item)
        {
            if (isFull())
            {
                Console.WriteLine("List is full");
                return;
            }
            else
            {
                data[++last] = item;
                //首先我们改变last的位置，然后用last进行操作，在data里面增加数据。真牛逼。
            }
        }
        //任意位置插入
        public void Insert(T item,int position)
        {
            if (isFull()) return;
            if (position< 1 || position> last + 2) return;
            //不是很懂，为啥position=0不可以呢？
            if(position==last + 2)
                {
                    data[last + 1] = item;
                }
            else
                {
                //如果position为0，j最小就是0，那么这样的j进入运算会导致异常？？？或者说，我们规定的是在position前面增加元素，所以这种情况需要position大于-1。
                for(int j = last; j >position - 1; j--)
                {
                    data[j + 1] = data[j];
                }
                data[position - 1] = item;
                }
            ++last;
        }
        //需要判断是不是为空，需要判断插入位置是不是合理，需要构造循环判断插入位置。然后注意自己规定一下是前叉还是后插。

        public T Delete(int i)
        {
            T tmp = default(T);
            //指定类型参数的默认值。 这对于引用类型为 null，对于值类型为零。
            if (isEmpty()) return tmp;
            if (i < 1 || i > last + 1) return tmp;
            if (i == last + 1)
            {
                return  data[last--];
                //这种操作就是可以先删除，然后改变last的位置。
            }
            for(int j = i; j < last; ++j)
            {
                data[j] =data[j+1];
            }
            --last;
            return tmp;
        }

        //根据索引获取元素的数值
        public T GetElem(int i)
        {
            if (isEmpty() || (i<1) || (i > last + 1))
            {
                return default(T);
            }
            return data[i - 1];
        }
        //根据元素的值寻找元素的索引 
        public int Locate(T value)
        {
            if (isEmpty()) return -1;
            int t = 0;
            for (; t <= last; ++t)
            {
                if (value.Equals(data[t]))
                {
                    break;
                }
            }
            if (t > last) return -1;
            else return t;
        }
    }
    
}

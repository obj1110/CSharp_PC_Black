using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//明确优缺点：
//空间自由，但是插入删除检索都要进行遍历操作，费时。
namespace DS4双向链表
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
    public class DbNode<T>
    {//双向结点类
        private T data;
        private DbNode<T> prev;//前驱引用
        private DbNode<T> next;//后继引用
        //构造器
        public DbNode(T val,DbNode<T> p)
        {
            data = val;
            next = p;
        }
        public DbNode(DbNode<T>p)
        {
            next = p;
        }
        public  DbNode(T val)
        {
            data = val;
            next = null;
        }
        //一旦增加了数据域睡醒就会出现严重的二义性。
        public T GetData
        {
            get { return data; }
            set { data = value; }
        }
        public DbNode<T> GetPrev
        {
            get { return prev; }
            set { prev = value; }
        }
        //数据域的属性和字段名称不一致，很好的保证了二义性不会出现。
        //目前二义性怀疑有两种情况，接口继承和接口定义冲突，私有字段和属性定义器的冲突。
        public DbNode<T> GetNext
        {
            get { return next; }
            set { next = value; }
        }
    }
    public class DLinkList<T> : IList<T>
    {
        private DbNode<T> head;
        public DbNode <T> GetHead
        {
            get { return head; }
            set { head = value; }
        }
        public DLinkList()
        {
            head = null;
        }
        //不懂这个this到底是干啥用的
        public T this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void ReverseLinkList(DLinkList<int> H)
        {
            DbNode<int> p = H.head;//创建一个结点引用，将head的值赋给它，wpt和head指向一个位置。
            DbNode<int> q = H.GetHead;
            //不是很懂这两个有什么区别？
        }
    }
}
//需要一个虚基类(interface)，一个结点类，一个主类。
//感觉C#里面创建接口真的是很有用处，实现了方法签名，就是一个规范的感觉。

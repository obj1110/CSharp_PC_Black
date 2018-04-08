using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS5_stack_queue
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //似乎接口可以定义public private，但是里面的签名没用
    public interface IStack<T>
    {
        int GetLength();
        bool isEmpty();
        void Clear();
        bool isFull();
        void Push(T item);
        T Pop();//动作
        T GetTop();//获取栈顶元素
    }
    //Stack是基于List的，所以两种顺序，List或者是LinkedList
    public class SeqStack<T> : IStack<T>
    {
        private int maxsize;
        private T[] data;
        private int top;//定义的是栈顶指针
        //索引器
        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
        //属性设置器。。。
        //规定大写的为属性，小写的为字段，否则，会产生public  int Maxsize和private int maxsize之间的二义性。
        public int Maxsize
        {
            get { return maxsize; }
            set { maxsize = value; }
        }
        public int Top
        {
            get { return top; }
            set { top = value; }
        }
        //构造函数
        public SeqStack(int size)
        {
            data = new T[size];
            maxsize = size;
            top = -1;
        }
        public SeqStack()
        {
            data = null;
            maxsize = 0;
            top = -1;
        }

        //下面开始定义方法
        //接口所定义的方法或者对象，在实现类中是不是也要全都有？？？是强制性继承还是选择性继承。
        public void Clear()
        {
            top = -1; 
        }
        //元素的个数
        public int GetLength()
        {
            return top + 1;
        }

        public T GetTop()
        {
            T tmp = default(T);
            if (isEmpty()) return tmp ;

            return data[top--];
        }

        public bool isEmpty()
        {
            if (top == -1) return true;
            else return false;
        }

        public T Pop()
        {
            T tmp = default(T);//等待插入的元素
            if (isEmpty()) return tmp;
            tmp = data[top--];//先赋值，然后做减法，理论上应该没有问题
            return tmp;
        }

        public void Push(T item)
        {
            if (isFull()) return;
            data[++top] = item;
            //首先进行top指针的位置的改变，然后进行赋值。
            //return 语句终止它出现在其中的方法的执行并将控制返回给调用方法。 它还可以返回一个可选值。 如果方法为 void 类型，则可以省略 return 语句
        }

        public bool isFull()
        {
            if (top + 1 == maxsize) return true;
            else return false;
        }
    }

    public class Node<T>
    {
        //类对象嵌套的方式模拟指针
        private T data;
        private Node<T> next;
        public Node(T val, Node<T> p)
        {
            data = val;
            next = p;
        }
        //4种重载函数
        public Node(Node<T> p)
        {
            data = default(T);
            next = p;
        }
        public Node(T val)
        {
            data = val;
            next = null;
        }
        public Node()
        {
            data = default(T);
            next = null;
        }
        //属性的构造器和索引器。只需要大写就可以有效避免二义性问题，而如果用Get字头，会造成严重问题。
        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        //上面这个二义性的问题，我至今没有一个很好的解决思路。
        //引用域属性 
        public Node<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
    }
    //说是使用类对象的嵌套实现链表这种结构，在我看来就是不断创建类对象，结点对象，然后创建对于这种对象的引用操作。
    public class LinkStack<T> : IStack<T>
    {
        //结点定义器 出现在Node<T>中。
        //private T data;
        //private Node<T> next ;

        private Node<T> top;
        private int num;
        //属性定义器,防止和元素出现二义性
        public Node<T> Top
        {
            get { return Top; }
            set { top = value; }
        }
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        //构造函数
        public LinkStack()
        {
            top = null;
            num = 0;
        }

        //为啥感觉和Node<T>的定义高度重复？本来就是如此，头结点指向第一个结点，逻辑上指向这个链表。
        public void Clear()
        {
            top = null;
            num = 0;
            //在stack里面，top对应的是 -1，在这里面我就直接省事用null了。
        }

        public int GetLength()
        {
            return num;
        }

        public T GetTop()
        {
            T tmp = default(T);
            if (isEmpty())
            {
                return tmp;
            }
            //访问属性而不是访问字段。
            tmp = Top.Data;
            return tmp;
        }

        public bool isEmpty()
        {
            if (top ==null&&num <= 0) return true;
            return false;
        }
        //在LinkList，不可能拥到
        public bool isFull()
        {
            throw new NotImplementedException();
        }

        //返回栈顶元素
        public T Pop()
        {
            T tmp = default(T);
            if (isEmpty()) return tmp;
            Node<T> ret = top;
            top = top.Next;
            //不是很懂，这个LinkStack似乎都是在头结点进行的操作。插入也是在头结点前增加。
            --num;
            return ret.Data;
        } 

        public void Push(T item)
        {
            Node<T> tmp = new Node<T>(item);
            if(top == null)
            {
                top = tmp;  
            }
            else
            {
                //LinkList典型的在前面增加元素的方式。
                tmp.Next = top;
                top = tmp;
            }
            ++num;
        }
    }

    
    public interface IQueue<T>
    {
        int GetLength();
        bool isEmpty();
        void Clear();
        void Push(T item);
        T Pop();
        T GetFront();
    }
    
}
//跳转语句
//break continue goto return throw 

//这里面的+1-1之类的是最恶心的
//top=-1 ，当前元素个数top+1，当前最后一个不空的位置——在数组中就是top，在实际逻辑上是top+1,也就是说top = 4，表示，我目前在存储位置中有5个元素，最后一个不空的位置（栈顶）就是5号元素位置，对应的是数组array[4]。
//Array[top]就是当前的栈顶元素。

//这里面大量的top++ --top 之类的复合操作是最复杂的。

//其实stack就是大量限制操作的LinkList和SeqList,对于LinkStack，top时刻指向头结点，增减元素都集中在头结点。
//而对于SeqStack，一般top指向尾巴，也就是在尾结点进行插入和删除工作


//注意Queue的插入操作在rear，而其余的所有的操作都在front。
//排队问题都是可以用Queue，悔棋用Stack
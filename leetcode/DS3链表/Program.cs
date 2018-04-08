using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

二义性问题的产生
    http://www.biye5u.com/article/Csharp/jichu/2013/6108.html
c#接口中的二义性问题，应该是由于你从接口继承的东西和类定义

namespace DS3链表
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
    } //我把这个接口又拷贝回来了，不知道有啥用处。
    public class Node<T>
    {
        //类对象嵌套的方式模拟指针
        private T data;
        private Node<T> next;
        public Node(T val,Node <T> p)
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
        //属性的构造器和索引器。
        public T GetData
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
        public Node<T> GetNext
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
    //这个链表的实现一个方面是要求使用接口继承实现类，另一个方面是要求使用结点类进行创建。
    //回想在C++中创建类的方法，我们使用的是一个叫做头结点的东西来代表这个LinkList整体。
    public class LinkList<T> : IListDS<T>
    {
        private Node<T> head; //单链表的头引用 
        //声明一个引用类型，也就是说，C#里面的指针，或者OOP里面的指针，其实是面向对象思想的逻辑引用类型。

        //对于这样一个子弹，难免的是需要一个属性来声明索引器和构造器。
        public Node<T> GetHead
            //获取头结点的属性
        {
            get { return head; }
            set { head = value; }
        }
        //构造函数
        public LinkList()
        {
            head = null;
        }
        //在末尾老老实实排队。
        public void Append(T item)
            //主要是两种不同的情况，头结点是空的，那么就直接赋值然后输出，如果头结点不是空的，那么我们就用头指针从头结点开始进行遍历操作。直到寻找到尾巴结点，所有的方式都是要这样进行的，包括按照value寻找元素是不是存在。
        {
            //首先初始化一个节点
            Node<T> q = new Node<T>(item);
            Node<T> p = new Node<T>();//不知道有啥用处
            //p的作用就是工作指针，类似于在C++中的工作指针的作用，就是一个类型引用。其实head也是一个引用 。
            //如果头节点自己就是空的，那么我就直接把这个东西赋给头结点。
            if (head == null)
            {
                head=q;
                return;
            }
            p = head;//将head结点的引用赋值给p结点的引用。
            while(p.GetNext != null)
            {
                p = p.GetNext;
            }
            p.GetNext = q;//p当前引用的是最后一个不空的结点，
            //然后就是把p的next赋值给q

            //如果退出循环，代表我们已经找到了最后的位置。
        }

        public void Clear()
        {
            head = null;
            //注意是逻辑上的清空不是物理上的清空。
        }

        public T Delete(int i)
        {
            throw new NotImplementedException();
        }

        public T GetElem(int index)
        {
            T ret = default(T);
            if (isEmpty()) return ret;

            //就是用工作指针进行遍历操作
            Node<T> wpt = new Node<T>();
            wpt = head;
            //由于我们判断索引位置是不是合理，主要是需要使用遍历的方式，并且由于当前的这个链表的头结点不负责存储任何表长信息，头结点就是一个普通的结点，导致说我们只能用wpt来遍历检索。
            int j = 1;//使用j指针来进行结点位置的判断。
            while (wpt.GetNext != null || j < index)
            {
                ++j;
                wpt = wpt.GetNext;//进行结点的移动
            }
            if (j == index)
            {
                return wpt.GetData;
            }
            else
            {//说明你结点位置不合理，明显是一个不存在的结点
                return ret; //注意这是default(T);
            }
        }

        public int GetLength()
        {
            //类似于C++中的遍历方式
            Node<T> p = head;
            int length = 0;
            while (p!=null)
            {
                ++length;
                p = p.GetNext;
            }
            return length;
        }//使用头指针移动的方式进行元素的遍历操作。

        //插队分子
        public void Insert(T item, int index)
        {
            //没有长度限制，但是你要是想插在头结点之前也是不行的。
            //这里的index代表的是绝对位置。
            if (isEmpty() || index < 1) return;
            //我感觉这个很奇怪啊，是不是说return单纯代表的是控制权的上交。
            //index ==1 也就是说你想当老大。
            if (index== 1)
                {
                Node<T> q = new Node<T>(item);
                q.GetNext = head;
                head = q;
                return;
                //next是结点的引用。
                //代表创建一个类，用于插入对象。
                }
            //index  >1 就是说你要插队！！
            //创建一个结点 
            Node<T> p = head;//移动引用或者是工作引用
            Node<T> wpt = new Node<T>();//用于保存当前指向的结点位置。
            int j =1 ;//有啥用？？？
            while(p.GetNext != null || j < index)
            {
                wpt = p;
                p = p.GetNext;
                ++j;
            }
            //wpt是待插入位置的前一个结点
            //q是等待插入的结点，要新创建
            //p是不断移动的结点，工作结点是当前遍历位置的下一个结点。
            if (j == index)
            {
                Node<T> q = new Node<T>(item);
                q.GetNext = p;
                wpt.GetNext = q;
            }
            //因为你这个链表的长度是不可知的，所以可能存在index是前不着村的很大的结点，所以这个时候你就要使用一个j进行判断，到底这个结点的位置是不是合理的。
        }

        public bool isEmpty()
        {
            if (head == null) return true;
            else return false;
        }
        //根据元素数值确定元素的索引位置
        public int Locate(T value)
        {
            if (isEmpty()) {
                return -1;
            }
            Node<T> wpt = new Node<T>();
            wpt = head;
            int j = 1;
            while(!wpt.GetData.Equals(value) || wpt.GetNext != null)
            {
                wpt = wpt.GetNext;
                ++j;
            }
            return j;
        }
    }
}
//使用接口实现了函数的继承，接口定义了函数的方法签名。
//其实不同代码实现最基础的数据结构差不多都是那样。。。。。
//像C#里面不推荐使用指针，那我们就使用嵌套类呗。
//每一个方法都要做的——判断是不是空，判断当前的index是不是合理。
//基本的操作——初始，清空，删除，判空，尾接，插队，（取值）索引操作（查询），（取地址）按值操作（查询）。长度判断。


//单向链表最不好的操作就是必须要从头开始进行长度判断，检索，查询。



//在我声明了private字段之后，需要继续声明一段索引器，indexer和setter用于public操作属性。
//对于indexer和setter所属于的public属性索引器的命名比较有讲究，比如说我私有的字段名是data，那么我的索引器需要的命名就是Data，这样会出现严重的二义性冲突问题，解决办法就是属性操作器为GetData()；也就是主动的修改名字不要冲突。

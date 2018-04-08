using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS7_树
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Node<T>
    {
        private T data;
        private Node<T> lchild;
        private Node<T> rchild
        public Node(T val, Node<T> lp, Node<T> rp)
        {
            data = val;
            lchild = lp;
            rchild = rp;
        }
        public Node(Node<T> lp, Node<T> rp)
        {
            data = default(T);
            lchild = lp;
            rchild = rp;
        }
        public Node(T val)
        {
            data = val;
            lchild = null;
            rchild = null;
        }
        public Node()
        {
            data = default(T);
            lchild = null;
            rchild = null;
        }
        public T Data
        {
            get { return data; }
            set { value = data; }
        }
        public Node<T> Lchild
        {
            get { return lchild; }
            set { lchild = value; }
        }
        public Node<T> Rchild
        {
            get { return rchild; }
            set { rchild = value; }
        }
    }

    public class BiTree<T>
    {
        private Node<T> head;//头引用，默认指向根节点
        public Node<T> Head
        {
            get { return head; }
            set { head = value; }
        }

        public BiTree(T val)
        {
            //创建一个结点
            Node<T> p = new Node<T>(val);
            //将结点（的引用）传递个给头引用。
            head = p;
        }
        public BiTree(T val, Node<T> lp, Node<T> rp)
        {
            Node<T> p = new Node<T>(val, lp, rp);
            head = p;
        }
        public bool isEmpty()
        {
            if (head == null) return true;
            else return false;
        }
        public Node<T> root()
        {
            return head;
        }
        //注意区分开属性和方法。
        public Node<T> GetLchild(Node<T> p)
        {
            return p.Lchild;
        }
        public Node<T> GetRchild(Node<T> p)
        {
            return p.Rchild;
        }

        //下面开始定义方法
        //在p的左边插入一个子树,而且是插队，p原来就存在自己的左子树
        public void InsertL(T val,Node<T> p)
        {
            Node<T> LNode = new Node<T>(val);
            LNode.Lchild = p.Lchild;
            p.Lchild = LNode;
            //一定注意，p原来就存在着自己的左子树
        }
        public void InsertR(T val,Node<T> p)
        {
            Node<T> tmp = new Node<T>(val);
            tmp.Rchild = p.Rchild;
            p.Rchild = tmp;
        }
        public Node<T>Lchild(T val,Node<T> p)
        {
            if(p==null || p.Lchild == null)
            {
                return null;
            }
            Node<T> ret = p.Lchild;
            p.Lchild = null;
            //进行删除操作，相对于C语言里面要求手动控制内寸，这里是自动删除，所以只需要让引用为空，就能实现自动的删除了。
            return ret;
        }
        
        //public Node<T>Rchild(T val,Node<T> p)
        //{
        //}
        public bool isLeaf(Node<T> p)
        {
            if ((p != null) && (p.Lchild == null || p.Rchild == null)) return true;
            else return false;
        }
        //注意一点：插入删除的套路基本上是一致的，都类似于链表的插入。
    }
}



//我们对于线性结构基本上了解的差不多了，
//下一步就是了解树形结构

    //不带头结点的二叉链表和带有头结点的二叉链表之间的差别：
    // 头指针指向头结点，头结点指向下一个数据元素（首元结点）。
//注意，这里面的删除，是要求你手动的删除引用，让那个引用为null，然后内存方面的删除交个垃圾处理就行了。



    //我总感觉这里面的删除有点草率，感觉这样删除，感觉没有删除最底下的结点。。。。应该是要涉及到递归的。。。。递归删除左结点删除右结点。。。。
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//路径权重加权和最小的路径——WPL最小的情况
namespace 哈夫曼树
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] weights = { 1, 2, 3, 4, 5 };
            LinkHuffman MHT = new LinkHuffman(weights);
            MHT.Create();
            MyNode root = MHT.Root;
            Console.WriteLine(root.Data);
            Console.WriteLine("_________");
            MHT.ForwardTraverse(root);
            Console.ReadLine();
        }
    }
    //给定n个权重 ，构造只有n个结点的二叉树集合
     public class Node 
    {
        private int weight;

        public int Weight 
        {
            get { return weight; }
            set { weight = value; }
        }

        private int lchild;

        public int Lchild
        {
            get { return lchild; }
            set { lchild = value; }
        }
        private int rchild;

        public int Rchild
        {
            get { return rchild; }
            set { rchild = value; }
        }

        private int parent;

        public int Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        public Node()
        {
            weight = 0;
            Lchild = -1;
            Rchild = -1;
            Parent = -1;
        }
        public Node (int _Weight,int _Lchild,int _Rchild,int _Parent)
        {
            Weight = _Weight;
            Lchild = _Lchild;
            Rchild = _Rchild;
            Parent = _Parent;
        }
        public Node(int _Weight)
        {
            Weight = _Weight;
            Lchild = default(int);
            Rchild = default(int);
            Parent = default(int);
        }
    }
    public class SeqHuffman
    {
        private int leafNumber ;

        public int LeafNumber
        {
            get { return leafNumber ; }
            set { leafNumber  = value; }
        }
        private Node[] weights;

        public Node[] Weights
        {
            get { return weights; }
            set { weights = value; }
        }

        //索引器，进行遍历用的
        public Node this[int index]
        {
            get { return weights[index]; }
            set { weights[index] = value; }
        }
        //这个数组里面存的不是int，而是结点类。。。。反正我觉得我写的话，不一样的地方应该挺多的。
        public SeqHuffman(int n)
        {
            weights = new Node[2*n-1];
            leafNumber = n;
        }

        //用的是顺序表来存储二叉树
    }

    public class myHuffmanTree
    {
        private int leafNumber;
        public int LeafNumber
        {
            get { return leafNumber; }
            set { leafNumber = value; }
        }
        private List<Node> myList;
        public List<Node> MyList
        {
            get { return myList; }
            set { myList = value; }
        }
        //索引器 
        public Node this[int index]
        {
            get { return MyList[index]; }
            set { MyList[index] = value; }
        }
        
        //构造器
        public myHuffmanTree(int[] weights)
        {
            List<int> tempList = new List<int>(weights);
            tempList.Sort();//Sort()//默认是从小到大
            for(int i = 0; i < weights.Count(); i++)
            {
                Node myTempNode = new Node(tempList[i]);
                myList.Add(myTempNode);
            }
            LeafNumber = weights.Count();
        }
        //上面创建了大量的结点，存储在myList里面。

        //下面是顺序栈存储huffman树。。。。但是我没用过顺序栈存huffman。。。
        //public List<Node> Create()
        //{
        //    while(myList.Count > 1)
        //    {    
        //    }
        //}
        //问题就是我没有处理过顺序栈= =
    }

    //基于链表的哈夫曼树
    public class MyNode
    {
        private int data;
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        private MyNode lchild;
        public MyNode Lchild
        {
            get { return lchild; }
            set { lchild = value; }
        }
        private MyNode rchild;
        public MyNode Rchild {
            get {return rchild ; }
            set {rchild = value; }
        }
        public MyNode(int number )
        {
            Data = number;
        }
    }
    //基于数据提前排序的huffman树，而且是链子树。
    public class LinkHuffman
    {
        private MyNode root;
        public MyNode Root {
            get { return root; }
            set { root = value; }
             }
        private int TotalNumber;
        List<int> weights = new List<int>();
        List<MyNode> nodes = new List<MyNode>();
        //你只需要有MyNode就可以进行遍历了，没必要有其他的东西。
        //List<MyNode> nodes = new List<MyNode>();

        public LinkHuffman(int [] numbers)
        {            
            for(int i = 0; i < numbers.Count(); i++)
            {
                weights.Add(numbers[i]);
                MyNode TempNode = new MyNode(weights[i]);
                nodes.Add(TempNode);
            }
            weights.Sort();
        }//对于输入的权重进行排序

        
        public void Create()
        {
            while(nodes.Count > 1)
            {
                MyNode upperNode =new MyNode(nodes[0].Data+nodes[1].Data);
                upperNode.Lchild = nodes[0];
                upperNode.Rchild = nodes[1];
                nodes.RemoveAt(0);
                nodes.RemoveAt(0);

                //其实下面的插入算法，完全可以在插入之后，继续进行sort，也就是不管插入的顺序，随便插，然后排序。
                //直接默认比较，比较的是内置类型，所以我们应该使用Icomparable接口，判断到底应该如何进行比较。使用Icomparable继承方法，自己写个函数进行比较。
                nodes.Add(upperNode);
                nodes.Sort(new MyComparer());

                //如果是上面那种插入点然后进行比较的方法就是直接构造比较函数进行比较。
                //for (int i = 0; i < nodes.Count(); i++)
                //{
                //    if(upperNode.Data <= nodes[i].Data)
                //    {
                //        nodes.Insert(i,upperNode);
                //        upperNode = null;
                //        break;
                //    }
                //}
                //if (upperNode != null)
                //{
                //    nodes.Add(upperNode);
                //}
            }
            root = nodes[0];
        }
        //基于提前排好序的数组，实现了BST的链式存储结构。
        //首先就是这个数组的返回情况应该用啥？？？？bool还是int
        public void  ForwardTraverse(MyNode root)
        {
            //声明引用
            MyNode currentNode = root;
            if(currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                if (currentNode.Lchild!= null)
                {
                    ForwardTraverse(currentNode.Lchild);
                }
                if(currentNode.Rchild != null)
                {
                    ForwardTraverse(currentNode.Rchild);
                }
            }
        }
    }
    //构造一个比较器，然后把这个比较器传入sort方法。
    public class MyComparer : IComparer<MyNode>
    {
        public int Compare(MyNode x, MyNode y)
        {
            return x.Data.CompareTo(y.Data);
        }
    }
    //至于说遍历，所有的二叉树的遍历方式
}


//huffman树是不是有更加合适的方法？？？？感觉现在的太麻烦了，需要两个结点诶，有没有一个结点的方法？？？？

//和BST相比较，这个huffman树的查找更快。

//huffman树是完全二叉树，有n个结点，必然有n-1个空节点，最后就是2*n-1个结点。
//传统的顺序存储是带有大量空白位置的存储，而且遍历比较麻烦，也许速度比较快，但是我觉得插入更费事
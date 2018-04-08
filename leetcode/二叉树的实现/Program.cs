using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//似乎国际标准里的树的实现都是不要这个结点类，都是直接调用自身。
namespace 二叉树遍历
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    
    public class Node
    {
        int data;
        Node lchild;
        Node rchild;

        public Node(int val, Node lp, Node rp)
        {
            data = val;
            lchild = lp;
            rchild = rp;
        }
        public Node(Node lp, Node  rp)
        {
            data = default(int);
            lchild = lp;
            rchild = rp;
        }
        public Node(int val)
        {
            data = val;
            lchild = null;
            rchild = null;
        }
        public Node()
        {
            data = default(int);
            lchild = null;
            rchild = null;
        }
        public int Data
        {
            get { return data; }
            set { value = data; }
        }
        public Node  Lchild
        {
            get { return lchild; }
            set { lchild = value; }
        }
        public Node  Rchild
        {
            get { return rchild; }
            set { rchild = value; }
        }
    }    
    
    public class BTreeOLD
    {
        private Node root;
        public Node Root
        {
            get { return root; }
            set { root = value;}
        }
        private bool allowDuplicates;
        public bool AllowDuplicate
        {
            get { return allowDuplicates; }
            set { allowDuplicates = value; }
        }
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        //three ways the mode to traverse the tree.
        public enum TraversalMode
        {
            InOrder = 0,
            PreOrder = 1,
            PostOrder = 2
        }
        //constructor 
        public BTreeOLD()
        {
            count = 0;
            allowDuplicates = true;
            root = null;
        }
        public BTreeOLD(bool _allowDuplicate)
        {
            //this.Count = 0;
            //or 
            count = 0;
            // NO IDEA.
            root = null;
            allowDuplicates = _allowDuplicate;
        }

        public bool isEmpty()
        {
            return count == 0;
        }
        //public int GetHeight()
        //{
            
        //}
        //public bool InsertNode(int value)
        //{

        //}

    }

    //国际标准树_自己调用自己——泛型
    //使用接口就相当于使用现有的功能
    public class Tree<T> where T : IComparable<T>
        //夭寿啦，妈的where限制符号来限制接口了！

        //这里涉及到了如何实现接口的功能
        //在字段中 属性中 显式实现接口 
    {
        private Tree<T> ltree;
        private Tree<T> rtree;
        //  使用data总会出现二义性= =mmp。因为你在相同的命名空间里面声明了相同的东西。
        private T data;
        public T Data
        {
            get { return data; }
            set { this.data = value; }
        }

        public Tree<T> Ltree
        {
            get
            {
                return ltree;
            }

            set
            {
                ltree = value;
            }
        }
        public Tree<T> Rtree
        {
            get
            {
                return rtree;
            }

            set
            {
                rtree = value;
            }
        }

        //构造器
        public Tree(T nodeValue)
        {
            this.data = nodeValue;
            this.ltree = null;
            this.rtree = null;
        }
        //插入节点，按照二叉搜索树的思想进行插入
        //没有处理等于的情况
        public void Insert(T newItem)
        //在非泛型方法上不可以使用约束，那我他妈的就强行泛型方法
        {
            T currentNodeValue = this.Data;

            //这里的CompareTo可是我废了半天功夫在class的声明位置加上的where之后才能用的啊。mmp

            //这里是非常精妙的嵌套，递归操作，是二叉搜索树的核心
            //如果数值小于当前树节点的值，进行左插，然后要进一步判断下一步要左插还是右插，也就是不断的调用自身
            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                if (this.Ltree == null)
                {
                    this.Ltree = new Tree<T>(newItem);
                }
                else
                {
                    this.Ltree.Insert(newItem);
                }
            }
            else if (currentNodeValue.CompareTo(newItem) < 0)
            {
                if (this.Rtree == null)
                {
                    this.Rtree = new Tree<T>(newItem);
                }
                else
                {
                    this.Rtree.Insert(newItem);
                }
            }
        }
        //遍历
        public void PreOrderTree(Tree<T> root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                PreOrderTree(root.Ltree);
                PreOrderTree(root.Rtree);
            }
        }
        public void MidOrderTree(Tree<T> root)
        {
            if (root != null)
            {
                MidOrderTree(root.Ltree);
                Console.WriteLine(root.data);
                MidOrderTree(root.Rtree);
            }
        }
        public void PostOrderTree(Tree<T> root)
        {
            if (root != null)
            {
                PostOrderTree(root.Ltree);
                PostOrderTree(root.Rtree);
                Console.WriteLine(root.data);
            }
        }
        //上面的代码简洁，但是遍历次数比下面略多，判断次数也多。
        //遍历2
        public void PostOrderTree2(Tree<T> root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                if (root.Ltree != null)
                {
                    PostOrderTree2(root.Ltree);
                }
                if (root.Rtree != null)
                {
                    PostOrderTree2(root.Rtree);
                }
            }
        }
        //用Stack实现前中后遍历，也就是利用栈实现，不调用递归
        public void UseStackToPreTraverse(Tree<T> root)
        {
            //push就是在list之前加东西，pop就是直接把头结点拿掉，向后移位置。
            List<Tree<T>> myStack = new List<Tree<T>>();
            //当前的工作结点
            Tree<T> currentNode = root;
            //保存当前pop的结点
            Tree<T> node_pop;

            //把握一个局部，就是当前结点不空，就push同时查看左孩子，左孩子不空，就继续push查看左孩子，左孩子为空，就pop，查看右结点，右孩子不为空，先看右孩子的左孙子。右孩子为空，就看右孩子的右孩子。

            //所以几个比较关键的点就是:左孩子什么状况 ，右孩子什么状况。

            //当前结点不空，就要输出
            //只要当前结点有左下或者有右下，就要push。
            //当前结点左下右下都是空，pop。

            //当前结点，有左孩子，push；
            //左孩子为空pop，当前结点优先指向出栈的结点；
            //左孩子不为空，当前结点移动位置指向左孩子，break，
            //判断当前结点的右孩子，不空，指向右孩子，
            //为空，继续pop，break

            //一旦改变了当前结点，break；
            //一旦pop，立刻判断右孩子；
            //一旦push，立刻判断当前结点的左孩子状况；
            //左孩子不空，移动结点，（push自身，移动结点，break）
            //右孩子不空，移动结点，

            //循环条件是currentNode不为空，并且stack不空。
            while (currentNode != null || myStack.Count > 0)
            //也就是说当前结点可以为空，但是只要你栈里面还有东西就行。
            //你栈也可以是空，但是只要你当前结点不为空就行。
            {
                Console.WriteLine(currentNode.data);
                Push(myStack, currentNode);
                currentNode = currentNode.Ltree;
                while (currentNode == null && myStack.Count > 0)
                {
                    currentNode = GetTop(myStack);
                    node_pop = Pop(myStack);//临时存储当前pop的结点
                    currentNode = currentNode.Rtree;
                }
            }
        }
        //1输出结点，将其入栈，再看p的左孩子是不是为空
        //    2若p的左孩子不为空，将p的左孩子设置为当前结点，重复第一步
        //    3如果p的左孩子为空，将stack栈顶元素 pop，但是不输出，4将出栈结点的右孩子设置为当前结点，判断这个右孩子是不是为空，如果不为空，循环至1.
        //    5如果第四步的右孩子为空，就继续出栈，但是不输出，将出栈结点的右孩子设置为当前结点
        //    6直到当前结点p为空，并且栈空了，结束循环

        public void UseStackToMidTraverse(Tree<T> root)
        {
            List<Tree<T>> myStack = new List<Tree<T>>();
            Tree<T> currentNode = root;//当前结点指向根节点
            Tree<T> note_temp;
            //与前序遍历的差别在于你cw的时机。至于说所谓的创建一个tempNode，那个是后序遍历才会用到的东西。
            while (currentNode != null || myStack.Count != null)
            //如果你这个条件是&&，你甚至都进不了第一层循环
            {
                if (currentNode.Ltree != null)
                {
                    Push(myStack, currentNode);
                    currentNode = currentNode.Ltree;
                }
                else
                {
                    Console.WriteLine(currentNode.data);
                    currentNode = currentNode.Rtree;
                    while (currentNode == null && myStack.Count == null)
                    {
                        Console.WriteLine(currentNode.data);
                        currentNode = Pop(myStack);
                        currentNode = currentNode.Rtree;
                    }
                }
            }
        }
        //第一种理解
        //中序遍历，由于涉及到输出，所以略有不同，但是遍历的原则（注意不是输出的原则）还是一路向左。如果左结点不空，就不断的把十字路口的东西push进去，然后移动结点。如果遇到左结点为空，首先进行输出，然后pop（最近的一层根节点），输出根节点的值，然后判断右边结点是不是空的，如果右边结点是空的，继续返回上一级根节点，输出上一级根节点，然后判断上一级根节点的右结点是不是空的，如果一旦出现了右结点为空的情况，立刻进入左结点模式。

        //  第二种理解
        //左结点不为空——————push，移wpt到左结点。
        //左结点为空——Pop，移动wpt到刚出栈的那个根结点，输出根节点的值，然后移动wpt到右结点。
        //右结点为空——Pop，移动wpt到刚出栈的那个根结点，输出根节点的值，然后移动wpt到右结点。
        //右结点不为空——PUSH，然后，进入左结点判断模式。

        //第三种理解——
        //什么时候要输出什么，输出做结点的前提条件？？输出右结点的前提矫健？？输出当前结点的前提调价你？？？？
        //弄明白——输出 和push的区别

        //第四中理解——根据push和pop的时机来理解。

        public void UseStackToPostReverse(Tree<T> root)
        {
            List<Tree<T>> myStack = new List<Tree<T>>();
            Tree<T> currentNode = root;
            Tree<T> temp_Node;//mmp，终于有点用处了
            Tree<T> previousNode = null; //上一个访问的结点

            Push(myStack, currentNode);
            while (myStack.Count > 0)
            {
                currentNode = GetTop(myStack);
                if ((currentNode.Ltree == null && currentNode.Rtree == null) || (previousNode != null && (currentNode.Ltree == previousNode || currentNode.Rtree == previousNode)))//当前结点左右都是空，或者有左或者有右，但是已经被访问
                {
                    Console.WriteLine(currentNode.data);
                    Pop(myStack);
                    previousNode = currentNode;
                }
                else
                {
                    if (currentNode.Rtree != null)
                    {
                        Push(myStack, currentNode.Rtree);
                    }
                    if (currentNode.Ltree != null)
                    {
                        Push(myStack, currentNode.Ltree);
                    }
                }
            }
        }
        //总体来说，这就是一个不断push，pop的过程，而关键问题就是取决的CW的时机。
        //prev最简单。
        public void MyOwnPreTraverse(Tree<T> root)
        {
            List<Tree<T>> myStack = new List<Tree<T>>();
            Tree<T> wpt = root;
            //Tree<T> temp_Node = default(Tree<T>);
            while (wpt != null || myStack.Count == 0)
            //must be a or judgement.
            //pre-order-traverse 
            {
                Console.WriteLine(wpt.data);//前序遍历直接输出
                Push(myStack, wpt);
                wpt = wpt.Ltree;
                while (wpt == null && myStack.Count > 0)
                {
                    //temp_Node =GetTop(myStack);//其实是因为pop就必须要有一个接收对象，所以用temp_Node来接收，但实际上，在前序遍历中，没用。但是在后续和中旭中，可能要cw。
                    wpt = Pop(myStack);
                    wpt = wpt.Rtree;
                }
                //你可以把前序理解为，首先是一路向左，同时在身后放线（push），记录经过的路口，什么时候为空了，就沿着线回去，同时收线（pop），在回去的路上，遇到一个路口，就去看看右边有没有东西，如果有东西，继续进去，放线（push），然后一旦进去之后，还是一路向左。
                //两个while循环，一个push，一个pop，一个cw。
            }
        }

        //对应的Stack的操作。包括Pop Push 和 getTop
        public void Push(List<Tree<T>> myStack, Tree<T> nodeToPush)
        {
            int count = myStack.Count();
            int i = count - 1;
            //现在有一个问题，这样在外边声明最后的结果是不是-1
            //我觉得应该是-1，因为你不是传引用，而且也不是把参数传进方法。
            for (; i >= 0; i--)
            {
                myStack[i + 1] = myStack[i];
            }
            //输出结果是i==-1
            myStack[i + 1] = nodeToPush;
        }
        public Tree<T> Pop(List<Tree<T>> myStack)
        {
            int count = myStack.Count();
            Tree<T> ret = myStack[0];
            int i = 0;
            for (; i < count - 1; i++)
            {
                myStack[i] = myStack[i + 1];
            }
            //最后输出的时候，i = count-1，正好是元素个数。、
            return ret;
        }
        //获取栈顶元素,但是不输出
        public Tree<T> GetTop(List<Tree<T>> myStack)
        {
            return myStack[0];
        }

        //层序遍历
        public void LayerTraverse(Tree<T> root)
        {
            //应该用队列而而不是stack，当然list两种东西都能表示。
            List<Tree<T>> myList = new List<Tree<T>>();

            //干啥用的？？？？
            myList.Add(this);
            //干啥用的？？？？
            Tree<T> temp = null;
            //进入循环之前应该仅仅有一个头结点存在。而且是根结点。
            //一旦根节点下面有东西，就开始了无穷无尽的循环。
            //你不得不说是很精妙。
            while (myList.Count > 0)
            {
                Console.WriteLine(myList[0].Data);
                temp = myList[0];
                //这样根据数值来remove是不是有点不合适？？
                myList.RemoveAt(0);
                //myList.Remove(myList[0]);
                if (temp.Ltree != null) myList.Add(temp.Ltree);
                if (temp.rtree != null) myList.Add(temp.Rtree);
            }
            //使用队列做层序遍历，具体的小循环就是涉及到了某个节点的时候，首先判断是不是为空，然后输出小节点，将小节点下面的东西push进入queue，然后判断队列中的元素是不是为空，如果队列中还有元素没有输出，就输出一个元素继续上面的判断，直到最后得出结果为止。
            Console.WriteLine();
        }

        //首先将树的根节点入队，如果队列不空，就进入循环，首先把队首元素出队，输出，如果队首有左孩子，入队，如果队首有右孩子，入队。
        public void LayerTraverse2(Tree<T> root)
        {
            if (root == null)
            {
                return;
            }
            //Queue<Tree<T>> myQueue = new Queue<Tree<T>>();
            //myQueue.Enqueue(root);

            //使用List实现队列
            List<Tree<T>> myList = new List<Tree<T>>();
            Tree<T> myNode = default(Tree<T>);//工作指针
            Enqueue(myList, root);

            while(myList.Count > 0)
            {
                myNode = Dequeue(myList);
                Console.WriteLine(myNode.data);
                if (myNode.Ltree != null) Enqueue(myList, myNode.Ltree);
                if(myNode.Rtree != null ) Enqueue(myList, myNode.Rtree);
            }
        }
        public void Enqueue(List<Tree<T>> myList, Tree<T> Node)
        {
            int length = myList.Count;
            myList[length] = Node;
            //将数据插在队尾巴的位置处
        }
        public Tree<T> Dequeue(List<Tree<T>> myList)
        {
            Tree<T> myTreeNode;
            myTreeNode = myList[0];
            for (int i = 0; i < myList.Count; i++)
            {
                myList[i] = myList[i + 1];
            }
            return myTreeNode;
        }
    }
}
//字段 字段的属性 构造器 索引器 状态方法 动作方法
//为什么我们会直接构造二叉搜索树？？？因为二叉树的数据插入方法需要一个规定，所以我们选择了二叉搜索树。


//我觉得真的是说不同语言对于遍历的实现方式有挺差别的，但是基本的嵌套思想没有差别。


    //上面的二叉搜索树，主要里面存储的是data。然后我们下面的哈夫曼树，是存储着权重和data。
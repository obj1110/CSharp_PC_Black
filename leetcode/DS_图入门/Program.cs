using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//由于图的特殊性质，会涉及到的包括图的最短路径，同时需要区分开的就是图的有向和无向。
namespace DS_图入门
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //结点类比较简单，就是一个data属性就完了。
    public class Node<T>
    {
        private T data;
        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node (T v)
        {
            this.Data = v;
        }
    }
    public interface IGraph<T> {
        int GetNumOfVertex();
        //其实是设计到无向图的遍历
        int GetNumOfEdge();
        //也是图的遍历
        void SetEdge(Node<T> v1, Node<T> v2, int value);
        void DelEdge(Node<T> v1, Node<T> v2);
        bool isEdge(Node<T> v1, Node<T> v2);
        //判断两个点之间是不是联通的。
    }
    //图的表示——邻接矩阵法 或者是 邻接表法
    //使用邻接矩阵可以方便的表示二者之间的关系，但是就是在统计边或者弧段的个数方面非常的困难。因为需要每行每列的来加。
    //方便之处——确定边或者弧段的权重非常方便。确定点之间的关系非常的方便。计算某个结点的入度和出度非常的方便，直接把某一行或者某一列相加就行了。
    //然后可以规定点之间断的情况，用无穷或者是一个很大的权重表示断裂。

    //无向图的邻接矩阵类的实现来说明图的临邻接矩阵表示类的实现。
    public class GraphAdjMatrix<T>
    {
        private Node<T>[] nodes;
        private int numEdges;
        public int NumEdges
        {
            get { return numEdges; }
            set { numEdges = value; }
        }
        
        private int[,] matrix;
        //索引器 ！！！！！
        //二维数组有没有自己对应的属性访问器？？？

        
        //虽然感觉上面这个使用二维数组比较死板，但是也没有别的办法了。

        public GraphAdjMatrix(int n)
        {
            //图邻接矩阵的构造函数
            nodes = new Node<T>[n];
            matrix = new int[n, n];
            numEdges = 0;
        }

        public Node<T> GetNode(int index)
        {
            return nodes[index];
        }
        public void SetNode(int index ,Node<T> v)
        {
            nodes[index] = v;
        }
        public void SetMatrix(int index1,int index2)
        {
            matrix[index1, index2] = 1;
        }
        public int GetMatrix(int index1,int index2)
        {
            return matrix[index1, index2];
        }

        //结点的个数，注意二维数组自带对于不同维度和整体进行数目统计的功能。
        public int GetNumOfVertex()
        {
            return nodes.Length;
        }
        public int GetNumOfEdge()
        {
            return numEdges;
        }
    }
}

//图这里，难点是增加结点或者删除结点的时候，对于邻接矩阵的改变。
//如果我声明了一个二维的数组，那么我要用什么方式，将这个二维数组设置为属性？说


////////////////////////////////////////////////////////////////////////////////////
//concept

//class图至少需要一个存储结点的一维数组和一个描述点和点之间关系的二维数组。
//分类：无向图——也就是顶点和顶点之间的连线没有方向。(边）
//    有向图——任意两个顶点之间的数对是有顺序的。（弧）
//    完全图——任何两个顶点之间都有联系。
//    网——弧或者边上带有权重
//    度——依附于顶点的边数的和，如果是有向图就是入度+出度的和。

//9 
//路径——就是从顶点A到顶点B所需要经过的顶点。
//简单路径——路径上的顶点不会重复出现，

//10
//回路——第一个顶点和最后一个顶点相同的路径。
// 简单回路——除了第一个顶点和最后一个顶点相同，其余顶点都不重复的回路。

//11 联通
//顶点之间有路径就是联通的。
//（无向图）连通图——任意两个点之间都是联通的，则G是联通图
//联通分量——是无向图。


//如何理解联通分量？？？

//带有强字的，都是强调方向的，强调有向图的。

//（有向图）  强连通图——有向图中任意两个顶点之间都存在着从一个顶点到另外一个顶点的弧段路径。
//强连通分量——有向图的极大强连通子图。
//极大强联通子图是一个有向图的强联通子图。

//强连通图 极大强联通子图 强连通分量？？？

//这个强联通不一定是双向的，即使是完全图，也没说一定是有向的。

//生成树其实也是一个连通图，指的是包含着G全部顶点的一个极小的联通子图，所谓极小的联通子图是指包含n个顶点的前提下，包含最少的边。
//一棵具有n个顶点的联通图G的生成树有且仅有n-1个边，少一个边就不是连通图，多一个边就一定有环存在。

    






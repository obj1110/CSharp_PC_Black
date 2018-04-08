using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5_封装和继承
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
//封装
//继承

//封装技术1：成员访问修饰符

//public_不管是不是继承类，不管是不是相同的程序集（using）都能用。
//private——只有继承类，并且同一个命名空间
//internal——只有using，不管继承
//protected——只有继承类，不管using
//internal protected——继承或者是using。

//注：继承是可以在不同的命名using空间里面

//封装技术2：属性——get和set
//每次在改变类内部的字段之后，必须确保完全得到修改。
//属性保证了内部数值的一致性——小写的叫做后备字段，大写的叫做属性。
//此外，在set里面可以对于这个类进行修改，以便保证数据的合法性。

    //可以使用set或者get实现属性的只读或者只写。

    //对于私有字段的赋值——主要是在构造函数中赋值？？readonly类型的呢？？？？readonly属于什么情况呢？？？


  //对于封装的小结——封装private public protected internal
  //属性有什么用处——对于外部程序而言就是一个调用，而对于内部而言就是有很多好处的调用数据。实际上就是一个封装的事情。
  //封装是一种思想上的封装。

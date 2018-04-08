using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_基于List实现二维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<List<int>> array1 = new List<List<int>>();
            //for(int i = 0; i < 10; i++)
            //{
            //    List<int> SubArray = new List<int>();
            //    for (int j = 0; j < 10; j++)
            //    {    
            //        SubArray.Add(i * 10 + i);
            //    }
            //    array1.Add(SubArray);
            //}
            //Console.WriteLine(array1.Count);
            //单纯这样看，肯定最后的返回值是一维数组的个数。


            Console.ReadLine();
        }
    }
    //分不清应该用IComparable还是IComparer这两个东西。
    public class DynamticArray<T> where T:IComparer<T>
    {
        private List<List<T>> array;

        public List<List<T>> Array
        {
            get { return array; }
            set { array  = value; }
        }
        private int elemNumber;

        public int ElemNumber
        {
            get { return ElemNumber ; }
            set { ElemNumber  = value; }
        }
        //对于索引器的研究还是不够深入=-= 
        public T this[int index1,int index2]
        {
            get { return Array[index1, index2]; }
            set { Array[index1, index2] = value; }
        }
        //如何实现二维索引器的构建？？
        public void Create(T[,] numberArray)
        {
            
            for(int i = 0; i < numberArray.GetLength(1);i++)
            {
                for(int j = 0; j < numberArray.GetLength(2);j++)
                {
                    Array[i,j] = numberArray.GetValue(i,j);
                }
            }
            //下面就是循环赋值操作了
        }
        //主要是在做图方面的数据结构的实现的时候，遇到声明二维数组的情况。
    }
}


//如果对 List<T> 类的类型 T 使用引用类型，则两个类的行为是完全相同的。 但是，如果对类型 T 使用值类型，则需要考虑实现和装箱问题。想二维数组和一维数组那样能用好多方法，在这里可以实现：那就是利用泛型List<T>。
//也就说，对于一个List<T>来说，T最好就是用一个引用类型，而不是传统的值类型。

    //可以使用[,].GetLength的方法来获取二维数组或者多维数组的一个维度情况。

    //二维数组可不可以进行动态的变化，包括扩大和缩小？？
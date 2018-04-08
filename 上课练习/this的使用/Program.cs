using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this的使用
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class exampleA
    {
        public string Name;
        public string Sex;
        public void Func1(string Name, String Sex)
        {
            this.Name = Name;
            this.Sex = Sex;
        }//隐藏名字相同的对象 
        //将对象作为参数传递到其他方法
        public class Person
        {
            public string Name
            {
                set;
                get;
            }
            public void ShowName()
            {
                Helper.PrintName(this);
            }
        }
        //this指代当前的对象
        public static class Helper
        {
            public static void PrintName(Person person)
            {
                Console.WriteLine();
            }
        }
    }
}

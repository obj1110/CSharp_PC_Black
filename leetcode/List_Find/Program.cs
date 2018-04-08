using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//List的Find家族很强大，可以基于索引，也可以使用匿名委托（lambda或函数指针）进行访问。
//List.FindLast(Predicate<Task> match);

//List.Find(Predicate<Task> match);
//ListFind是自己定义的方法,可以通过委托的方式传进Find方法，当然尽量简化为lambda表达式。

//List.TrueForAll(Predict<T>match);判断所有的东西是不是都符合lambda
//List.Take(n);返回前n行

    //List.Where(Predict<T> match ) 与 findall类似
    //List.RemoveAll(predict<T>match ) 

namespace List_Find
{
    public class Example 
    {
        static void Main(string[] args)
        {
            Random Randomitzer = new Random();
            List<HockeyTeam> teams = new List<HockeyTeam>();
            //声明不初始话，但是后续会增加元素。
            teams.AddRange(new HockeyTeam[]
            {
                new HockeyTeam("Detroit Red Wings", 1926),
                new HockeyTeam("Chicago Blackhawks", 1926),
                new HockeyTeam("San Jose Sharks", 1991),
                new HockeyTeam("Montreal Canadiens", 1909),
                new HockeyTeam("St. Louis Blues", 1967) });
            //或者是：
            //HockeyTeam[] HT = new HockeyTeam[] { new HockeyTeam("Detroit Red Wings", 1926),
            //    new HockeyTeam("Chicago Blackhawks", 1926),
            //    new HockeyTeam("San Jose Sharks", 1991),
            //    new HockeyTeam("Montreal Canadiens", 1909),
            //    new HockeyTeam("St. Louis Blues", 1967) };
            //teams.AddRange(HT);

            int[] years = { 1920, 1930, 1940, 1950 };
            int foundedBeforeYear = years[Randomitzer.Next(0, years.Length)];
            // 就是随机抽取一个年份出来
            Console.WriteLine("teams founded before {0}: ",foundedBeforeYear);
            //var用于声明了类型
            foreach (var team in teams.FindAll(x => x.Founded <= foundedBeforeYear))
            {
                Console.WriteLine("{0},{1}", team.Name,team.Founded);
            }
            //其中find是构造一个Lambda的形式。
            //FindAll必须的是一个Lambda用于构造Predict<T>

        }
    }
    //定义了一个类，有两个私有变量，有两个方法用于返回私有变量值。有一个构造函数用于给这两个变量赋值。
    public class HockeyTeam
    {
        private string _name;
        private int _founded;

        public HockeyTeam(string name,int year)
        {
            this._name = name;
            this._founded = year;
        }
        public string Name
        {
            get { return _name; }
        }
        public int Founded
        {
            get { return _founded; }
        }
    }
    //get 和 set访问器究竟是做什么用的？？
}

//list.find(Predicate <T>)作为参数。
//表示定义一组条件并确定指定对象是不是符合这些条件的方法

//public delegate bool Predicate<in T>(T obj);
//public delegate bool Predicate<string>(string obj);

    //注意这个list.find(可以选择lambda表达式或者是将一个函数作为委托传递进来，而delegate本身就是函数指针)

    //所以，可以在下面写一个判断姓名长度的函数的形式，或者是直接lambda。但是万变不离其宗，我们需要的是一个函数指针，一个委托。

namespace New
{
    public class Solution
    {
        public static void main()
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//委托，类，接口都是平级的。

//我们想实现的就是Customer自己，如果会Order，然后就会出现一个Waiter进行相应。
namespace BS_事件7
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            //一旦Customer开始Order，waiter立即做出反应。
            //注意（）加不加的区别，加上这个（），就是调用了。包括委托的声明中等等，我们都不使用这种（）。也就是不进行调用。
            customer.Order += Waiter.Action;
            customer.Action();
            customer.paidBill();
        }
    }
    //声明委托类型——）委托是类，是数据类型

    //需要传递事件的对象和接收事件返回值的类。
    //(object sender，EventArgs e) (Customer customer,OrderEventArgs e)
    //注意，这个object和EventArgs以及delegate的访问级别必须都是一致的的。
    //至于说：为何使用方法耦合级别的这个delegate，是另外一个问题了。
    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);
    //传递事件信息的类,必须要派生自EventArgs
    public class OrderEventArgs:EventArgs
    {
        public string DishName { get; set; }
        public string Size { get; set; }
    }

    public class Customer
    {
        private OrderEventHandler orderEventHandler;
        public event OrderEventHandler Order{
            add
            {
                this.orderEventHandler += value;
            }
            remove
            {
                this.orderEventHandler -= value;
            }
        }

        public double Bill
        {
            get;set;
        }
        public void paidBill()
        {
            Console.WriteLine("I will pay {0}.",this.Bill);
        }
        public void Walkin()
        {
            Console.WriteLine("Walkin!");
            System.Threading.Thread.Sleep(1000);
        }
        public void Sit()
        {
            Console.WriteLine("Sit down!");
            System.Threading.Thread.Sleep(1000);
        }
        public void Think()
        {
            Console.WriteLine("Let me have a think!");
            System.Threading.Thread.Sleep(1000);
            //代表当前没有Waiter处理这个事件。__如果为空的话。
            if (this.orderEventHandler != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "fuck!";
                e.Size = "large";
                this.orderEventHandler.Invoke(this,e);
                
            }
        }
        public void Action()
        {
            Console.ReadLine();
            this.Walkin();
            this.Sit();
            this.Think();
        }
    }
    public class Waiter
    {
        //就是一个事件处理器
        internal static void Action(Customer customer, OrderEventArgs e)
        {
            Console.WriteLine("I will serve the dish - {0}.",e.DishName);
            double price = 10.0;
            switch (e.Size)
            {
                case "small":
                    price = price * 0.5;
                    break;
                case "large":
                    price = price * 1.5;
                    break;
                default:
                    break;
            }
            customer.Bill += price;
        }
    }
    //事件无论是从表层还是从底层都是要依赖于委托类型的。
    //委托是事件的基础，事件是委托的上层建筑。
}
//事件的完整声明
//餐馆吃饭，服务员过来订阅你点菜的时间，会给你上菜，然后会在账单上订阅你点菜的事件，然后编写服务员订阅和点菜的事件。

    //委托就是把方法当做参数，也可以是方法的参数
    //事件处理器就是一个类的方法。
    //委托就是一个方法的引用，确定这个方法什么时候进行调用。
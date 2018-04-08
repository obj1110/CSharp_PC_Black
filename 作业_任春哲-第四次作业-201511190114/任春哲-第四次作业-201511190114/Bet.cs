using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 任春哲_第四次作业_201511190114
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        //构造函数
        public Bet(int _Amount,int _Dog)
        {
            Amount = _Amount;
            Dog = _Dog;
            Bettor = null;
        }

        //我觉得这个类并没啥用。
        public string GetDescription()
            //主要在Form1里面引用
        {
            string myString = string.Empty;
            if (Amount == 0)
            {
                myString = "等待"+Bettor.Name + "下注。";
            }
            else
            {
                myString = Bettor.Name + "给第" + (Dog) + "号狗下注" + Amount + "USD。";
            }
            return myString;
        }

        //如果狗赢了，返回正值，如果狗输了，返回负值。
        public int PayOut(int winner)
        {
            if (winner == Dog)
            {
                return Amount * (1);
            }
            else
            {
                return Amount * (-1);
            }
        }
    }
}
//这里面的每一个类都实现了自己对于这个控件的控制。

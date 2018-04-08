using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeMoney
{
    public class MoneyExchange
    {
        public int JoeMoney { set; get; }
        public int BobMoney { set; get; }

        public int BankMoney{set;get;}
        public MoneyExchange(int m_JoeMoney,int m_BobMoney,int m_BankMoney){
            JoeMoney = m_JoeMoney;
            BobMoney = m_BobMoney;
            BankMoney = m_BankMoney;
            }
        public void ChangeMoney(string loser,int value)
        {
            if (loser == "Joe")
            {
                JoeMoney += value;
                BankMoney -= value;
            }
            else if (loser == "Bob"){
                BobMoney -= value;
                BankMoney += value;
            }
        }
    }
}

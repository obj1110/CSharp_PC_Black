using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeMoney
{
    public partial class Form1 : Form
    {
        MoneyExchange ME = new MoneyExchange(80, 80, 90);
        int bankMoney = 90;
        int BobMoney = 80;
        int JoeMoney = 80;
        public Form1()
        {
            InitializeComponent();
            label_BankMoney.Text = bankMoney.ToString();
            label_BobMoney.Text = BobMoney.ToString();
            label_JoeMoney.Text = JoeMoney.ToString();
        }

        private void button1_giveJoe(object sender, EventArgs e)
        {
            ME.ChangeMoney("Joe",10);
            bankMoney -= 10;
            JoeMoney += 10;
            label_BankMoney.Text = bankMoney.ToString();
            label_JoeMoney.Text = JoeMoney.ToString();
        }

        private void button2_giveBob(object sender, EventArgs e)
        {
            ME.ChangeMoney("Bob",5);
            bankMoney += 5;
            BobMoney -= 5;
            label_BankMoney.Text = bankMoney.ToString();
            label_BobMoney.Text = BobMoney.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 任春哲_第四次作业_201511190114
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRatioButton;
        public Label myLabel;
        //自己加了一个构造函数
        public Guy(string _Name,int _Cash,RadioButton _RBT,Label _L,Bet _myBet)
        {
            Name = _Name ;
            Cash = _Cash ;
            MyRatioButton = _RBT ;
            myLabel = _L ;
            MyBet = _myBet;
        }

        //实现不同窗口的数据交换
        public void UpdateLabels()
        {
            MyRatioButton.Text = Name + " has " + Cash + " Bucks!"; 
            //我觉得没必要声明label的具体情况。
        }
        public void ClearBet()
        {
            MyBet.Amount = 0;
            MyBet.Dog = 0;
            MyBet.GetDescription();
            //这个东西应该可以直接更改label
        }
        //这个东西表示的是下注之前的最后的准备工作
        public bool PlaceBet (int _amount ,int _Dog)
        {
            //主要是给bet类赋值
            if (this.Cash >= _amount)
            {
                this.MyBet.Amount = _amount;
                this.MyBet.Dog = _Dog;
                return true;
            }
            else
            {
                MessageBox.Show("Not Enough Money to paticipate this dirty Capitalism Gambling，Comrade！\nНе достаточно денег, чтобы принять участие в этом грязном капитализме, азартные игры, товарищ!", "提示!");
                return false;
            }
        }
        public void Collect(int Winner)
        {
            //通过调用bet类来更改guy类。
            Cash+= MyBet.PayOut(Winner);
            UpdateLabels();
        }
    }
}
//我们现在最大的问题就是对于窗口之间传递数值还是非常的不熟悉，这一点很危险。
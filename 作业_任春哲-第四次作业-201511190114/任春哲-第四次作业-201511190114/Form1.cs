using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 任春哲_第四次作业_201511190114
{

    public partial class Form1 : Form
    {
        //这里我觉得以后可以试试List<T>
        Guy[] guys = new Guy[3];
        Dog[] dogs = new Dog[4];
        Bet[] bets = new Bet[4];
        Dog[] dogList = new Dog[4];
        int winnerDog = -1;

        int flag_Guy;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Welcome to this dirty Capitalism Gambling,Comrade!");
            //有两种初始化方式，用构造函数或者显式构造。
            bets[0] = new Bet(-1, -1);//Amount dog
            bets[1] = new Bet(-1, -1);
            bets[2] = new Bet(-1, -1);
            //对于guy的构造函数，直接声明这种bet对象。
            guys[0] = new Guy("Joe", 50, radioButton_Joe, label_Joe, bets[0]);
            guys[1] = new Guy("Bob", 75, radioButton_Bob, label_Bob, bets[1]);
            guys[2] = new Guy("Al", 45, radioButton_Al, label_Al, bets[2]);
            bets[0].Bettor = guys[0];
            bets[1].Bettor = guys[1];
            bets[2].Bettor = guys[2];

            //控制赛道的长度
            int distance_cts = 520;

            //开始的位置，赛道的距离，所选用的pictureBox，运动的总体的distance。
            dogList[0] = new Dog(15, distance_cts, pictureBox_Dog1, 0);
            dogList[1] = new Dog(15, distance_cts, pictureBox_Dog2, 0);
            dogList[2] = new Dog(15, distance_cts, pictureBox_Dog3, 0);
            dogList[3] = new Dog(15, distance_cts, pictureBox_Dog4, 0);
            //一开始关闭比赛按钮。
            button_Race.Enabled = false;
        }

        private void radioButton1_Joe_CheckedChanged(object sender, EventArgs e)
        {
            guys[0].UpdateLabels();
            //这个label_name是三个公用，没必要在类里面声明。
            label_Name.Text = " 当前下注人: " + guys[0].Name;
            flag_Guy = 0;
        }
        //用一个private 变量指明当前选中的复选框的情况。
        private void radioButton_Bob_CheckedChanged(object sender, EventArgs e)
        {
            guys[1].UpdateLabels();
            label_Name.Text = " 当前下注人: " + guys[1].Name;
            flag_Guy = 1;
        }
        private void radioButton_Al_CheckedChanged(object sender, EventArgs e)
        {
            guys[2].UpdateLabels();
            label_Name.Text = " 当前下注人: " + guys[2].Name;
            flag_Guy = 2;
        }
        private void button_Bet_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
            //获取文本框的数据
            int betAmount = (int)numericUpDown_Bet.Value;
            int dogNumber = (int)numericUpDown_Dog.Value;
            switch (flag_Guy)
            {
                case 0:
                    //一个是改变bet类的情况，一个是用bet类描述下注情况
                    guys[0].PlaceBet(betAmount, dogNumber);
                    label_Joe.Text = bets[0].GetDescription();
                    break;
                case 1:
                    guys[1].PlaceBet(betAmount, dogNumber);
                    label_Bob.Text = bets[1].GetDescription();
                    break;
                case 2:
                    guys[2].PlaceBet(betAmount, dogNumber);
                    label_Al.Text = bets[2].GetDescription();
                    break;
                default:
                    break;
                    //这里面出现的一个问题就是。如果你已经将一个bets和一个guy相关联，你要是再次关联并且尝试修改就会出错。
                    //fatal error!!!
            }
            if (bets[0].Amount > 0 && bets[1].Amount > 0 && bets[2].Amount > 0) button_Race.Enabled = true;
        }

        private void button_Race_Click(object sender, EventArgs e)
        {
            button_Bet.Enabled = false;
            bool b1 = false;
            bool b2 = false;
            bool b3 = false;
            bool b4 = false;

            //目前遇到一个问题就是：比赛一次之后，为何第二次只进了一次循环？？就是因为第二次进行一次循环就得到最种的结果，也就是说，第一次结束后的重置操作不彻底。
            while (!b1 && !b2 && !b3 && !b4)
            {
                Application.DoEvents();

                pictureBox_Dog1.Refresh();
                pictureBox_Dog2.Refresh();
                pictureBox_Dog3.Refresh();
                pictureBox_Dog4.Refresh();

                System.Threading.Thread.Sleep(80);
                b1 = dogList[0].Run();
                b2 = dogList[1].Run();
                b3 = dogList[2].Run();
                b4 = dogList[3].Run();
            }
            //如何处理并发的狗胜利的情况也是个问题。
            if (b1 == true)
            {
                winnerDog = 1;
                MessageBox.Show("胜者是: 1号狗\nthe winner dog is # 1\nпобедитель собаки №1", "比赛结果");
            }
            else if (b2 == true)
            {
                winnerDog = 2;
                MessageBox.Show("胜者是: 2号狗\nthe winner dog is # 2\nпобедитель собаки №2", "比赛结果");
            }
            else if (b3 == true)
            {
                winnerDog = 3;
                MessageBox.Show("胜者是: 3号狗\nthe winner dog is # 3\nпобедитель собаки №3", "比赛结果");
            }
            else if (b4 == true)
            {
                winnerDog = 4;
                MessageBox.Show("胜者是: 4号狗\nthe winner dog is # 4\nпобедитель собаки №4", "比赛结果");
            }
            //调用狗里面的类开始进行计算，并且将数据输出到picbox
            guys[0].Collect(winnerDog);
            guys[1].Collect(winnerDog);
            guys[2].Collect(winnerDog);
            guys[0].ClearBet();
            guys[1].ClearBet();
            guys[2].ClearBet();
            label_Joe.Text = bets[0].GetDescription();
            label_Bob.Text = bets[1].GetDescription();
            label_Al.Text = bets[2].GetDescription();
            if (winnerDog != -1)
            {
                dogList[0].TakeStartingPosition();
                dogList[1].TakeStartingPosition();
                dogList[2].TakeStartingPosition();
                dogList[3].TakeStartingPosition();
            }
            winnerDog = -1;
            guys[0].UpdateLabels();
            guys[1].UpdateLabels();
            guys[2].UpdateLabels();
            button_Race.Enabled = false;
            button_Bet.Enabled = true;
        }
        //这里想实现一个功能就是，如果是三个bet都已经成功下注了，那么我的button就变成可以用race！
        //如果在窗体中点击了enter，相当于是输入了开始比赛。
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //&& (button_Race.Enabled == false)
            if (e.KeyCode == Keys.Enter)
            {
                //this.button_Bet_Click(sender,e);
                button_Bet.PerformClick();
            }
        }
    }
}

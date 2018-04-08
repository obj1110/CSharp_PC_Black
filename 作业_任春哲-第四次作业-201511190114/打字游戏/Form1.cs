using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打字游戏
{
    public partial class Form_Box : Form
    {
        public Stats stats = new Stats();
        public Random randomizter;
        public Form_Box()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //根据Ascii码获取的东西，然后大概的范围在a~z
            listBox1.Items.Add((Keys)randomizter.Next(65, 90));
            //一旦积累的量超过7个之后，GG。
            if(listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game Over");
                timer1.Stop();
            }
        }
    }
    public class Stats
    {
        public int Total = 0;
        public int Missed = 0;
        public int Correct = 0;
        public int Accuracy = 0;

        public void Update(bool correctKey)
        {
            Total++;
            if (!correctKey)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }
            Accuracy = 100 * Correct / (Missed + Correct);
        }
    }
}

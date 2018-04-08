using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 第三周上课
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int length = Talker.BlahBlahChange(textBox1.Text, (int)numericUpDown1.Value);
            MessageBox.Show("this messge length is:"+length);
        }
    }
    public class Talker
    {
        public static int BlahBlahChange(string thingToSay ,int numberOfTimes)
        {
            string finalString = "";
            for(int count = 1; count <= numberOfTimes; count++)
            {
                finalString = finalString + thingToSay + "\n";
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}

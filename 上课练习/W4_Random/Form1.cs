using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4_Random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MenuMaker MM = new MenuMaker();
            MenuMaker.getMeats();
        }
    }

    public class MenuMaker {
        public static Random Randomizter;
        public static string[] Meats = { "Meat1", "Meat2", "Meat3" };
        public static int[] number = new int[5] { 1, 2, 3, 4, 5 };
        public static void getMeats()
        {
            
            int output = number[2];
            string output2 = Meats[2];
            MessageBox.Show(output.ToString());
            MessageBox.Show(output2);

            string output3 = Meats[Randomizter.Next(Meats.Length)];
            //是不是Randomiter的next方法没办法实例调用

        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 上课练习
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;
        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant("Lucinda",33);
            lloyd = new Elephant("lloyd",23);

            //数组是一种引用对象
            int[] array1 = new int[6];
            array1[0] = 6;
            int[] array2 = array1;
            array1[0] = 20;

            //下一个例子
           
        }

        private void button_Lloyd_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button_Lucinda_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button_Swap_Click(object sender, EventArgs e)
        {
            Elephant holder=lloyd;
            lloyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Object Swapped!");
        }

        //对于数组的练习
        private void change_array(int [] array )
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i]++;
            }
        }
        private void change_num(int num)
        {
            num += 1;
        }

        private void button_int_parameter_Click(object sender, EventArgs e)
        {
            int number = 1;
            change_num(number);
        }

        private void button_array_parameter_Click(object sender, EventArgs e)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            change_array(array);
        }
    }

    public class Elephant
    {
        public string Name;
        public int EarSize;
        public Elephant(string _name ,int _earsize)
        {
            Name = _name;
            EarSize = _earsize;
        }
        //相当于是返回属性
        public void WhoAmI()
        {
            MessageBox.Show("My ears are "+EarSize+" inches tall.",Name +" says.......");
        }
        public 
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体之间传值操作1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            newForm2.String1 = "传值给子窗口！";
            newForm2.Setvalue();
            newForm2.ShowDialog();
        }
    }
}

//这是通个构造函数传参，除此之外还可以通过全局变量，属性，方法传参

//窗口之间传递数值其实就是类之间传递数值。
//传递的东西包括了引用类型和值类型
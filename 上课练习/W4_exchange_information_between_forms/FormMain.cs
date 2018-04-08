using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//主要是C# 窗口之间的数据传递操作 
namespace W4_exchange_information_between_forms
{
    public partial class FormMain : Form
    {
        public int  Value_Main = 0;
        public FormMain()
        {
            InitializeComponent();
        }
        //这是主窗口
        private void button_OpenSub_Click(object sender, EventArgs e)
        {
            Form_Sub form_sub1 = new Form_Sub();
            form_sub1.ShowDialog();
            //创建一个子窗口对象并且实例化
            this.label_Main.Text = System.Convert.ToString(form_sub1.Value_Sub);
        }
        //应该是用主窗口给字窗口传递数值
        private void button_Main2Sub_Click(object sender, EventArgs e)
        {
            Form_Sub form_sub1 = new Form_Sub();
            //这里更改了控件的一个访问属性。变成了public。
            form_sub1.label_Sub.Text = Convert.ToString(this.numericUpDown_Main.Value);
            form_sub1.Show();
            //show和showdialog之间的差别就在于其余窗口的可调用性上面。
        }
    }
}
//一个Windows窗体就代表了.NET架构里的System.Windows.Forms.Form类的一个实例
//而对于初学者来说这些基础的东西往往是一个问题，并且存在这种现象，往往比较复杂的东西他们会，要用什么了就去学什么，实际上并没有真正的去理解掌握它，基础不扎实
//一定要注意，所有的变量一定声明访问权限符号。因为默认全是private，
//不仅仅是变量，包括控件也是有自己的访问权限的。

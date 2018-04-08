using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4_Forms_exchange
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_set_parameter_Click(object sender, EventArgs e)
        {
            Form2 form_2 = new Form2();//方式一，创建一个次窗口
            form_2.form1 = this;
            form_2.ShowDialog();
            
           //将主窗口传递给次窗口
            //这句话的意思就是说，form_2中声明的form1同样对于我Form1中的form1有操作权限，其实二者本来就是两个指向同一个对象的**两个标签**。

            //也就是将当前在Form1里面的form1实例，传递给Form2中的form1实例，从而可以在Form2中的form1对象中对我们的Form1中的form1对象进行控制。
            //刘老师的意思就是，这个东西是一个对象的两个别名。
            //这里我还是不懂


            this.label_parameter_1.Text = form_2.param1.ToString();
            this.label_parameter_2.Text = form_2.param2.ToString();
            //this指向的是当前的这个form1窗口。

            //另外一种方法就是把主窗口传递给此窗口。
        }
    }
}
//类之间传递数值的关键————就是要在被传递类中声明类的一个引用对象，也就是标签。

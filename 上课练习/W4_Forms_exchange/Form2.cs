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
    public partial class Form2 : Form
    {
        public int param1 = 0;
        public int param2 = 0;

        public Form1 form1;
        //一个可以访问到主窗口的标签

        //只有声明为public之后才可以在别的类里面访问。
        public Form2()
        {
            InitializeComponent();
        }
        //退出之前需要点击的东西
        private void button_exchange_Click(object sender, EventArgs e)
        {
            this.param1 = (int)numericUpDown_parameter_1.Value;
            this.param2 = (int)numericUpDown_parameter_2.Value;
            this.Close();
        }
    }
}

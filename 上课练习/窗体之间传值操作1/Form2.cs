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
    public partial class Form2 : Form
    {
        private string string1;
        public string String1
        {
            set
            {
                string1 = value;
            }
        }
        public void Setvalue()
        {
            this.label_Form2.Text = string1;
        }
        //接收从父串口（其他类）传递进来的值


        public Form2()
        {
            InitializeComponent();
        }
    }
}

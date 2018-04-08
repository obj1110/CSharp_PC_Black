using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;  //包含了类型转化的部分
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4_exchange_information_between_forms
{
    public partial class Form_Sub : Form
    {
        public int Value_Sub = 0;
        public Form_Sub()
        {
            InitializeComponent();
        }
        //这个是子窗口
        private void button_2Main_Click(object sender, EventArgs e)
        {
            this.Value_Sub = System.Convert.ToInt16(this.numericUpDown_Sub.Value);
            this.Close();
            //这两个this指代的都是当前的对象
            //然后使用的是Convert进行数据类型的转化
        }
    }
}

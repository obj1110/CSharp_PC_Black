using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.FromArgb(255, 255, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(checkBox1.Checked == true)
            //{
            //    //MessageBox.Show("Change color Confirmed! ");
            //    label1.BackColor = Color.FromArgb(255, 0, 255, 0);

            //}
            //else
            //{
            //    label1.BackColor = Color.FromArgb(255, 0, 0,255);
            //}

            if (this.Enabled == true)
            {
                label1.BackColor = Color.FromArgb(255, 0, 0, 255);
            }
        }
    }
}

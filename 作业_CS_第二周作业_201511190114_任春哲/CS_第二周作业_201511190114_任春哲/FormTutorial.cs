using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_第二周作业_201511190114_任春哲
{
    public partial class FormTutorial : Form
    {
        public FormTutorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormMain formmain = new FormMain();
            formmain.ShowDialog();//将窗体显示为模式对话框
            this.Close();
        }
        private void FormTutorial_Shown_1(object sender, EventArgs e)
        {
            while (this.Visible)
            {
                for (int c = 0; c < 254 && Visible; c++)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(5);
                }
            }
            for (int c = 0; c < 254; c++)
            {
                this.BackColor = Color.FromArgb(c, 255 - c, c);
                Application.DoEvents();
                System.Threading.Thread.Sleep(5);
            }
            this.Dispose();//不加这句话似乎会引起多线程问题
        }
    }
}

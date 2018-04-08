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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Text = "欢迎使用本系统！";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();//将窗体显示为模式对话框
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            System.Environment.Exit(0);
        }

        private void FormMain_Shown(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            FormTutorial formTutorial = new FormTutorial();
            formTutorial.ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CS_第二周作业_201511190114_任春哲
{

    public partial class Form1 : Form
    {
        public string FileName { get; set; }
        public string FolderPath { get; set; }
        public string FullPath { get; set; }
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            textBox1.Text = "MS1024";
            numericUpDown1.Value = 10;
            textBox9.Text = "Justin.Ren";
            textBox6.Text = "Stratocaster";
            textBox5.Text = "Electric";
            textBox7.Text = "Alder";
            textBox8.Text = "Alder";
            button6.Enabled = false;
            button5.Enabled = false;
            textBox3.Text = @"C:\Users\Ren\Desktop\C#作业";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            FormMain formmain = new FormMain();
            formmain.ShowDialog();//将窗体显示为模式对话框
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(FullPath))
            {
                //这里我是准备加时间的。
                string CurrentTime = DateTime.Now.ToString();
                string[] InitialStr = { "文件创建时间",CurrentTime,"============================"};
                Console.WriteLine(CurrentTime);
                System.IO.File.WriteAllLines(FullPath, InitialStr);
                button5.Enabled = true;
                button6.Enabled = true;
                //Create也是静态方法而不是实例方法,单纯创建一个文档而不是进行写作
                //FileStream fs = File.Create(FullPath);
                //fs.Close();

                //1.
                //WriteAllLine是一个静态方法而不是实例方法。
                //string[] lines = { "First line", "Second line", "Third line" };
                //System.IO.File.WriteAllLines(FullPath, lines);

                //2.
                //string text = "A class is the most powerful data type in C#. Like a structure, " +
                //       "a class defines the data and behavior of the data type. ";
                //System.IO.File.WriteAllText(FullPath, text);

                //3.
                //对已有的文件进行改写的操作
                //string[] lines = { "First line", "Second line", "Third line" };
                //using (System.IO.StreamWriter file =new System.IO.StreamWriter(FullPath))
                //{
                //    foreach (string line in lines)
                //    {
                //        // If the line doesn't contain the word 'Second', write the line to the file.
                //        if (!line.Contains("Second"))
                //        {
                //            file.WriteLine(line);
                //        }
                //    }
                //}

                //using (System.IO.StreamWriter file =new System.IO.StreamWriter(FullPath, true))
                //     {
                //         file.WriteLine("Fourth line");
                //     }
                // }
                MessageBox.Show("txt文件创建完成！");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String pathTemp = textBox3.Text;
            //如果这个路径已经存在就直接提交，不用出现这个东西了。
            if (System.IO.Directory.Exists(pathTemp))
            {
                FileName = textBox2.Text;
                FolderPath = pathTemp;
                FullPath = FolderPath + '\\' + FileName;
                textBox4.Text = FullPath;
            }
            else
            {
                FolderBrowserDialog dilog = new FolderBrowserDialog();
                dilog.Description = "请选择文件夹";
                if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
                {
                    FolderPath = dilog.SelectedPath;
                    textBox3.Text = FolderPath;
                    //输出文件的全路径
                    FullPath = FolderPath + '\\' + FileName;
                    textBox4.Text = FullPath;
                }
            }
            if (System.IO.File.Exists(FullPath) == false)
            {
                button2.Enabled = true;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string FileTemp = "";
            //判断textbox是不是为空
            if (textBox2.Text.Trim() == "")
            {
                //生成随机数，用于文件命名。
                Random ran = new Random();
                int n = ran.Next(10000);
                FileTemp = "myFile_" + n.ToString() + ".txt";
            }
            textBox2.Text = FileTemp;
            FileName = textBox2.Text;
            button1.Enabled = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            numericUpDown1.Text = "";
            textBox9.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            button6.Enabled = true;
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (FileOperation.GetFileSize(FullPath) == 0)
            {  
                string[] strArray = GetData();
                File.WriteAllLines(FullPath, strArray);
            }
            //如果里面已经有了记录
            else
            {
                string[] strArray = GetData();
                //下面就是一种插入数据的方式
                File.AppendAllLines(FullPath,strArray);

            }
            button5.Enabled = true;
            button6.Enabled = false;
            MessageBox.Show("上传成功！");
        }
        //未来要将下面的进行封装，放到专门的一个函数类里面。

        //由于函数内部的特殊性，难以封装。
        public string[] GetData()
        {
            //存在一个问题就是，如何在另外一个类中引用winform的控件
            string InsertTime = DateTime.Now.ToString();
            string str0 = "------------------------------------------------------------";
            string str1 = "SerialNumber:" + textBox1.Text + ",";
            string str2 = "Price:" + numericUpDown1.Value.ToString() + ",";
            string str3 = "Builder:" + textBox9.Text + ",";
            string str4 = "Model:" + textBox6.Text + ",";
            string str5 = "Type:" + textBox5.Text + ",";
            string str6 = "BackWood:" + textBox7.Text + ",";
            string str7 = "TopWood:" + textBox8.Text + ",";

            string[] strArray = { InsertTime, str0, str1, str2, str3, str4, str5, str6, str7, str0 };
            return strArray;
        }
    }
}




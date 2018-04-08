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
using System.Diagnostics;//与系统进程、事件日志和性能计数器进行交互
using System.Text.RegularExpressions;

namespace CS_第二周作业_201511190114_任春哲
{
    public struct DataStruct
    {
        public string   SerialNumber;
        public long     Price;
        public string  Builder;
        public string   Model;
        public string   Type;
        public string   BackWood;
        public string   TopWood;
    };
    public delegate bool isTxtDelegate(string fileName);
    public partial class Form2 : Form
    {
        public string FullPath { get; set; }
        public int MatchTime { get; set; }
        public Form2()
        {
            InitializeComponent();
            textBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button2.Enabled = false;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择要打开的txt文件";
            ofd.Filter = "AllFiles(*.*)|*.*|TXT(*.*)|*.txt";
            ofd.ShowDialog();//显示选取图像路径的窗口
            textBox1.Visible = true;
            textBox1.Text = ofd.FileName;
            //ImgPath = ofd.FileName;
            if (!(File.Exists(ofd.FileName)))
            {
                MessageBox.Show("没有选取文件", "提示");
                return;
            }
            //判断是不是txt
            string fileName = ofd.FileName;
            FileOperation judgeSample = new FileOperation(fileName);
            isTxtDelegate isTxtSample = new isTxtDelegate(judgeSample.isTXT);
            if (isTxtSample(fileName))
            {
                label2.Visible = true;
                button2.Enabled = true;
            }
            else
            {
                label3.Visible = true;
            }
            FullPath = textBox1.Text;

            long SizeOfFile = FileOperation.GetFileSize(FullPath);
            if (SizeOfFile > 650)
            {
                MessageBox.Show("本程序目前不支持处理多条记录的文件，多条记录更新无效。");
                button2.Enabled = false;
            }
            else
            {
                Regex regex1 = new Regex(@"SerialNumber:(\w*)");
                Regex regex2 = new Regex(@"Price:(\d*),");
                Regex regex3 = new Regex(@"Builder:(\w*)");
                Regex regex4 = new Regex(@"Model:(\w*)");
                Regex regex5 = new Regex(@"Type:(\w*)");
                Regex regex6 = new Regex(@"BackWood:(\w*)");
                Regex regex7 = new Regex(@"TopWood:(\w*)");

                //1  读取数据
                //string text = System.IO.File.ReadAllText(FullPath);
                //Console.WriteLine(text);
                //2  按行读取，按行输出

                DataStruct DS1 = new DataStruct();
                string[] lines = System.IO.File.ReadAllLines(FullPath);
                foreach (string line in lines)
                {
                    string contend = "";
                    //这里就是非常适合委托和lambda了。装一波逼。
                    if (regex1.IsMatch(line))
                    {
                        contend = regex1.Match(line).Groups[1].Value;
                        DS1.SerialNumber = contend;
                        Console.WriteLine(contend);
                        textBox2.Text = contend;
                    }
                    else if (regex2.IsMatch(line))
                    {
                        contend = regex2.Match(line).Groups[1].Value;
                        long mylong = long.Parse(contend);
                        DS1.Price = mylong;
                        Console.WriteLine(contend);
                        numericUpDown1.Value = mylong;
                    }
                    else if (regex3.IsMatch(line))
                    {
                        contend = regex3.Match(line).Groups[1].Value;
                        DS1.Builder = contend;
                        Console.WriteLine(contend);
                        textBox7.Text = contend;
                    }
                    else if (regex4.IsMatch(line))
                    {
                        contend = regex4.Match(line).Groups[1].Value;
                        DS1.Model = contend;
                        Console.WriteLine(contend);
                        textBox4.Text = contend;
                    }
                    else if (regex5.IsMatch(line))
                    {
                        contend = regex5.Match(line).Groups[1].Value;
                        Console.WriteLine(contend);
                        DS1.Type = contend;
                        textBox6.Text = contend;
                    }
                    else if (regex6.IsMatch(line))
                    {
                        contend = regex6.Match(line).Groups[1].Value;
                        DS1.BackWood = contend;
                        Console.WriteLine(contend);
                        textBox3.Text = contend;
                    }
                    else if (regex7.IsMatch(line))
                    {
                        contend = regex7.Match(line).Groups[1].Value;
                        DS1.TopWood = contend;
                        Console.WriteLine(contend);
                        textBox5.Text = contend;
                    }
                    button2.Enabled = true;
                }
                //3  按行读取，按行输出
                //using (System.IO.StreamReader sr = new System.IO.StreamReader(FullPath))
                //{
                //    string str;
                //    while ((str = sr.ReadLine()) != null)
                //    {
                //        Console.WriteLine(str);
                //    }
                //}
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            FormMain formmain = new FormMain();
            formmain.ShowDialog();//将窗体显示为模式对话框
            this.Close();
        }

        private void Form2_Shown(object sender, EventArgs e)
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


        public string[] GetData()
        {
            //存在一个问题就是，如何在另外一个类中引用winform的控件
            string InsertTime = DateTime.Now.ToString();
            string str0 = "------------------------------------------------------------";
            string str1 = "SerialNumber:" + textBox2.Text + ",";
            string str2 = "Price:" + numericUpDown1.Value.ToString() + ",";
            string str3 = "Builder:" + textBox7.Text + ",";
            string str4 = "Model:" + textBox4.Text + ",";
            string str5 = "Type:" + textBox6.Text + ",";
            string str6 = "BackWood:" + textBox3.Text + ",";
            string str7 = "TopWood:" + textBox5.Text + ",";
            string[] strArray = { InsertTime, str0, str1, str2, str3, str4, str5, str6, str7, str0 };
            return strArray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] DataToUpdate= GetData();
            File.AppendAllLines(FullPath,DataToUpdate);
            button2.Enabled = false;
            MessageBox.Show("更新完成！");
        }
    }
    public partial class FileOperation
    {
       //WriteSomething
    }
}

//目前的功能仅仅能实现对单组记录的操作，如何实现对多组记录的操作同样是一个问题。



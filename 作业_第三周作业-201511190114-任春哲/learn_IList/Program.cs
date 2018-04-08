using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace learn_IList
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            BindingFlags bf = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static;
            Type objType = typeof(Guitar);
            PropertyInfo[] propInfoArr = objType.GetProperties(bf);
            string header = string.Empty;
            List<string> listPropertys = new List<string>();

            foreach (PropertyInfo info in propInfoArr)
            {
                header += info.Name + ',';
                listPropertys.Add(info.Name);
            }
            sb.AppendLine(header.Trim(',')); //csv头
            //trim，从string数组中去除匹配字符的前导匹配和尾部匹配

            //这些东西都是要传进去的
            List<Guitar> listGuitars = new List<Guitar>();
            Guitar g1 = new Guitar("900001", "12.02", "aaa", "bbb", "ccc", "ddd", "eee");
            Guitar g2 = new Guitar("900002", "12.03", "aab", "bbc", "ccd", "dde", "eea");
            listGuitars.Add(g1);
            listGuitars.Add(g2);


            foreach (Guitar gx in listGuitars)
            {
                string strModel = string.Empty;
                foreach (string strProp in listPropertys)
                {
                    strModel += gx.SerialNumber + ",";
                    strModel += gx.Price + ",";
                    strModel += gx.Builder + ",";
                    strModel += gx.Model + ",";
                    strModel += gx.Type + ",";
                    strModel += gx.BackWood + ",";
                    strModel += gx.TopWood + ",";
                }
                strModel = strModel.Substring(0, strModel.Length - 1);
                sb.AppendLine(strModel);
            }



            //string m_Path = "C:\Users\Ren\Documents\Visual Studio 2015\Projects\第三周作业 - 201511190114 - 任春哲";
            //if (File.Exists(m_Path)) File.Delete(m_Path);
            //using (FileStream fs = new FileStream(m_Path, FileMode.CreateNew, FileAccess.Write))
            //{
            //    StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            //    sw.Flush();
            //    sw.Write(content);
            //    sw.Flush();
            //    sw.Close();
            //}
            Console.ReadLine();

        }
    }

    // 需要改进的地方包括，泛型，以及如何实现输出到项目所在的相对文件夹路径
    public class CsvHelper 
    {
        public static void SaveAsCSV(List<Guitar> listGuitar) 
            //where T : class, new()非泛型不允许使用类
        {
            StringBuilder sb = new StringBuilder();
            BindingFlags bf = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static;
            Type objType = typeof(T);
            PropertyInfo[] propInfoArr = objType.GetProperties(bf);
            List<string> listPropertys = new List<string>();
            string header = string.Empty;

            foreach (PropertyInfo info in propInfoArr)
            {
                header += info.Name;
            }
            sb.AppendLine(header.Trim(',')); //csv头
        }
    }
    class Guitar
    {
        //常见的格式包括了CSV逗号分隔的值文件
        //DAT数据文件
        //dBASE格式
        //本脚本准备支持CSV，CSV每行记录占一行，以逗号为分隔符号，逗号前后的分隔符号会被忽略，
        //CSV即Comma Separate Values，这种文件格式经常用来作为不同程序之间的数据交互的格式。 

        private string serialNumber;
        private string price;
        private string builder;
        private string model;
        private string type;
        private string backWood;
        private string topWood;
        //属性中，get是一种读，set是一种写。
        //get访问器用于返回字段或者计算并且返回字段，必须以return或者是throw结尾。
        //set访问器类似于返回类型是void的函数，并且存在value的隐式参数。
        public string SerialNumber
        {
            get
            {
                return serialNumber;
            }
            set
            {
                serialNumber = value;
            }
        }
        public string Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public string Builder
        {
            get
            {
                return builder;
            }
            set
            {
                builder = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public string BackWood
        {
            get
            {
                return backWood;
            }
            set
            {
                backWood = value;
            }
        }
        public string TopWood
        {
            get
            {
                return topWood;
            }
            set
            {
                topWood = value;
            }
        }
        //属性声明部分
        //声明构造器
        public Guitar(string m_serialNumber, string m_price, string m_builder, string m_model, string m_type, string m_backWood, string m_topWood)
        {
            serialNumber = m_serialNumber;
            builder = m_builder;
            price = m_price;
            model = m_model;
            type = m_type;
            backWood = m_backWood;
            topWood = m_topWood;
        }
        //关于C#中的析构函数情况
    }
}

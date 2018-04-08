using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三周作业_201511190114_任春哲
{
    public class Guitar
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
        public string SerialNumber {
            get {
                return serialNumber;
            }
            set
            {
                serialNumber = value;
            }
        }
        public string Price {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public string Builder {
            get
            {
                return builder;
            }
            set
            {
                builder = value;
            }
        }
        public string Model {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string Type {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public string BackWood {
            get
            {
                return backWood;
            }
            set
            {
                backWood = value;
            }
        }
        public string TopWood {
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
        public Guitar(string m_serialNumber,string m_price,string m_builder,string m_model,string m_type,string m_backWood,string m_topWood){
            serialNumber = m_serialNumber;
            builder = m_builder;
            price = m_price;
            model = m_model;
            type = m_type;
            backWood = m_backWood;
            topWood = m_topWood;
        }

        public Guitar()
        {
        }
        //关于C#中的析构函数情况
    }
}

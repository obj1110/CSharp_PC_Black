using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVhelper
{
    class Program
    {
        static void Main(string[] args)
        {

            ///
            /// 这个人是用的datatable ，似乎datatable控件在C#中很重要啊。
            ///

            using (FileStream filestream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                StringBuilder sb = new StringBuilder();
                using (StreamWriter sw = new StreamWriter(filestream, Encoding.Default))
                {
                    这里循环你的datatable
                    foreach (DataRow row in dt.Rows)
                    {
                        sb.Append("");
                    }
                    sw.Write(sb.ToString());
                    sw.Close();
                }
            }
        }
    }
}

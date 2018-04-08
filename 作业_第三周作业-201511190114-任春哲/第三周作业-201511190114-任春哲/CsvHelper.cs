using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace 第三周作业_201511190114_任春哲
{
    public static class CsvHelper
    {

        public static bool SaveAsCSV<T>(string m_Path, IList<T> listGuitar) where T : class, new()
        {
            bool statue = false;
            try
            {
                StringBuilder sb = new StringBuilder();
                BindingFlags bf = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static;
                Type objType = typeof(T);
                //为了获取属性
                PropertyInfo[] propInfoArr = objType.GetProperties(bf);
                string header = string.Empty;
                List<string> listPropertys = new List<string>();

                //propertyArray 数据文件的第一行
                foreach (PropertyInfo info in propInfoArr)
                {
                    if (string.Compare(info.Name.ToUpper(), "SerialNumber") != 0) //不考虑自增长的id或者自动生成的guid等
                    {
                        if (!listPropertys.Contains(info.Name))
                        {
                            listPropertys.Add(info.Name);
                        }
                        header += info.Name + ",";
                    }
                }
                sb.AppendLine(header.Trim(',')); //csv头

                foreach (T model in listGuitar)
                {
                    string strModel = string.Empty;
                    foreach (string strProp in listPropertys)
                    {
                        foreach (PropertyInfo propInfo in propInfoArr)
                        {
                            if (string.Compare(propInfo.Name.ToUpper(), strProp.ToUpper()) == 0)
                            {
                                PropertyInfo modelProperty = model.GetType().GetProperty(propInfo.Name);
                                if (modelProperty != null)
                                {
                                    object objResult = modelProperty.GetValue(model, null);
                                    string result = ((objResult == null) ? string.Empty : objResult).ToString().Trim();
                                    if (result.IndexOf(',') != -1)
                                    {
                                        result = "\"" + result.Replace("\"", "\"\"") + "\""; //特殊字符处理 ？
                                        //result = result.Replace("\"", "“").Replace(',', '，') + "\"";
                                    }
                                    if (!string.IsNullOrEmpty(result))
                                    {
                                        Type valueType = modelProperty.PropertyType;
                                        if (valueType.Equals(typeof(Nullable<decimal>)))
                                        {
                                            result = decimal.Parse(result).ToString("#.#");
                                        }
                                        else if (valueType.Equals(typeof(decimal)))
                                        {
                                            result = decimal.Parse(result).ToString("#.#");
                                        }
                                        else if (valueType.Equals(typeof(Nullable<double>)))
                                        {
                                            result = double.Parse(result).ToString("#.#");
                                        }
                                        else if (valueType.Equals(typeof(double)))
                                        {
                                            result = double.Parse(result).ToString("#.#");
                                        }
                                        else if (valueType.Equals(typeof(Nullable<float>)))
                                        {
                                            result = float.Parse(result).ToString("#.#");
                                        }
                                        else if (valueType.Equals(typeof(float)))
                                        {
                                            result = float.Parse(result).ToString("#.#");
                                        }
                                    }
                                    strModel += result + ",";
                                }
                                else
                                {
                                    strModel += ",";
                                }
                                break;
                            }
                        }
                    }
                    strModel = strModel.Substring(0, strModel.Length - 1);
                    sb.AppendLine(strModel);
                }
                //进行文件的交互
                string content = sb.ToString();

                //m_Path必须要求是全路径
                if (File.Exists(m_Path)) File.Delete(m_Path);
                //如果存在就删除
                using (FileStream fs = new FileStream(m_Path, FileMode.CreateNew, FileAccess.Write))
                {
                    StreamWriter sw = new StreamWriter(fs,Encoding.Default);
                    sw.Flush();
                    sw.Write(content);
                    sw.Flush();
                    sw.Close();
                }
                    statue = true;
            }
            catch
            {
                statue = false;
            }
            return false;
        }

        public static bool SaveAsCSV(string m_Path, List<Guitar>listGuitars)
        {
            bool statue=false;
            try
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

                string strModel = string.Empty;
                foreach (Guitar gx in listGuitars)
                {
                    strModel = string.Empty;
                    strModel += gx.SerialNumber + ",";
                    strModel += gx.Price + ",";
                    strModel += gx.Builder + ",";
                    strModel += gx.Model + ",";
                    strModel += gx.Type + ",";
                    strModel += gx.BackWood + ",";
                    strModel += gx.TopWood + ",";
                    strModel = strModel.Substring(0, strModel.Length - 1);
                    Console.WriteLine(strModel);
                    sb.AppendLine(strModel);
                }

                if (File.Exists(m_Path)) File.Delete(m_Path);
                using (FileStream fs = new FileStream(m_Path, FileMode.CreateNew, FileAccess.Write))
                {
                    StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                    sw.Flush();
                    sw.Write(sb.ToString());
                    sw.Flush();
                    sw.Close();
                }

                statue = true;
                return statue;
            }
            catch
            {
                return statue;
            }
            
        }

        //https://blog.csdn.net/wmqdn/article/details/8471385
        //https://blog.csdn.net/plutus_sutulp/article/details/8178764
        //强行重载
        public static DataTable ReadCSV(string m_Path,int number)
        {
            int intColCount = 0;
            bool blnFlag = true;
            DataTable mydt = new DataTable("myTableName");

            DataColumn mydc;
            DataRow mydr;

            string strline;
            string[] aryline;

            System.IO.StreamReader mysr = new System.IO.StreamReader(m_Path);

            while ((strline = mysr.ReadLine()) != null)
            {
                aryline = strline.Split(',');

                if (blnFlag)
                {
                    blnFlag = false;
                    intColCount = aryline.Length;
                    for (int i = 0; i < aryline.Length; i++)
                    {
                        mydc = new DataColumn(aryline[i]);
                        mydt.Columns.Add(mydc);
                    }
                }

                mydr = mydt.NewRow();
                for (int i = 0; i < intColCount; i++)
                {
                    mydr[i] = aryline[i];
                }
                mydt.Rows.Add(mydr);
            }

            return mydt;
    }

        //https://blog.csdn.net/duyusean/article/details/73381502
        public static List<Guitar>ReadCSV(string m_Path)
        {
            Form_Main fm= new Form_Main();
            List<Guitar> readGuitar = new List<Guitar>();
            string line = string.Empty;
            fm.openFileDialog1.ShowDialog();
            using (StreamReader sr = new StreamReader(fm.openFileDialog1.FileName))
            {
                fm.label_ReadCSV.Text = fm.openFileDialog1.FileName.ToString();
                string wasteLine = sr.ReadLine();
                Console.WriteLine(wasteLine);
                while ((line = sr.ReadLine()) != null)
                {
                    string[] sArray = line.Split(',');// 一定是单引
                    int length = sArray.Length;
                    Guitar gx = new Guitar(sArray[0], sArray[1], sArray[2], sArray[3], sArray[4], sArray[5], sArray[6]);
                    readGuitar.Add(gx);
                }
                sr.Close();
                Console.WriteLine("已成功读取文件");
            }
            return readGuitar;
        }
        //你现在要明确一个问题就是，你如何实现选择这个东西，是在控件中选择，还是说手动的选择？
        //初步思路是：读取数据到datatable里面
        //然后在stock类里面对于每一个数据进行筛选
        //但是我觉得，用list<Guitar>也同样是一种思路，用list<Guitar>存储数据，然后进行读取。
    }
}


//CSV格式 
//字段中含有的逗号\换行符，本字段必须用双引号来括起来
//字段前后有空格，本字段必须用双引号括起来
//字段中的双引号用两个双引号表示
//字段中如果有双引号，该字段必须用双引号括起来
//第一条可以是字段名
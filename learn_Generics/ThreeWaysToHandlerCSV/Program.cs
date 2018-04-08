using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeWaysToHandlerCSV
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class operateCSV
    {
        /// <summary>
        /// 读取CSV文件通过文本格式
        /// </summary>
        /// <param name="strpath"></param>
        /// <returns></returns>
        public DataTable readCsvTxt(string strpath)
        {
            int intColCount = 0;
            bool blnFlag = true;
            DataTable mydt = new DataTable("myTableName");

            DataColumn mydc;
            DataRow mydr;

            string strline;
            string[] aryline;

            System.IO.StreamReader mysr = new System.IO.StreamReader(strpath);

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

        /// <summary>
        /// 利用SQL查询CSV
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public DataTable readCsvSql(string path, string filename, string deviceName)
        {
            string strconn = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=Text;", path);
            string sql = string.Format("SELECT * FROM [{0}]", filename);
            using (OleDbConnection conn = new OleDbConnection(strconn))
            {
                DataTable dtTable = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
                try
                {
                    adapter.Fill(dtTable);
                    logHelper.WriteLog(string.Format("[设备]:{0}-->读取文件-->结果:成功", deviceName));
                }
                catch (Exception ex)
                {
                    dtTable = new DataTable();
                    logHelper.WriteLog(string.Format("[设备]:{0}-->读取文件-->结果:{1}", deviceName, ex.Message));
                    throw ex;
                }
                return dtTable;
            }

        }

        /// <summary>
        /// 读取CSV文件
        /// </summary>
        /// <param name="mycsvdt"></param>
        /// <param name="filepath"></param>
        /// <returns></returns>
        
        //ref 使用引用传递参数
        public bool readCsvFile(ref DataTable mycsvdt, string filepath)
        {
            string strpath = filepath; //csv文件的路径
            try
            {
                int intColCount = 0;
                bool blnFlag = true;

                DataColumn mydc;
                DataRow mydr;

                string strline;
                string[] aryline;
                StreamReader mysr = new StreamReader(strpath, System.Text.Encoding.Default);

                while ((strline = mysr.ReadLine()) != null)
                {
                    aryline = strline.Split(new char[] { ',' });

                    //给datatable加上列名
                    if (blnFlag)
                    {
                        blnFlag = false;
                        intColCount = aryline.Length;
                        int col = 0;
                        for (int i = 0; i < aryline.Length; i++)
                        {
                            col = i + 1;
                            mydc = new DataColumn(col.ToString());
                            mycsvdt.Columns.Add(mydc);
                        }
                    }

                    //填充数据并加入到datatable中
                    mydr = mycsvdt.NewRow();
                    for (int i = 0; i < intColCount; i++)
                    {
                        mydr[i] = aryline[i];
                    }
                    mycsvdt.Rows.Add(mydr);
                }
                return true;

            }
            catch (Exception e)
            {
                //throw (Stack.GetErrorStack(strpath + "读取CSV文件中的数据出错." + e.Message, "OpenCSVFile("));
                return false;
            }
        }
    }
}

}

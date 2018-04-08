using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace 第三周作业_201511190114_任春哲
{
    //这个里面主要是与控件的交互操作。
    
    public partial class Form_Main : Form
    {
        public static Form_Main form_main_csvHelper;
        static string FolderPath;
        static string FileName;
        string FullPath;
        public List<Guitar> listGuitars = new List<Guitar>();
        public List<Guitar> readGuitar = new List<Guitar>();
        public Form_Main()
        {
            InitializeComponent();
            CreateFileName();
            textBox_Path.Text = FileName;
            button_SaveAsCSV.Enabled = false;
            //随机一个CVS文件名 
            Guitar g1 = new Guitar("900001","12.02","aaa","bbb","ccc","ddd","eee");
            textBox_Builder.Text = g1.Builder;
            textBox_BackWood.Text = g1.BackWood;
            textBox_Model.Text = g1.Model;
            textBox_TopWood.Text = g1.TopWood;
            textBox_Price.Text = g1.Price;
            textBox_SerialNumber.Text = g1.SerialNumber;
            textBox_Type.Text = g1.Type;

            button_FindPrice.Enabled = false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“database1DataSet.Table”中。您可以根据需要移动或删除它。
            //this.tableTableAdapter.Fill(this.database1DataSet.Table);
            //这个东西突然让我有了启发！！！！是不是可以用这种方式进行数据库的增加与删减。
        }

        private void button_ChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择文件夹";
            if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
            {
                FolderPath = dilog.SelectedPath;
            }
            CreateFileName();
            FullPath = FolderPath +'\\'+ FileName;
            textBox_Path.Text = FullPath;
            button_SaveAsCSV.Enabled = true;
        }
        public static void CreateFileName()
        {
            DateTime DT = new DateTime();
            DT = System.DateTime.Now;
            string year = DT.Year.ToString();
            string month = DT.Month.ToString();
            string day = DT.Day.ToString();
            string hour = DT.Hour.ToString();
            string minute = DT.Minute.ToString();
            FileName = "Guitar_" + year + "_" + month + "_" + day + "_" + hour + "_" + minute + ".csv";
        }

        private void button_UpLoad_Click(object sender, EventArgs e)
        {
            Guitar rand_guitar = new Guitar(textBox_SerialNumber.Text.ToString(), textBox_Price.Text.ToString(), textBox_Builder.Text.ToString(), textBox_Model.Text.ToString(), textBox_Type.Text.ToString(), textBox_BackWood.Text.ToString(), textBox_TopWood.Text.ToString());
              listGuitars.Add(rand_guitar);
            //使用bindingSource添加数据
            //https://blog.csdn.net/magieclarence/article/details/41863511
            //BindingSource _bs1 = new BindingSource();
            //_bs1.AddingNew += new AddingNewEventHandler(_bs1_AddingNew);
        }

        private void button_SaveAsCSV_Click(object sender, EventArgs e)
        {
            //从控件中读取这个数据
            bool result = CsvHelper.SaveAsCSV(FullPath, listGuitars);
        }

        private void button_Add_SQLSERVER_Click(object sender, EventArgs e)
        {
            try
            {
                //string connectString= @"server = (LocalDB);database = Database1;integrated security=SSPI";
                //string connectString= @"server = (LocalDB);database = Database1;integrated security=True";
                string connectString = @"Data Source=localhost;Initial Catalog=Database1;Integrated Security=SSPI";
                string sqlString = @"INSERT INTO [dbo].[Table] (SerialNumber,Price,Builder,Model,Type,BackWood,TopWood) VALUES (" + textBox_SerialNumber.Text + "," + textBox_Price.Text + "," + textBox_Builder + "," + textBox_Model + "," + textBox_Type + "," + textBox_BackWood + "," + textBox_TopWood + ");";

                SqlConnection conn = new SqlConnection(connectString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(string.Format(sqlString), conn);
                //cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                throw;
            }

            //System.Data.SqlClient.SqlConnection sqlConnection1 =new System.Data.SqlClient.SqlConnection("YOUR CONNECTION STRING");

            //SqlConnection con = new SqlConnection();

            //SqlCommand com = new SqlCommand(sqlString, con);
        }

      
        public void _bs1_AddingNew(object sender, AddingNewEventArgs e)
        {
            BindingSource bs = (BindingSource)sender;
            DataView view = (DataView)bs.List;
            DataRowView newRow = view.AddNew();
            newRow["SerialNumber"] = textBox_SerialNumber.Text;
            newRow["Price"] = textBox_Price.Text;
            newRow["Builder"] = textBox_Builder.Text;
            newRow["Model"] = textBox_Model.Text;
            newRow["Type"] = textBox_Type.Text;
            newRow["BackWood"] = textBox_BackWood.Text;
            newRow["TopWood"] = textBox_TopWood.Text;
            e.NewObject = newRow;
        }

        private void button_OpenCSV_Click(object sender, EventArgs e)
        {
            readGuitar = CsvHelper.ReadCSV(FullPath);
            button_FindPrice.Enabled = true;
        }

        private void button_FindPrice_Click(object sender, EventArgs e)
        {
            int positionMax= StockGuitar.FindPrice(readGuitar);
            Guitar gx = readGuitar.ElementAt(positionMax);
            string output = "吉他:\n---------------------\n"+"序列号："+gx.SerialNumber + ",\n价格:" + gx.Price + ",\n制作人：" + gx.Builder + ",\n模型：" + gx.Model +",\n型号：" + gx.Type +",\n前木：" + gx.BackWood + ",\n后木" + gx.TopWood+"\n-----------------------\n是最高价格的吉他。";
            Console.WriteLine(output);
            MessageBox.Show(output);
        }
    }
}
//这种方式，太过于费时费事。
//数据结构的作用巨大，类的设计，对于后续的操作至关重要。

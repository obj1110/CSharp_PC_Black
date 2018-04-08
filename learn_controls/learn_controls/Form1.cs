using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learn_controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //不知道在Form创建的时候就增加DT是不是合适。
        //然后，如何在其他的数据表中使用这个DT 实例？
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("CartForStudents");
            DataColumn dc1 = new DataColumn("SerialNumber", Type.GetType("System.Int64"));
            DataColumn dc2 = new DataColumn("Price", Type.GetType("System.Int16"));
            DataColumn dc3 = new DataColumn("Builder", Type.GetType("System.String"));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            //填充10个记录进去。
            for (int i = 0; i < 10; i++)
            {
                DataRow dr = dt.NewRow();
                dr["SerialNumber"] = "900001";
                dr["Price"] = 12.01;
                dr["Builder"] = "aaa";
                dt.Rows.Add(dr);
                //注意，数据实例必须是一行一行的进行创建，然后一行一行的进行插入，然后注意，数据表的声明以及使用都是要同时声明类型的。
            }
            DataSet customers = new DataSet("CustomersDataSet");
            DataTable workTable = new DataTable();
            DataTable customersTable = customers.Tables.Add("CustomersTable");

            //首先声明数据表的存在，然后用添加列的方式给数据表增加列架构
            //数据增加的方式也是按照创建Row对象进行不断的增加的。
            //也就是我创建一个Row对象，然后进行insert。
            //这样是不行的，因为一个DataRow必定是属于一个DataTable的，不能凭空建立，就好比一条记录一定是属于一个表一样 
            //注意DataRow自己本身是DataTable的一个派生对象，必须是用DataTable

            DataTable DT1 = new DataTable("FirstTable");
            DataColumn DM1 = new DataColumn("ID",Type.GetType("System.String"));
            DM1.AllowDBNull = false;
            DM1.Unique = true;
            DT1.Columns.Add(DM1);

            DataColumn DM2 = new DataColumn("ID2", typeof(String));
            //两种设置类型的方式
            DT1.Columns.Add("Name",typeof(String));
            DT1.Columns.Add("Gender",typeof(bool));
            //创建表达式列
            DT1.Columns.Add("Chinese",typeof(Int16));
            DT1.Columns.Add("Math",typeof(Int16)) ;
            DT1.Columns.Add("English", typeof(Int16));
            //创建表达式类
            DT1.Columns.Add("Total",typeof(Int16),"Chinese + Math + English ");
            //创建AutoIncrement类,这种情况必须创建实例而不是单纯直接增加
            DataColumn DM3 = DT1.Columns.Add("GPA",typeof(double));
            DataColumn DM4 = DT1.Columns.Add("ID3",Type.GetType("System.Int16"));
            //重温两种类型的声明方式
            DM4.AutoIncrement = true;
            DM4.AutoIncrementSeed = 1;
            DM4.AutoIncrementStep = 1;
            //设定自动增张的步长
            //为数据表定义主键
            DT1.PrimaryKey = new DataColumn[] { DT1.Columns["PrimaryKey"] };


            //主键是很多的列的集合的主键，必须是声明一个列的集合才能声明主键。
            DataColumn[] columnList = new DataColumn[1];
            //上面的columnlist应该是属于那种声明为只有一列的情况。
            columnList[0] = DT1.Columns["AnotherPrimaryKey"];
            DT1.PrimaryKey = columnList;

            //增加数据 
            DataRow DR1 = DT1.NewRow();
            DR1["PrimaryKey"] = 1;
            DR1["Chinese"] = 99;
            DR1["Math"] = 90;
            DR1["English"] = 90;
            DR1[2] = "Justin";
            DR1[3] = "Ay";
            //可以通过数组赋值的方式或者是数据下标操作的方式来给数据行DR进行赋值操作。
            //将创建的数据Row添加到数据表中。
            DT1.Rows.Add(DR1);
            //精简代码，在创建的同时就添加数据,使用object大基类直接添加，我的妈呀。
            DT1.Rows.Add(new object[] {1,"Jusitn" });

            //一种快速添加数据的方式，但是我本人很怀疑，因为Row仅仅被创建了一次，剩下的都是反复进行的赋值操作，这样是不是涉及的主要是修改？？？
            //DataRow workRow;

            //for (int i = 0; i <= 9; i++)
            //{
            //    workRow = workTable.NewRow();
            //    workRow[0] = i;
            //    workRow[1] = "CustName" + i.ToString();
            //    workTable.Rows.Add(workRow);
            //}


            //数据表的搜索检索操作
            //我觉得上次的作业用DT其实是更好的结果。
            //可以使用
        }
    }
}


//1.绑定方法,不要直接绑定DataTable，应该绑BindingSource
//BindingSource bs = new BindingSource();
//bs.DataSource = dt;
//grd.DataSource = bs;

//2.删除时从DataRow中取值要下参数
//row["ID", DataRowVersion.Original]

//3.保存之前加两句话
//grd.EndEdit();
//bs.EndEdit();
//===========
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learn_dataTable2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable GuitarList = new DataTable("GuitarList");
            //设置主键____SerialNumber
            //GuitarList.PrimaryKey = new DataColumn[] { GuitarList.Columns["SerialNumber"] };
            //怀疑主键的设置对于下面会有影响。
            DataColumn DM0 = new DataColumn("SerialNumber", typeof(Int64));
            DM0.AutoIncrement = true;
            DM0.AutoIncrementSeed = 1;
            DM0.AutoIncrementStep = 1;

            DataColumn DM1 = new DataColumn("Price",typeof(double));
            DM1.Unique = false;
            DM1.AllowDBNull = false;

            DataColumn DM2 = new DataColumn("Builder",typeof(string));
            DataColumn DM3 = new DataColumn("Model",typeof(string));
            DataColumn DM4 = new DataColumn("Type",typeof(string));
            DataColumn DM5 = new DataColumn("BackWood", typeof(string));
            DataColumn DM6 = new DataColumn("TopWood", typeof(string));
            //我们出错的原因是建立了很多的DM但是却没有和DT相关联。
            GuitarList.Columns.Add(DM0);
            GuitarList.Columns.Add(DM1);
            GuitarList.Columns.Add(DM2);
            GuitarList.Columns.Add(DM3);
            GuitarList.Columns.Add(DM4);
            GuitarList.Columns.Add(DM5);
            GuitarList.Columns.Add(DM6);


            //https://blog.csdn.net/u013084746/article/details/53024266

            DataTable tblDatas = new DataTable("Datas");

            DataColumn dc = null;   
            //似乎这样可以减少赋值？？？
            dc = tblDatas.Columns.Add("ID", Type.GetType("System.Int32"));
            dc.AutoIncrement = true;//自动增加 
            dc.AutoIncrementSeed = 1;//起始为1 
            dc.AutoIncrementStep = 1;//步长为1 
            dc.AllowDBNull = false;

            dc = tblDatas.Columns.Add("Product", Type.GetType("System.String"));
            dc = tblDatas.Columns.Add("Version", Type.GetType("System.String"));
            dc = tblDatas.Columns.Add("Description", Type.GetType("System.String"));


            DataRow newRow;
            newRow = tblDatas.NewRow();
            newRow["Product"] = "这个地方是单元格的值";
            newRow["Version"] = "2.0";
            newRow["Description"] = "这个地方是单元格的值";
            tblDatas.Rows.Add(newRow);
            newRow = tblDatas.NewRow();
            newRow["Product"] = "这个地方是单元格的值";
            newRow["Version"] = "3.0";
            newRow["Description"] = "这个地方是单元格的值";
            tblDatas.Rows.Add(newRow);



            ////添加数据还没有掌握
            DataRow DR1 = GuitarList.NewRow();
            DR1["SerialNumber"] = 1;
            DR1["Price"] = 12.01;
            DR1["Builder"] = "AAA";
            DR1["Model"] = "BBB";
            DR1["Type"] = "CCC";
            DR1["BackWood"] = "DDD";
            DR1["TopWood"] = "EEE";

            //架构完成，开始添加数据
            //莫名的bug，说我的数组太长了，主要原因是你没有把DM和DT相关联起来。
            GuitarList.Rows.Add(new object[] { 90000, 120.2, "aaa", "bbb", "ccc", "ddd", "eee" });

            DataRow workRow;
            for (int i = 0; i < 10; i++)
            {
                workRow = GuitarList.NewRow();
                workRow[0] = 9000 + i + 1;
                workRow[1] = 102.0 + i;
                workRow[2] = "aaa" + i.ToString();
                workRow[3] = "bbb" + i.ToString();
                workRow[4] = "ccc" + i.ToString();
                workRow[5] = "ddd" + i.ToString();
                workRow[6] = "eee" + i.ToString();
            }
            //增加数据的方式二
            DataTable tblDatas1 = new DataTable("Datas");
            tblDatas.Columns.Add("ID", Type.GetType("System.Int32"));
            tblDatas.Columns[0].AutoIncrement = true;
            tblDatas.Columns[0].AutoIncrementSeed = 1;
            tblDatas.Columns[0].AutoIncrementStep = 1;
            tblDatas.Columns.Add("Product", Type.GetType("System.String"));
            tblDatas.Columns.Add("Version", Type.GetType("System.String"));
            tblDatas.Columns.Add("Description", Type.GetType("System.String"));
            tblDatas.Rows.Add(new object[] { null, "a", "b", "c" });
            tblDatas.Rows.Add(new object[] { null, "a", "b", "c" });
            tblDatas.Rows.Add(new object[] { null, "a", "b", "c" });
            tblDatas.Rows.Add(new object[] { null, "a", "b", "c" });
            tblDatas.Rows.Add(new object[] { null, "a", "b", "c" });

            //增加数据的方法三
            DataTable table = new DataTable();
            //创建table的第一列 
            DataColumn priceColumn = new DataColumn();
            priceColumn.DataType = System.Type.GetType("System.Decimal");//该列的数据类型 
            priceColumn.ColumnName = "price";//该列得名称 
            priceColumn.DefaultValue = 50;//该列得默认值 
                                          // 创建table的第二列 
            DataColumn taxColumn = new DataColumn();
            taxColumn.DataType = System.Type.GetType("System.Decimal");
            taxColumn.ColumnName = "tax";//列名 
            taxColumn.Expression = "price * 0.0862";//设置该列得表达式，用于计算列中的值或创建聚合列 
                                                    // 创建table的第三列 
            DataColumn totalColumn = new DataColumn();
            totalColumn.DataType = System.Type.GetType("System.Decimal");
            totalColumn.ColumnName = "total";
            totalColumn.Expression = "price + tax";//该列的表达式，是第一列和第二列值得和 
                                                   // 将所有的列添加到table上 
            table.Columns.Add(priceColumn);
            table.Columns.Add(taxColumn);
            table.Columns.Add(totalColumn);

            //创建一行 
            DataRow row = table.NewRow();
            table.Rows.Add(row);//将此行添加到table中 
                                //将table放在视图中 

            DataView view = new DataView(table);
            //绑定到DataGrid 
            dg.DataSource = view;
            dg.DataBind();
            //然后对于DT来说，列是DT.Columns中的动态数组，可以用DT.Columns[0]等等索引调用方式为这个动态数组添加或者删除列。
            //相同的操作同样发生在Rows上面，同样是一个动态数组的感觉



            //至此数据表基本构建完成，下面主要是进行查询工作。


        }
    }
}

//2018年3月26日21:37:30
//下一步的操作：
//实现对于DT中的数据的访问。
//将DT和控件绑定。

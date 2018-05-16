using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//注意这种引用添加
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Display;

namespace EngineWindowsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Map Documents";
            openFileDialog.Filter = "Map Documents (*.mxd)|*.mxd";
            openFileDialog.ShowDialog();
            string filePath = openFileDialog.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open shapeFile";
            openFileDialog.Filter = "Shapefiles (*.shp)|*.shp";
            openFileDialog.ShowDialog();
            string filePath = openFileDialog.FileName;

            int index = filePath.LastIndexOf ('\\');
            string fileName = filePath.Substring(index+1);
            string path = filePath.Substring(0,index);
            axMapControl1.AddShapeFile(path,fileName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open shapeFile";
            openFileDialog.Filter = "Layer(*.lyr)|*.lyr";
            openFileDialog.ShowDialog();
            string filePath = openFileDialog.FileName;

            int index = filePath.LastIndexOf('\\');
            string fileName = filePath.Substring(index + 1);
            string path = filePath.Substring(0, index);

            axMapControl1.AddLayerFromFile(filePath);
        }

        //增加一个动作，当鼠标按下去的时候，会缩放图层
        private void axMapControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {
            if (e.button == 1)
            {
                //图层缩放的情况，
                //把获取的矩形赋值给Extend
                //axMapControl1.Extent = axMapControl1.TrackRectangle();
                //还有visiableRegion的情况。
                IGeometry Shape = axMapControl1.TrackRectangle();
                ISimpleFillSymbol Symbol = new SimpleFillSymbol();
                RgbColorClass color = new RgbColorClass();
                //如果出现嵌入式的问题，需要在解决方案管理器里面是勾选对应引用的属性，将嵌入式的属性变成false。
                color.Red = 255;
                Symbol.Color = color;
                object obj = Symbol as object;
                axMapControl1.DrawShape(Shape,ref obj);
            }
            //旋转地图，首先要定义一个角度，零度角度默认是指向右边。
            //然后使用Mouse Down Mouse Up Mouse Move

            //refresh的重要性就是，因为图层的变化是需要重绘制的，所以要不断的refresh

            //此外，比较基础和底层的包括map的操作。
            //map.Clear()； map.Control()包含了一个对象在里面。

            //page Layer的作用，主要是用来做图例的。

        }
        //在MapControl上绘制多边形绘制图形

    }
}
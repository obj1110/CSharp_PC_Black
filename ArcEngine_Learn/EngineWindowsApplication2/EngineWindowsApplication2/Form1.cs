using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//ע�������������
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

        //����һ������������갴��ȥ��ʱ�򣬻�����ͼ��
        private void axMapControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {
            if (e.button == 1)
            {
                //ͼ�����ŵ������
                //�ѻ�ȡ�ľ��θ�ֵ��Extend
                //axMapControl1.Extent = axMapControl1.TrackRectangle();
                //����visiableRegion�������
                IGeometry Shape = axMapControl1.TrackRectangle();
                ISimpleFillSymbol Symbol = new SimpleFillSymbol();
                RgbColorClass color = new RgbColorClass();
                //�������Ƕ��ʽ�����⣬��Ҫ�ڽ�����������������ǹ�ѡ��Ӧ���õ����ԣ���Ƕ��ʽ�����Ա��false��
                color.Red = 255;
                Symbol.Color = color;
                object obj = Symbol as object;
                axMapControl1.DrawShape(Shape,ref obj);
            }
            //��ת��ͼ������Ҫ����һ���Ƕȣ���ȽǶ�Ĭ����ָ���ұߡ�
            //Ȼ��ʹ��Mouse Down Mouse Up Mouse Move

            //refresh����Ҫ�Ծ��ǣ���Ϊͼ��ı仯����Ҫ�ػ��Ƶģ�����Ҫ���ϵ�refresh

            //���⣬�Ƚϻ����͵ײ�İ���map�Ĳ�����
            //map.Clear()�� map.Control()������һ�����������档

            //page Layer�����ã���Ҫ��������ͼ���ġ�

        }
        //��MapControl�ϻ��ƶ���λ���ͼ��

    }
}
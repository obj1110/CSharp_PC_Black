using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _201511190114_任春哲_第十周作业_鹰眼缩放
{
    public partial class Form1 : Form
    {
        IMapControlDefault m_mapControl;
        public Form1()
        {
            InitializeComponent();
        }
        ////////////////////////////////////////////////
        private void axMapControl1_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            if (e.button == 2)
            {
                IPoint pPoint = new PointClass();
                pPoint.PutCoords(e.mapX, e.mapY);
                IPoint pCentrePoint = new PointClass();
                pCentrePoint.PutCoords(axMapControl1.Extent.XMin + axMapControl1.ActiveView.Extent.Width / 2,
                    axMapControl1.Extent.YMax - axMapControl1.ActiveView.Extent.Height / 2); //获取图像的中心位置
                axMapControl1.ActiveView.ScreenDisplay.RotateStart(pPoint, pCentrePoint); //开始旋转
            }

            if (e.button == 1)
            {
                ISimpleLineSymbol pLineSym = new SimpleLineSymbol();
                IRgbColor pColor = new RgbColor();
                pColor.Red = 11;
                pColor.Green = 120;
                pColor.Blue = 233;
                pLineSym.Color = pColor;
                pLineSym.Style = esriSimpleLineStyle.esriSLSSolid;
                pLineSym.Width = 2;

                IPolyline pLine = axMapControl1.TrackLine() as IPolyline;

                object symbol = pLineSym as object;
                axMapControl1.DrawShape(pLine, ref symbol);
            }
        }
        //鼠标移动！
        private void axMapControl1_OnMouseMove(object sender, IMapControlEvents2_OnMouseMoveEvent e)
        {
            if (e.button == 2)
            {
                IPoint pPoint = new PointClass();
                pPoint.PutCoords(e.mapX, e.mapY);
                axMapControl1.ActiveView.ScreenDisplay.RotateMoveTo(pPoint);    //旋转到鼠标的位置
                axMapControl1.ActiveView.ScreenDisplay.RotateTimer(); //可以忽略
            }

        }
        //鼠标抬起！
        private void axMapControl1_OnMouseUp(object sender, IMapControlEvents2_OnMouseUpEvent e)
        {
            if (e.button == 2)
            {
                double dRotationAngle = axMapControl1.ActiveView.ScreenDisplay.RotateStop(); //获取旋转的角度
                axMapControl1.Rotation = dRotationAngle; //赋值给 axMapControl1.Rotation，这下真的旋转了！
                axMapControl1.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeography, null, null); //刷新！
            }
         
        }
        /////////////////////////////////////////
        private void axMapControl_sub_OnExtentUpdated(object sender, IMapControlEvents2_OnExtentUpdatedEvent e)
        {
            //实现鹰眼的方框的 symbol 部分
            ILineSymbol outLineSymbol = new SimpleLineSymbol();　　//设置鹰眼图中的红线！
            outLineSymbol.Width = 2;
            outLineSymbol.Color = GetColor(255, 0, 0, 255);

            IFillSymbol fillSymbol = new SimpleFillSymbol();　　//设置填充符号的属性！
            fillSymbol.Color = GetColor(255, 0, 0, 0);  　　//设置完全透明色
            fillSymbol.Outline = outLineSymbol;

            //实现信息传递
            IEnvelope envlope2 = e.newEnvelope as IEnvelope;　
            IElement element2 = new RectangleElement();　
            element2.Geometry = envlope2;

            IFillShapeElement fillShapeElement2 = element2 as IFillShapeElement;　
            fillShapeElement2.Symbol = fillSymbol;　　

            IGraphicsContainer graphicsContainer2 = axMapControl_sub.Map as IGraphicsContainer;　
            graphicsContainer2.DeleteAllElements();          
            IElement  pElement = fillShapeElement2 as IElement;　
            graphicsContainer2.AddElement(pElement, 0);　
            axMapControl_sub.Refresh(esriViewDrawPhase.esriViewGeography, null, null);　　
        }

        private void axMapControl_sub_OnMouseDown(object sender, IMapControlEvents2_OnMouseDownEvent e)
        {
            if (e.button == 2)
            {
                IEnvelope pEnv = axMapControl_sub.TrackRectangle();
                axMapControl1.Extent = pEnv;
            }

        }

        private IRgbColor GetColor(int r, int g, int b, int t)　　//定义获取颜色的函数
        {
            IRgbColor rgbColor = new RgbColor();
            rgbColor.Red = r;
            rgbColor.Green = g;
            rgbColor.Blue = b;
            rgbColor.Transparency = (byte)t;　　//透明度
            return rgbColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Mxd";
            openFileDialog.Filter = "MXD (*.mxd)|*.mxd";
            openFileDialog.ShowDialog();
            string filePath = openFileDialog.FileName;

            if (axMapControl1.CheckMxFile(filePath))
            {
                axMapControl1.MousePointer = esriControlsMousePointer.esriPointerHourglass;
                axMapControl1.LoadMxFile(filePath, Type.Missing, Type.Missing);
                axMapControl1.MousePointer = esriControlsMousePointer.esriPointerDefault;
            }
        }
    }
}
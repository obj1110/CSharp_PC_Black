using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 任春哲_第四次作业_201511190114
{
    class Dog
    {
        public int StartingPosition;
        //pbox开始的位置
        public int RactrackLength;
        //跑道多长
        public PictureBox MyPictureBox = null;

        public int Location = 0;
        //实时的位置
        public static Random Randomitzer=new Random();
        //每一个dog的实例都引用这个randomitzer
        public Dog(int _StartingPosition,int _RactrackLength,PictureBox _pictureBox,int _Location)
        {
            StartingPosition = _StartingPosition;
            RactrackLength = _RactrackLength;
            MyPictureBox = _pictureBox;
            Location = _Location;
        }
        //控制这个pictureBox进行移动，返回一个true如果有人到了终点
        //多线程，防止小几率出现的由于相加顺序对于结果的影响
        public bool Run()
        {
            //没有做好图片窗口的交互，如果做的好，应该是可以在这里面控制的。
            int distance = Randomitzer.Next(1,10);
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;

            Location += distance;
            if (Location > RactrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //相当于重置操作。
        public void TakeStartingPosition()
        {
            Point p = MyPictureBox.Location;
            p.X = StartingPosition;
            MyPictureBox.Location = p;
            Location = StartingPosition;//如果不对于总里程处理，最后会比较麻烦。
        }
    }
}
//只要确保这个狗类的picbox是一个form1中的pbox对象的引用就行了。
//判断狗有没有到终点的方式？是获取pictureBox的右下角的坐标情况。

    //可以用多线程来实现同步的实现
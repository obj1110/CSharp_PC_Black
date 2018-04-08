using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 任春哲_第四次作业_201511190114
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
//下注系统
//比赛系统
//赛后处理系统


//实际上这个项目的上部分和下部分是相脱节的。也就是说，其实不需要上面的控件，下面也能操作，上面的控件只不过是效果罢了。
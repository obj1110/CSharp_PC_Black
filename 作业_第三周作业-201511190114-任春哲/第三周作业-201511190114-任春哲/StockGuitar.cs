using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace 第三周作业_201511190114_任春哲
{


    public class StockGuitar
    {
        //1.可以往库存里面添加吉他
        //2.按照一定条件来查找吉他

        //个人觉得，主要的文件读写操作都在里面
        //主要需要调用的就是IO类
        public static int FindPrice(List<Guitar> readGuitar)
        {

            double[] priceArray=new double[readGuitar.Count];
            int i = 0;

            for (i=0;i<readGuitar.Count;i++)
            {
                Guitar gx = new Guitar();
                gx = readGuitar.ElementAt(i);
                priceArray.SetValue(System.Convert.ToDouble(gx.Price), i);
            }

            int positionMax = 0;
            double priceMax = priceArray[0];
            int j = 0;
            while(j != readGuitar.Count)
            {
                if(priceArray[j] > priceMax)
                {
                    positionMax = j;
                    priceMax = priceArray[j];
                }
                j++;
            }
            return positionMax;
        }
    }
}

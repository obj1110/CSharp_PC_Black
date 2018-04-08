using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS_第二周作业_201511190114_任春哲
{
    public partial class FileOperation
    {
        public string fileName { get; set; }
        public FileOperation(string fileName)
        {
            this.fileName = fileName;
        }
        public static  long GetFileSize(string FilePath)
        {
            long m_Size = 0;
            FileInfo fi = new FileInfo(FilePath);
            try
            {
                m_Size = fi.Length;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                m_Size = 0;
            }
            return m_Size;
        }

        public bool isTXT(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            bool isTextFile = true;
            try
            {
                int i = 0;
                int length = (int)fs.Length;
                byte data;
                while (i < length && isTextFile)
                {
                    data = (byte)fs.ReadByte();
                    isTextFile = (data != 0);
                    i++;
                }
                return isTextFile;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}

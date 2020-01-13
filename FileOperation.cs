using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace csharp
{
    class FileOperation
    {
        private static string fileName = "TestFile.txt";
        /// <summary>
        /// 文件操作
        /// </summary>
        public static void test()
        {
            writeToFile("写入文件！");
            Console.WriteLine("文件数据：{0}", readFromFile()); 
        }


        /// <summary>
        /// 文件写入
        /// </summary>
        /// <param name="data">写入文件的数据</param>
        public static void writeToFile(string data)
        {
            FileStream fs = null;

            try
            {
                fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);

                byte[] arr = System.Text.Encoding.Default.GetBytes(data);

                foreach (byte b in arr)
                {
                    fs.WriteByte(b);
                }

                fs.Close();
                Console.WriteLine("写入成功！");
            }
            catch (Exception e)
            {
                if (fs != null)
                {
                    fs.Close();
                }
                Console.WriteLine(e);
            }

        }


        /// <summary>
        /// 从文件读取数据
        /// </summary>
        /// <returns></returns>
        public static string readFromFile()
        {
            FileStream fs = null;

            try
            {
                fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                
                byte[] arr = new byte[fs.Length];

                int i = 0;
                while (i<fs.Length)
                {
                    arr[i] = (byte)fs.ReadByte();
                    i++;
                }

                string data = System.Text.Encoding.Default.GetString(arr,0,arr.Length);

                fs.Close();
                return data;
            }
            catch (Exception e)
            {
                if (fs != null)
                {
                    fs.Close();
                }
                Console.WriteLine(e);
            }
            return null;
        }


    }
}

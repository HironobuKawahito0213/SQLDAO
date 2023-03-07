using Magnum.FileSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleApp_0302
{
    internal class FileReader
    {
        //手入力
        private readonly string fileName = "C:\\Users\\ia\\Desktop\\Book1.csv";
        
        //列数
        public int length = 11;

        //行数
        public int column = 10;

        public List<List<string>> lines = new List<List<string>>();

        public List<List<string>> fileRead()
        {
            List<string> ls = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (0 <= sr.Peek())
                    {
                        
                        for (int i = 0; i < length ; i++)
                        {
                            //カンマ区切りで分割して配列で格納する
                            var line = sr.ReadLine()?.Split(',');
                            if (line is null) continue;


                            for (int j = 0; j < length; j++)
                            {
                                ls.Add(line[j]);
                            }

                            //リストにデータを追加する
                            lines.Add(ls);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (lines[i][j].Equals(" "))
                    {
                        lines[i][j] = null; ;
                    }
                }
            }
            return lines;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace TestProjectSimbirSoft
{
    class SplitDownload
    {
        public static void GeneralMethod(string link,string path)
        {
            
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(link, path);
            }

            int count = File.ReadLines(@"newHtml.txt").Count();

            StringBuilder writepath = new StringBuilder(@"0a.txt");


            char value = '1';
            char oldValue = '0';
            using (StreamReader str = new StreamReader(@"newHtml.txt"))
            {
                for (int i = 0; i < count; i++)
                {                    
                    using (StreamWriter wr = new StreamWriter(writepath.ToString(), false))
                    {
                        wr.WriteLine(str.ReadLine());
                    }
                    writepath.Replace(oldValue, value);
                    oldValue = value;
                    value++;
                }   
            }
        }
    }
}

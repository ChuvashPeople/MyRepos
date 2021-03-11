using System;
using System.IO;

namespace TestProjectSimbirSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            string link = "https://www.simbirsoft.com/";
            string path = @"D:\html\html.txt";
            

            string inputPath = @"D:\html\input.txt";

            using (StreamWriter strw = new StreamWriter(inputPath, false))
            {
                foreach (var item in Sorting.SortPage(Parsing.ParsePage(DLR.DownloadLoadRead(path, link))))
                {
                    strw.WriteLine(item);
                }
            }
        }
    }
}

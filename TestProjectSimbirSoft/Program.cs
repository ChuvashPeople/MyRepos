using System;

namespace TestProjectSimbirSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            string link = "https://www.simbirsoft.com/";
            string path = @"D:\html\html.txt";
            Sorting.SortPage(Parsing.ParsePage(DLR.DownloadLoadRead(path, link)));
        }
    }
}

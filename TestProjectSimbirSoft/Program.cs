using System;

namespace TestProjectSimbirSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            string link = "https://www.simbirsoft.com/";
            string path = @"D:\html\html.txt";
            Console.WriteLine(DLR.DownloadLoadRead(path,link));
        }
    }
}

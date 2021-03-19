using System;
using System.IO;
using System.Diagnostics;

namespace TestProjectSimbirSoft
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Введите ссылку на страницу: ");
            string link = Console.ReadLine();
            string path = @"D:\html\html.txt"; //Указать путь к файлу, в который будет сохраняться html-страница
            Sort.SortPage(Parse.ParsePage(DownLoad_Read.DownloadRead(path, link)));
        }
    }
}

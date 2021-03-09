using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;
using System.IO;

namespace TestProjectSimbirSoft
{
    class DLR
    {
        public static string DownloadLoadRead(string path, string link)
        {
            string text = "";

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(link, path);
            }

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(path);

            using (StreamReader str = new StreamReader(path))
            {
                text = str.ReadToEnd();
            }

            return text;
        }
    }
}

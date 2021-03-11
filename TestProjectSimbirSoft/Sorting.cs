using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectSimbirSoft
{
    class Sorting
    {
        public static void SortPage(string[] text)
        {
            var result = from i in text
                         group i by i into g
                         select new
                         {
                             Name = g.Key,
                             Count = g.Count()
                         };
            foreach (var i in result)
            {
                Console.WriteLine($"{i.Name} - {i.Count}");
            }
        }
    }
}

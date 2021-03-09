using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectSimbirSoft
{
    class Parsing
    {
        public static string ParsePage(string oldText)
        {
            string text = "";


            
            
            for (int i = 0; i < oldText.Length; i++)
            {
                if (oldText[i].Equals('<'))
                {
                    while (!oldText[i].Equals('>'))
                    {
                        i++;
                    }
                }
                else
                {
                    text += oldText[i];
                }
            }

            return text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TestProjectSimbirSoft
{
    class Remove
    {
        public static string RemoveJS(string text)
        {
            Regex regex = new Regex(@"(?s)<script.*?(/>|</script>)", RegexOptions.IgnoreCase);
            text = regex.Replace(text, " ");
            return text;
        }
    }
}

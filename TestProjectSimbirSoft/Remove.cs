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
            Regex regexJS = new Regex(@"(?s)<script.*?(/>|</script>)", RegexOptions.IgnoreCase);
            Regex regexST = new Regex(@"(?s)<style.*?(/>|</style>)", RegexOptions.IgnoreCase);
            text = regexJS.Replace(text, " ");
            text = regexST.Replace(text, " ");
            return text;
        }
    }
}

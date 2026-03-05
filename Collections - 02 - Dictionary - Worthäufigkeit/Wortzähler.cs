using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collections___02___Dictionary___Worthäufigkeit
{
    internal static class Wortzähler<TKey, TValue> where TKey : IComparable where TValue : IComparable
    {
        static Dictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();

        static public int Count(String text)
        {
            String text2=Regex.Replace(text, @"\W", " ");
            text2 = Regex.Replace(text2, @"[\s]+", "");

        }
    }
}

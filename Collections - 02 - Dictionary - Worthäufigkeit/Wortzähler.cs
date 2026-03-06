using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collections___02___Dictionary___Worthäufigkeit
{
    internal static class Wortzähler<TKey, TValue> where TKey : IComparable where TValue : IComparable
    {
        static Dictionary<String, int> dict = new Dictionary<String, int>();

        static public Dictionary<String, int> Count(String text)
        {
            Dictionary<String, int> dict = new Dictionary<String, int>(); // Anlegen Dictionary
            // Ersetzen aller vorkommen von mind. 1 Nichtwortzeichen durch Leerzeichen, dann alles kleingeschrieben
            String text2 =Regex.Replace(text, @"\W+", " ").ToLower(); 
            // String-Array aus String erstellen mit Leerzeichen als Trennzeichen
            String[] splitted = text2.Split(' ');
            // Aus dem String-Array ein Dictionary füllen
            for(int i=0; i<splitted.Length;i++)
            {
                if (dict.TryGetValue(splitted[i], out int value)) // wenn das Wort schon im Dictionary
                {
                    dict[splitted[i]] = dict[splitted[i]] + 1; // Vorkommen erhöhen
                }
                else dict.Add(splitted[i], 1); // Sonst Wort dem Dictionary hinzufügen
            }
            return dict; // Dictionary zurückgeben
        }

        static public void PrintInOrder(Dictionary<String, int> dict)
        {
            // Neues Dicitonary anlegen in dem Die Einträge nach Vorkommen sortiert sind
            Dictionary<String, int> dictSorted = new Dictionary<string, int>();
            // Maximales Vorkommen ermitteln
            int maxVorkommen = MaxVorkommen(dict);
            // Für jedes mögliche Vorkommen, beginnend mit dem maximalen Vorkommen
            for(int i= maxVorkommen; i>=1; i--)
            {
                foreach (KeyValuePair<String, int> paar in dict) // Wenn das Vorkommen übereinstimmt, Wörter hinzufügen
                {
                    if (paar.Value == i) dictSorted.Add(paar.Key, paar.Value);
                }
            }
            Print(dictSorted);  // Ausgeben
        }

        static private int MaxVorkommen(Dictionary<String, int> dict)
        {
            int vorkommen = 0;
            foreach (KeyValuePair<String, int> paar in dict)
            {
                if (paar.Value > vorkommen) vorkommen = paar.Value;
            }
            return vorkommen;
        }

        static public void Print(Dictionary<String, int> dict)
        {
            foreach (KeyValuePair<String, int> paar in dict)
            {
                Console.WriteLine($"{paar.Key,15} | Vorkommen: {paar.Value}");
            }
        }
    }
}

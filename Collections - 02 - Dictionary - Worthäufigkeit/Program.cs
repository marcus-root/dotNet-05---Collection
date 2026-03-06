namespace Collections___02___Dictionary___Worthäufigkeit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Datei einlesen und in einen String speichern
            FileStream fs = new FileStream(@"D:\Froschkönig Unix Zeilenumbrüche.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            String text = sr.ReadToEnd();

            // Aus dem String ein Dictionary erstellen
            Dictionary<String, int> dict = Wortzähler<String, int>.Count(text);
            // Das Dictionary der Wörter nach Vorkommen sortiert ausgeben
            Wortzähler<String, int>.PrintInOrder(dict);

            sr.Close();
            fs.Close();
        }
    }
}

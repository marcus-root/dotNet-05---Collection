namespace Collections___01___Stacks___Kommando_tac___Klammersetzung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<IComparable> froschkönig = tac<IComparable>.Einlesen(@"D:\Froschkönig Unix Zeilenumbrüche.txt");
            tac<IComparable>.Ausgeben(froschkönig);

            Console.Write("Eingabe: ");
            if (klammerPrüfer<IComparable>.Prüfen(Console.ReadLine())) Console.WriteLine("klammern ok...");
            else Console.WriteLine("klammern nicht ok...\n\n\n");
        }
    }
}

namespace Collections___01___Stacks___Kommando_tac___Klammersetzung
{
    internal static class tac<T> where T : IComparable
    {
        public static void Ausgeben(Stack<IComparable> stack)
        {
            String line = "";
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        public static Stack<IComparable> Einlesen(String pfad)
        {
            Stack<IComparable> stack = new Stack<IComparable>();
            FileStream fs = new FileStream(pfad, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                stack.Push(sr.ReadLine());
            }
            return stack;
        }
    }
}

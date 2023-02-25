namespace Day14LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            
            list.PrintList();

            list.InsertAfter(56, 30);
            list.PrintList();
        }
    }
}
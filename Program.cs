namespace Day14LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            list.Add(30);

            list.PrintList();


            int poppedValue = list.Pop();
            Console.WriteLine("Popped The First Element : " + poppedValue);
            list.PrintList();


        }
    }
}
﻿namespace Day14LinkedList
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


            int size = list.GetSize();
            Console.WriteLine("Size of list: " + size);


        }
    }
}
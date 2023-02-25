﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14LinkedList
{
    public class LinkedList
    {
        public Node Head;

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void PrintList()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void InsertAfter(int existingData, int newData)
        {
            Node current = Head;

            while (current != null && current.Data != existingData)
            {
                current = current.Next;
            }

            if (current == null)
            {
                // The existing node with the given value was not found.
                Console.WriteLine("Node with value " + existingData + " not found.");
            }
            else
            {
                Node newNode = new Node(newData);
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public int Pop()
        {
            if (Head == null)
            {
                throw new Exception("Cannot pop from an empty list.");
            }

            int result = Head.Data;
            Head = Head.Next;
            return result;
        }


        public int PopLast()
        {
            if (Head == null)
            {
                throw new Exception("Cannot pop from an empty list.");
            }
            else if (Head.Next == null)
            {
               
                int result = Head.Data;
                Head = null;
                return result;
            }
            else
            {
               
                Node current = Head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }

                
                int result = current.Next.Data;

                
                current.Next = null;

                return result;
            }
        }


        public bool Search(int value)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data == value)
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }
    }
}

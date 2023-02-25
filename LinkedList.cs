using System;
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

        public void Delete(int value)
        {
            if (Head == null)
            {
                throw new Exception("Cannot delete from an empty list.");
            }
            else if (Head.Data == value)
            {
                // If the value to delete is in the first node, just remove the first node.
                Head = Head.Next;
            }
            else
            {
                // Traverse the list until we find the node before the one to delete.
                Node current = Head;
                while (current.Next != null && current.Next.Data != value)
                {
                    current = current.Next;
                }

                if (current.Next == null)
                {
                    throw new Exception("Value not found in list.");
                }

                // Remove the node with the matching value.
                current.Next = current.Next.Next;
            }
        }

        public int GetSize()
        {
            int count = 0;
            Node current = Head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
    }
}

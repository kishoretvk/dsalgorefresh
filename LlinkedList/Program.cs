using System;

namespace LlinkedList
{

     class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var first = new Node { Value = 11 };
            var middle = new Node { Value = 12 };
            var last = new Node { Value = 14 };
           

            //making linked List here !
            first.Next = middle;
            middle.Next = last;
            Print(first);
            Console.WriteLine("Hello World!");
            Console.Read();

        }
        private static void Print(Node node)
        {
            Console.WriteLine("printing List!");
            while (node != null)
            {

                Console.WriteLine(node.Value);
                node = node.Next;
            }
            Console.WriteLine("printing list completed!");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeAndNodeChains
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chaining a node.

            //First node
            //Has a pointer to second node
            Node first = new Node();
            first.Value = 1;

            //Second node
            //has a pointer to third node
            Node second = new Node();
            second.Value = 2;
            first.Next = second;

            Node third = new Node();
            third.Value = 3;
            second.Next = third;

            PrintNodes(first);
        }

        public static void PrintNodes(Node node)
        {
            while (node!=null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class LinkedListNode<T>
    {
        //Allowing this constructor to create a node of Type T
        public LinkedListNode(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public LinkedListNode<T> Next { get; set; }
    }
}

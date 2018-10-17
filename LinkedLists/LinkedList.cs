using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class LinkedList<T> : ICollection<T>
    {
        public LinkedListNode<T> Head { get; private set; }

        public LinkedListNode<T> Tail { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new LinkedListNode<T>(value));
        }

        //We have to add a node to the list
        //We have to add a new node and move the existing list to a new mode.
        //WE have to set the head ans tail the same value if the count is 1
        public void AddFirst(LinkedListNode<T> node)
        {
            //Save the head as we need it when a new node is added. Its added to the next item for new NOde (Head)
            var temp = Head;
            //Assign the new node to Head
            Head = node;
            //Assign the previous head to the next of the new head.
            Head.Next = temp;

            Count++;
            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new LinkedListNode<T>(value));
        }
        public void AddLast(LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }

            Tail = node;

            Count++;
        }

        public void RemoveFirst()
        {
            if (Count == 0)
            {
                return;
            }

            Head = Head.Next;
            Count--;
            if (Count == 0)
            {
                Tail = null;
            }
        }

        public void RemoveLast()
        {
            if (Count == 0)
            {
                return;
            }

            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                LinkedListNode<T> current = Head;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }

                current.Next = null;
                Tail = current;


            }
        }
        #region ICollection members

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            AddFirst(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            var current = Head;
            while (current!=null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = Head;

            while (current!=null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        Count--;
                        if (current.Next == null)
                        {
                            Tail = current;
                        }
                    }
                    RemoveFirst();
                }

                previous = current;
                current = current.Next;
            }
        }

        public int Count { get; private set; }
        public bool IsReadOnly { get; }

        #endregion
    }
}

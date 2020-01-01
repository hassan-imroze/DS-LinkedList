using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_LinkedList
{
    public class LinkList
    {
        private Node first;
        private Node last;

        private int size;
        public int Size { get { return size; } }

        private bool IsEmpty()
        {
            return first == null;
        }

        private bool HasOneItem()
        {
            return first == last;
        }

        public void AddFirst(int value)
        {
            Node newFirst = new Node();
            newFirst.value = value;

            if (IsEmpty())
                first = last = newFirst;
            else
            {
                newFirst.next = first;
                first = newFirst;
            }

            size++;
        }

        public void AddLast(int value)
        {
            Node newLast = new Node();
            newLast.value = value;

            if (IsEmpty())
                first = last = newLast;
            else
            {
                last.next = newLast;
                last = newLast;
            }

            size++;
        }

        public void RemoveFirst()
        {

            if (IsEmpty())
                return;
            if (HasOneItem())
            {
                first = last = null;
                size = 0;
                return;
            }

            first = first.next;
            size--;
        }

        public void RemoveLast()
        {
            if (IsEmpty())
                return;
            if (HasOneItem())
            {
                first = last = null;
                size = 0;
                return;
            }

            var current = first;
            while (current.next != last)
                current = current.next;
            last = current;
            last.next = null;
            size--;
        }

        public int IndexOf(int item)
        {
            var current = first;
            int index = 0;
            while (current != null)
            {
                if (current.value == item) return index;

                index++;
                current = current.next;
            }

            return -1;
        }

        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }

        public void Print()
        {
            if (first != null && last != null)
            {
                var current = first;
                while (current != last)
                {
                    Console.Write(string.Format("{0}-->", current.value));
                    current = current.next;
                }
                Console.Write(current.value);
                Console.WriteLine();
            }
        }

        internal void PrintMiddle()
        {
            var middle = first;
            var current = first;
            while(current != last && current.next != last)
            {
                current = current.next.next;
                middle = middle.next;
            }
            
            if (current == last) // If Odd number of nodes
                Console.WriteLine(middle.value);
            else // If Even number of nodes
                Console.WriteLine(string.Format("{0},{1}", middle.value, middle.next.value));

        }

        // runtime complexity: O(n^2)
        public void Reverse1()
        {
            if (first != null && first != last)
            {
                var previousFirst = first;
                var previousLast = last;

                last = previousFirst;
                first = previousLast;

                var currentReverse = previousLast;
                var current = previousFirst;
                while (currentReverse != previousFirst)
                {
                    while (current.next != currentReverse)
                    {
                        current = current.next;
                    }
                    currentReverse.next = current;
                    currentReverse = current;
                    current = previousFirst;
                }

                last.next = null;
            }
        }
        // runtime complexity: O(n)
        public void Reverse2()
        {
            if (first != null && first != last)
            {
                var previous = first;
                var current = first.next;

                while (current != null)
                {
                    var next = current.next;
                    current.next = previous;
                    previous = current;
                    current = next;
                }

                last = first;
                last.next = null;
                first = previous;
            }
        }

        public int getKthFromTheEnd(int k)
        {
            if (IsEmpty())
                throw new NullReferenceException("The linked list is empty");


            var firstNode = first;
            var secondNode = first;
            for (int i = 1; i < k; i++)
            {
                secondNode = secondNode.next;
                if (secondNode == null)
                    throw new ArgumentOutOfRangeException("the value of 'k' exceeds the length of the linked list");
            }


            while (secondNode != last)
            {
                secondNode = secondNode.next;
                firstNode = firstNode.next;
            }
            return firstNode.value;


        }

        public int[] ToArray()
        {
            int[] array = new int[size];
            if (size > 0)
            {
                int index = 0;
                var current = first;

                while (current != null)
                {
                    array[index++] = current.value;
                    current = current.next;
                }
            }
            return array;
        }
    }
}

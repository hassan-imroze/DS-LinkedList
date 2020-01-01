using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicLinkedList();

            //CreatedLinkedListExample();

            //ReversingTheLinkedList();

            //GetTheKthNodeValueFromLast();

            PrintTheMiddleNodes();
            Console.ReadKey();
        }

        


        private static void BasicLinkedList()
        {
            LinkedList<int> lList = new LinkedList<int>();
            lList.AddFirst(1);
            lList.AddLast(4);
            lList.AddLast(13);
            Console.WriteLine(lList.Contains(3));
            Console.WriteLine(lList.Count);

        }

        private static void CreatedLinkedListExample()
        {
            LinkList linkList = new LinkList();
            linkList.Print();
            linkList.AddFirst(6);
            linkList.Print();
            linkList.AddFirst(3);
            linkList.AddLast(7);
            linkList.AddFirst(13);
            linkList.AddLast(10);
            linkList.Print();
            linkList.RemoveFirst();
            linkList.Print();
            linkList.RemoveLast();
            linkList.Print();
            linkList.RemoveLast();
            linkList.Print();
            linkList.RemoveLast();
            linkList.RemoveLast();
            linkList.RemoveLast();
            linkList.Print();
        }

        private static void ReversingTheLinkedList()
        {
            LinkList linkList = new LinkList();
            linkList.AddFirst(6);
            linkList.AddFirst(3);
            linkList.AddLast(7);
            linkList.AddFirst(13);
            linkList.AddLast(10);
            //13 -> 3 -> 6 -> 7 -> 10 
            linkList.Print();
            linkList.Reverse1();
            linkList.Print();
            linkList.Reverse2();
            linkList.Print();

        }


        private static void GetTheKthNodeValueFromLast()
        {
            LinkList linkList = new LinkList();
            linkList.AddFirst(6);
            linkList.AddFirst(3);
            linkList.AddLast(7);
            linkList.AddFirst(13);
            linkList.AddLast(10);
            Console.WriteLine(linkList.getKthFromTheEnd(1));
            Console.WriteLine(linkList.getKthFromTheEnd(0));
            Console.WriteLine(linkList.getKthFromTheEnd(3));
            Console.WriteLine(linkList.getKthFromTheEnd(2));
            Console.WriteLine(linkList.getKthFromTheEnd(4));
            Console.WriteLine(linkList.getKthFromTheEnd(5));
            //Console.WriteLine(linkList.getKthFromTheEnd(6));
           
        }
         
        private static void PrintTheMiddleNodes()
        {
            LinkList linkList = new LinkList();
            linkList.AddFirst(6);
            linkList.PrintMiddle();
            linkList.AddFirst(3);
            linkList.PrintMiddle();
            linkList.AddLast(7);
            linkList.PrintMiddle();
            linkList.AddFirst(13);
            linkList.PrintMiddle();
            linkList.AddLast(10);
            linkList.PrintMiddle();
            linkList.AddLast(20);
            linkList.PrintMiddle();
        }
    }
}

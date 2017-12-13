using System;

namespace MiddleOfLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            Node node1 = new Node(2);
            Node node2 = new Node(3);
            Node node3 = new Node(4);
            Node node4 = new Node(5);
            Node node5 = new Node(6);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            lList.head = node1;

            Middle(lList);
            Console.ReadKey();
        }
        public static void Middle(LinkedList lList)
        {
            //Method1
            int n = 0;
            Node current = lList.head;
            while(current.next!=null)
            {
                current = current.next;
                n++;
            }
            int m = n / 2;
            current = lList.head;
            while ((m--)>0)
            {
                current = current.next;
            }
            Console.WriteLine(current.data);


            //Method2
            Node pointer1 = lList.head;
            Node pointer2 = lList.head;
            while(pointer2!=null && pointer2.next!=null)
            {
                    pointer1 = pointer1.next;
                    pointer2 = pointer2.next.next;
            }
            Console.WriteLine(pointer1.data);
        }
    }
    public class LinkedList
    {
        public Node head;
    }
    public class Node
    {
        public int data;
        public Node next;
        public Node(int value)
        {
            data = value;
            next = null;
        }
    }
}

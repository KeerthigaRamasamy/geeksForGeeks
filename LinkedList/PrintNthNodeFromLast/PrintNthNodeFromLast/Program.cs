using System;

namespace PrintNthNodeFromLast
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            Node node1 = new Node(20);
            Node node2 = new Node(4);
            Node node3 = new Node(15);
            Node node4 = new Node(35);
            //Node node5 = new Node(6);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            //node4.next = node5;

            lList.head = node1;

            int n = 4;
            PrintNthNode(n, lList);
            Console.ReadKey();
        }
        public static void PrintNthNode(int n,LinkedList lList)
        {
            Node pointer1 = lList.head;
            Node pointer2 = lList.head;

            for(int i=1;i<n;i++)
            {
                pointer2 = pointer2.next;
            }
            while(pointer2.next!=null)
            {
                pointer1 = pointer1.next;
                pointer2 = pointer2.next;
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

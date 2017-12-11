using System;

namespace PrintNthNode
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

            PrintNthNodeOfLinkedList(lList, 4);
            Console.ReadKey();
        }
        public static void PrintNthNodeOfLinkedList(LinkedList lList,int n)
        {
            int count = 0;
            Node current = lList.head;
            while(current!=null && current.next!=null)
            {
                if(count==n)
                {
                    Console.WriteLine(current.data);
                    return;
                }
                current = current.next;
                count++;
            }
            if(current!=null && n<=count)
            {
                Console.WriteLine(current.data);
                return;
            }
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

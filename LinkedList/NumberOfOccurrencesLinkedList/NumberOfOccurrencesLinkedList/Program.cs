using System;

namespace NumberOfOccurrencesLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            Node node1 = new Node(2);
            Node node2 = new Node(3);
            Node node3 = new Node(2);
            Node node4 = new Node(5);
            Node node5 = new Node(2);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            lList.head = node1;

            int count=NumberOfOccurrence(lList.head, 2);
            Console.WriteLine(count);
            Console.ReadKey();
        }
        public static int NumberOfOccurrence(Node head,int key)
        {
            int count = 0;          
            Node current = head;
            while(current!=null)
            {
                if(current.data==key)
                {
                    count++;
                }
                current = current.next;
            }
            return count;
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

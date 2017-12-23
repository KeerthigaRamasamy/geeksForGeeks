using System;

namespace ReverseLinkedList
{
    class Program
    {
        Node head;
        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            Node node1 = new Node(2);
            Node node2 = new Node(1);
            Node node3 = new Node(4);
            Node node4 = new Node(3);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            lList.head = node1;

            Node current = lList.head;
            Console.WriteLine("Before reverse");
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }

            lList.Reverse(lList.head);
            //lList.head = ReverseIterative(lList.head);

            current = lList.head;
            Console.WriteLine("After reverse");
            while(current!=null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.ReadKey();

           
        }

        

        public static Node ReverseIterative(Node head)
        {
            Node current = head;
            Node prev = null;
            Node next;
            while(current.next!=null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            current.next = prev;
            return current;
        }
    }
    public class LinkedList
    {
        public Node head;
        public Node prev;
        public LinkedList()
        {
            prev = null;
        }
        public void Reverse(Node current)
        {
            if (current.next != null)
            {
                prev = current;
                current = current.next;
                Reverse(current);
                current.next = prev;
            }
            else
            {
                //head = prev;
                head = current;
            }
        }
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

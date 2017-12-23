using System;
using System.Collections.Generic;

namespace LoopInLinkedList
{
    class Program
    {
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
            //node4.next = node1;
            lList.head = node1;

            Console.WriteLine(DetectLoop(lList.head));
            Console.ReadKey();
        }

        public static bool DetectLoop(Node head)
        {
            Dictionary<Node, int> map = new Dictionary<Node, int>();
            Node current = head;
            map.Add(current, 1);
            current = current.next;
            while(current!=null)
            {
                if(current.next!=null && map.ContainsKey(current.next))
                {
                    return true;
                }
                if(!map.ContainsKey(current))
                {
                    map.Add(current, 1);
                }
                current = current.next;
            }
            return false;
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

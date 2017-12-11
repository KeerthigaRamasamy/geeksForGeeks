using System;

namespace DeleteANodeWithoutPointerToHead
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            Node node1 = new Node(2);
            Node node2 = new Node(3);
            Node node3 = new Node(4);
            node1.next = node2;
            node2.next = node3;
            lList.head = node1;

            Delete(node2);

            PrintAllNodes(lList);
            Console.ReadKey();
        }
        public static void Delete(Node nodeToBeDeleted)
        {
            Node temp = nodeToBeDeleted.next;   //this will not work if the node to be deleted is the last node 
            nodeToBeDeleted.data = temp.data;
            nodeToBeDeleted.next = temp.next;
        }
        public static void PrintAllNodes(LinkedList lList)
        {
            Node current = lList.head;
            while(current!=null)
            {
                Console.WriteLine(current.data);
                current = current.next;
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

using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            lList.head = new Node(1);
            lList.InsertLast(2);
            lList.InsertBeginning(0);
            lList.InsertLast(3);
            lList.InsertLast(4);
            lList.InsertLast(5);
            lList.InsertBeginning(-1);
            lList.Delete(5);
            lList.PrintAllNodes();
            Console.ReadKey();
        }
    }

    public class LinkedList
    {
        public Node head;

        public void InsertLast(int value)
        {
            if(head==null)
            {
                head = new Node(value);
            }
            Node current = head;
            while(current.next!=null)
            {
                current = current.next;
            }
            Node newNode = new Node(value);
            current.next = newNode;

        }
        public void Delete(int key)
        {
            if(head!=null && head.data==key)
            {
                if(head.next!=null)
                {
                    head = head.next;
                    return;
                }
            }
            Node current = head;
            Node previous = null;
            while (current != null)
            {
                if(current.data==key)
                {
                    previous.next = current.next;
                    break;
                }
                previous = current;
                current = current.next;
            }
        }
        public void InsertBeginning(int value)
        {
            Node newNode = new Node(value);
            newNode.next = head;
            head = newNode;
        }
        public void PrintAllNodes()
        {
            Node current = head;
            while(current!=null)
            {
                Console.WriteLine(current.data);
                current = current.next;
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

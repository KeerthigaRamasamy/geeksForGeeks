using System;
using System.Collections.Generic;

namespace PalindromeLinkedList
{
    class Program
    {
        public static Stack<char> stack = new Stack<char>();
        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();
            Node node1 = new Node('R');
            Node node2 = new Node('A');
            Node node3 = new Node('D');
            Node node4 = new Node('A');
           // Node node5 = new Node('R');
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            //node4.next = node5;
            lList.head = node1;

            bool isPalindrome = Palindrome(lList.head);
            Console.WriteLine(isPalindrome);
            Console.ReadKey();
        }

        public static bool Palindrome(Node head)
        {
            Node current = head;
            if(current!=null)
            {
                stack.Push((char)current.data);
                current = current.next;
                Palindrome(current);
                if(current!=null && stack.Count!=0 && (char)current.data!=stack.Pop())
                {
                    return false;
                }
            }
            return true;
        }
    }

    public class LinkedList
    {
        public Node head;
    }
    public class Node
    {
        public object data;
        public Node next;
        public Node(char value)
        {
            data = value;
            next = null;
        }
    }
}

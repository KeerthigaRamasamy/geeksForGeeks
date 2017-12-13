using System;
using System.Collections;

namespace ReverseStackUsingRecursion
{
    class Program
    {
       // static int temp = 0;
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            Reverse(stack);
            while(stack.Count!=0)
            {
                Console.WriteLine(stack.Pop());
            }
            Console.ReadKey();
        }

        public static void InsertAtBottom(Stack stack,int item)
        {        
            if(stack.Count!=0)
            {
                int t = (int)stack.Pop();
                InsertAtBottom(stack, item);
                stack.Push(t);
            }
            else
            {
                stack.Push(item);
                return;
            }
           
        }

        public static void Reverse(Stack stack)
        {
            if (stack.Count != 0)
            {
                int temp = (int)stack.Pop();
                Reverse(stack);
                InsertAtBottom(stack, temp);
            }
        }
    }
}

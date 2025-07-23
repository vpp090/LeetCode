using System;

namespace MyApp
{
    internal class Program
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;

            while(current != null)
            {
                ListNode nextNode = current.next;
                current.next = prev;
                prev = current;
                current = nextNode;
            }

            return prev;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // null -> 1 -> 2 -> 3 -> 4
        // null <- 1 <- 2   <-  3
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
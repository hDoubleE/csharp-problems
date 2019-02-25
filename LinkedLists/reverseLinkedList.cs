namespace DataStructures
{
    public class Program
    {
        static void Main()
        {
            ListNode n = new ListNode(1);
            n.next = new ListNode(2);
            n.next.next = new ListNode(3);
            Solution s = new Solution();
            s.Print(n);
            ListNode reverse = s.RecerseList(n);
            s.Print(reverse);
        }
    }
// Reverse a singly linked list.

// Input: 1->2->3->4->5->NULL
// Output: 5->4->3->2->1->NULL

// https://leetcode.com/problems/reverse-linked-list/

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        // Iterative solution.
        public ListNode ReverseList(ListNode head)
        {
            ListNode current = head;
            ListNode previous = null;
            while (current != null)
            {
                ListNode nextTemp = current.next;
                current.next = previous;
                previous = current;
                current = nextTemp;
            }
            head = previous;
            return head;
        }
        // Recursive solution.
        // Can return void also with no 'p' variable.
        public ListNode RecerseList(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode p = RecerseList(head.next);
            head.next.next = head;
            head.next = null;
            return p;
        }

        public void Print(ListNode head)
        {
            ListNode current = head;
            while (current != null)
            {
                Console.Write(current.val + " ");
                current = current.next;
            }
            Console.WriteLine();

        }
    }
}
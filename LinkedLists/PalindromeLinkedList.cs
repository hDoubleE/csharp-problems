// Given a singly linked list, determine if it is a palindrome.
// https://leetcode.com/problems/palindrome-linked-list/
// Input: 1->2
// Output: false
// Example 2:

// Input: 1->2->2->1
// Output: true
// Follow up:
// Could you do it in O(n) time and O(1) space?

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution 
{
    public bool IsPalindrome(ListNode head) 
    {
        
        if (head == null || head.next == null) return true;
        
        ListNode slow = head;
        ListNode fast = head;
       
        Stack<int> st = new Stack<int>();
        
        while (fast != null && fast.next != null)
        {
            st.Push(slow.val);
            slow = slow.next;
            fast = fast.next.next;
        }
        
        if (fast != null)
        {
            slow = slow.next;
        }
        
        while (slow != null)
        {
            int popped = st.Pop();
            if (popped != slow.val) 
            {
                return false;
            }
            slow = slow.next;
        }
        return true;
    }
}
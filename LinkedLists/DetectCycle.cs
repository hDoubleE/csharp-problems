/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 * Given a linked list, return the node where the cycle begins. If there is no cycle, return null. 
 * To represent a cycle in the given linked list, we use an integer pos which represents the position 
 * (0-indexed) in the linked list where tail connects to. If pos is -1, then there is no cycle in the linked list.
 * https://leetcode.com/problems/linked-list-cycle-ii/
 * 1. Detect if Linked List has a loop using fast runner and slow runner.
 *  If they collide and are at the same node by reference, not value, there is a loop.
 * 2. They collide k nodes away from beginning of loop. Also k nodes from head of list.
 *  Increment from head and collision point to get to start of loop and return.
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        //if (head == null) return head;
        
        ListNode slow = head;
        ListNode fast = head;
        
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                slow = head;
                while (slow != fast)
                {
                    slow = slow.next;
                    fast = fast.next;
                }
                return slow;
            }
        }
        return null;
    }
}
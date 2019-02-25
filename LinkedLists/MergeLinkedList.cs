/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 https://leetcode.com/problems/merge-two-sorted-lists/
 Don't touch the two lists, just adjust pointers as you go.
 At the end return dummyHead.next which points to head.
 */

 
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if (l1 == null) return l2;
        if (l2 == null) return l1;
        ListNode dummyHead = new ListNode(0);
        ListNode current = dummyHead;
        ListNode p1 = l1, p2 = l2;
        while (p1 != null && p2 != null)
        {
            if (p1.val <= p2.val)
            {
                current.next = p1;
                p1 = p1.next;
            }
            else 
            {
                current.next = p2;
                p2 = p2.next;
            }
            current = current.next;
            current.next = p1 != null ? p1 : p2;
        }
        return dummyHead.next;
    }
}
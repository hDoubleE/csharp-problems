/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }

 Write a function to delete a node (except the tail) 
 in a singly linked list, given only access to that node.
 Input: head = [4,5,1,9], node = 5
 Output: [4,1,9]
 */

public class Solution {
    public void DeleteNode(ListNode node) 
    {
        node.val = node.next.val;
        node.next = node.next.next;
    }
    
    // You can also make a copy of Next node and copy that over.
    public void DeleteNode(ListNode node) 
    {
        ListNode nextCopy = node.next;
        node.val = nextCopy.val;
        node.next = nextCopy.next;
    }
}

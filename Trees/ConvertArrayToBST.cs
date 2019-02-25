/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
 Given an array where elements are sorted in ascending order, convert it to a height balanced BST.
 For this problem, a height-balanced binary tree is defined as a binary tree 
 in which the depth of the two subtrees of every node never differ by more than 1.
 */

// [6, 9, 11, 15, 18, 22]

// This is a recursive pre-order traversal of a bst.
// Make node, go left, go right. Return.
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        return SortBST(nums, 0, nums.Length - 1);
    }
    // Define helper method with two pointers on Array.
    private TreeNode SortBST(int[] arr, int start, int end)
    {
        // Base case is based on array.
        if (end < start) return null;
        // Calculate mid of Array each call.
        int mid = (start + end) / 2;
        // Make node of mid in array.
        TreeNode n = new TreeNode(arr[mid]);
        // Assign left to Recursive case.
        n.left = SortBST(arr, start, mid - 1);
        // Assign right to Recursive case.
        n.right = SortBST(arr, mid + 1, end);
        // Return node and populate new tree from call stack ending at original call.
        return n;
    }
}

//   11
//  6     18
//   9   15 22   
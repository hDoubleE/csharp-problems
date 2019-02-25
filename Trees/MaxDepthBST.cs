// Given a binary tree, find its maximum depth.
// The maximum depth is the number of nodes along the 
//longest path from the root node down to the farthest leaf node.

// https://leetcode.com/problems/maximum-depth-of-binary-tree/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

 // This is basically Post-Order traversal. 
 public class Solution {

    // Modified solution.
    public int MaxDepth2(TreeNode root) {
        if (root == null) return 0;
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
    // Original Solution.
    public int MaxDepth1(TreeNode root) {
        if (root == null) return 0;

            int leftHeight = MaxDepth(root.left);
            int rightHeight = MaxDepth(root.right);

            return Math.Max(leftHeight, rightHeight) + 1;
    }
    // Adding recursive count leaf Method for tracking here. 
    public int CountLeafNodes(BinarySearchTreeNode<T> root)
    {
        if (root == null) return 0;
        if (root.Left == null && root.Right == null) return 1;
        return CountLeafNodes(root.Left) + CountLeafNodes(root.Right);
    }
}
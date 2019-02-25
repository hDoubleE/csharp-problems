// Given a Binary Search Tree and a target number, 
//return true if there exist two elements in the BST such that their sum is equal to the given target.

// https://leetcode.com/problems/two-sum-iv-input-is-a-bst

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 Time complexity : O(n). We need to traverse over the whole tree once in all methods. 
 N refers to the number of nodes in the given tree.
Space complexity : O(n). The List will contain n sorted elements. HashSet will contain at worst n elements.
 */


public class Solution {
    public bool FindTargetHS(TreeNode root, int k) {
        HashSet<int> hs = new HashSet<int>();
        return searchSum(root, k, hs);
    }
    private bool searchSum(TreeNode root, int k, HashSet<int> hs)
    {
        if (root == null) return false;
        // If set contains k - node.val (complement), return true. It's pair is somewhere in the set.
        if (hs.Contains(k - root.val))
        {
            return true;
        }
        // Otherwise, add the complement.
        hs.Add(root.val);
        // Try again recursively.
        // left is true, right will not execute. If either is true, returns true.
        return searchSum(root.left, k, hs) || searchSum(root.right, k, hs);
    }
    
    // Similar approach, but do a BFS or level order traversal of tree.
    public bool FindTargetBFS(TreeNode root, int k) {
        // Set for complement values.
        HashSet<int> hs = new HashSet<int>();
        // Queue to enforce BFS.
        Queue<TreeNode> q = new Queue<TreeNode>();
        if (root == null) return false;
        q.Enqueue(root);
        while (q.Count > 0)
        {
            // It's possible to Enqueue null, so check here.
            if (q.Peek() != null)
            {
                // Copy node and check for complement in set.
                TreeNode node = q.Dequeue();
                if (hs.Contains(k - node.val)) return true;
                // If not there add it.
                hs.Add(node.val);
                // Enqueue next kids, breadth first.
                q.Enqueue(node.left);
                q.Enqueue(node.right);
            }
            else 
            {
                // If null value added, pop it. 
                q.Dequeue();
            }
        }
        return false;
    }
    // This solution uses InOrder traversal of tree (DFS).
    // Populate List with values InOrder (sorted) in helper method.
    // Check for sum in list in while loop.
    public bool FindTargetInOrder(TreeNode root, int k) {
        List<int> list = new List<int>();
        InOrder(root, list);
        int left = 0, right = list.Count() - 1;
        
        while (left < right)
        {
            int sum = list[left] + list[right];
            if (sum == k) return true;
            if (sum < k) left++;
            else right--;
        }
        return false;
    }
    private void InOrder(TreeNode root, List<int> list)
    {
        if (root == null) return;
        InOrder(root.left, list);
        list.Add(root.val);
        InOrder(root.right, list);
    }
}
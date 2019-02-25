/*
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 * Given a binary tree, return the level order traversal of its nodes' values. 
 * (ie, from left to right, level by level).
 * https://leetcode.com/problems/binary-tree-level-order-traversal/
 */

 
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        // Make a jagged to store result.
        List<IList<int>> bigList = new List<IList<int>>();
        
        // Null check
        if (root == null)  return bigList;
        
        // Declare Queue to enforce breadth first approach.
        Queue<TreeNode> q = new Queue<TreeNode>();
        
        q.Enqueue(root);
        
        // Use q.Count != 0 or q.Any() fron IEnumerable to check q isEmpty.
        while (q.Count != 0)
        {
            List<int> layerList = new List<int>();
            int size = q.Count;
            for (int i = 0; i < size; i++)
            {
                TreeNode currentNode = q.Dequeue();
                layerList.Add(currentNode.val);
                if (currentNode.left != null) q.Enqueue(currentNode.left);
                if (currentNode.right != null) q.Enqueue(currentNode.right);
            }
            bigList.Add(layerList);
        }
        return bigList;
    }
}
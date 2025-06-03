//530. Minimum Absolute Difference in BST
//3 June 2025

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    int res = int.MaxValue;
    TreeNode prevNode = null;

    public int GetMinimumDifference(TreeNode root) {
        SweepTree(root);
        return res;
    }

    private void SweepTree(TreeNode node)
    {
        if(node == null) return;

        SweepTree(node.left);
        if(prevNode != null) res = Math.Min(res, Math.Abs(node.val - prevNode.val));
        prevNode = node;
        SweepTree(node.right);
    }
}
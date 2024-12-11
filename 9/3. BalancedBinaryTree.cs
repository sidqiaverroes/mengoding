//leetcode 110: Balanced Binary Tree

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
    private bool Balanced = true;

    public bool IsBalanced(TreeNode root) {
        if(root == null) return true;

        TreeHeight(root);

        return Balanced;
    }

    private int TreeHeight(TreeNode root) //simply similar to Max Diameter
    {
        if(root == null) return 0;

        int left = TreeHeight(root.left);
        int right = TreeHeight(root.right);

        if(Math.Abs(left - right) > 1)
        {
            Balanced = false;
            return 0;
        }

        return 1 + Math.Max(left, right);
    }
}
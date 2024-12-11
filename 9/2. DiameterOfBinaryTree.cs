//leetcode 543: Diameter of Binary Tree

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
    private int maxCount = 0;

    public int DiameterOfBinaryTree(TreeNode root) {
        if(root == null) return 0;

        MaxDiameter(root);

        return maxCount;
    }

    private int MaxDiameter(TreeNode root) {
        if(root == null) return 0;

        int left = MaxDiameter(root.left);
        int right = MaxDiameter(root.right);

        maxCount = Math.Max(maxCount, left+right);

        return 1 + Math.Max(left, right);
    }
}
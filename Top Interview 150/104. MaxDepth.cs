//104. Maximum Depth of Binary Tree
//7 May 2025

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
    //My original solution after used to recursive
    int maxCount = 0;
    int count = 0;

    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;

        count++;
        MaxDepth(root.left);
        MaxDepth(root.right);
        maxCount = Math.Max(maxCount, count);
        count--;

        return maxCount;
    }
}
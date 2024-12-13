//leetcode 938. Range Sum of BST

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
    private int sum = 0;

    public int RangeSumBST(TreeNode root, int low, int high) {
        if(root == null) return 0;

        DFS(root, low, high);

        return sum;
    }

    private int DFS(TreeNode root, int low, int high)
    {
        if(root == null) return 0;

        if(root.val >= low && root.val <= high)
        {
            sum += root.val;
        }

        DFS(root.left, low, high);
        DFS(root.right, low, high);

        return 0;
    }
}
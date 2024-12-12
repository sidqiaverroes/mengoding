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
    int sum = 0;

    public bool HasPathSum(TreeNode root, int targetSum) {
        //My original solution
        if(root == null) return false;

        sum += root.val;

        bool leftSum = HasPathSum(root.left, targetSum);
        bool rightSum = HasPathSum(root.right, targetSum);

        if(sum == targetSum && root.left == null && root.right == null) return true;

        sum -= root.val;

        return leftSum || rightSum;

    }
}
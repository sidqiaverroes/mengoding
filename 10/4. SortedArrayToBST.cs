//leetcode 108. Convert Sorted Array to Binary Search Tree

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
    public TreeNode SortedArrayToBST(int[] nums) {
        return GenerateBST(nums, 0, nums.Length-1);
    }

    private TreeNode GenerateBST(int[] nums, int l, int r)
    {
        if(l > r) return null;
        
        int mid = (r+l)/2;

        TreeNode root = new TreeNode(nums[mid]);

        root.left = GenerateBST(nums, l, mid-1);
        root.right = GenerateBST(nums, mid+1, r);

        return root;
    }
}
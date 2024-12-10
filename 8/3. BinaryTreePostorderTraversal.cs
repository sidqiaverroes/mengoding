//leetcode 145: Binary Tree Postorder Traversal

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
    List<int> arr = [];
    public IList<int> PostorderTraversal(TreeNode root) {
        //My original solution that come up after reviewing another solutions of preorder and indorder traversal
        
        if(root == null) return arr;

        PostorderTraversal(root.left);
        PostorderTraversal(root.right);
        arr.Add(root.val);

        return arr;
    }
}
//leetcode 257. Binary Tree Paths

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
    List<string> res = [];

    public IList<string> BinaryTreePaths(TreeNode root) {
        if (root == null) return [];

        TreePaths(root);

        return res;
    }

    private int TreePaths(TreeNode root)
    {
        if(root == null) return 0;

        arr.Add(root.val);

        if(root.left == null && root.right == null)
        {
            //push to res the arr by join
            res.Add(string.Join("->", arr));
        }
        
        TreePaths(root.left);
        TreePaths(root.right);

        arr.RemoveAt(arr.Count-1);

        return 0;
    }
}
//leetcode 101: Symmetric Tree

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
    //My original solution
    List<int> arrLeft = [];
    List<int> arrRight = [];

    public bool IsSymmetric(TreeNode root) {
        PreorderTraversalLeft(root);
        PreorderTraversalRight(root);

        for(int i=0; i<arrLeft.Count; i++)
        {
            if(arrLeft[i] != arrRight[i]) return false;
        }

        return true;
    }

    private List<int> PreorderTraversalLeft(TreeNode root)
    {
        if(root == null)
        {
            arrLeft.Add(101);
            return arrLeft;
        }

        arrLeft.Add(root.val);
        PreorderTraversalLeft(root.left);
        PreorderTraversalLeft(root.right);

        return arrLeft;
    }

    private List<int> PreorderTraversalRight(TreeNode root)
    {
        if(root == null)
        {
            arrRight.Add(101);
            return arrRight;
        }

        arrRight.Add(root.val);
        PreorderTraversalRight(root.right);
        PreorderTraversalRight(root.left);

        return arrRight;
    }
}
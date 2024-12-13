//leetcode 993. Cousins in Binary Tree

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
    Dictionary<TreeNode, int> ValMapX = []; //parent: depth
    Dictionary<TreeNode, int> ValMapY = []; //parent: depth

    public bool IsCousins(TreeNode root, int x, int y) {
        if(root == null) return false;
        if(root.val == x || root.val == y) return false;
        if(root.left == null || root.right == null) return false;

        //find the target val and map
        TargetMap(root, 0, x, y);

        var ValX = ValMapX.First();
        var ValY = ValMapY.First();
        
        return ValX.Key != ValY.Key && ValX.Value == ValY.Value;
    }

    private void TargetMap(TreeNode root, int depth, int x, int y)
    {
        if(root == null) return;
        
        if(root.left != null)
        {
            if(root.left.val == x)
            {
                ValMapX.Add(root, depth+1);
            }
            if(root.left.val == y)
            {
                ValMapY.Add(root, depth+1);
            }
        }

        if(root.right != null)
        {
            if(root.right.val == x)
            {
                ValMapX.Add(root, depth+1);
            }
            if(root.right.val == y)
            {
                ValMapY.Add(root, depth+1);
            }
        }

        TargetMap(root.left, depth+1, x, y);
        TargetMap(root.right, depth+1, x, y);

        return;
    }

    //alternative solution will be, map the parent and depth for every node of the tree
}
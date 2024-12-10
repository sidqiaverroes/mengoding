//leetcode 94: Binary Tree Inorder Traversal

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
    public IList<int> InorderTraversal(TreeNode root) {
        //My original solution
        TreeNode node = root;
        Dictionary<TreeNode, string> dic = [];
        IList<int> arr = [];

        while(true)
        {
            if(root == null) break;

            if(!dic.ContainsKey(node)) dic.Add(node, "left");

            if(node.left != null)
            {
                node = node.left;
            }
            else if(node.right != null)
            {
                arr.Add(node.val);
                dic[node] = "right";
                node = node.right;
            }
            else
            {
                if(dic[node] != "right") arr.Add(node.val);
                
                dic.Remove(node);

                if(!dic.Any()) break;
                
                foreach(var ele in dic)
                {
                    node = ele.Key;
                }

                if(dic[node] == "left") node.left = null;
                else node.right = null;
            }
        }

        return arr;

    }
}
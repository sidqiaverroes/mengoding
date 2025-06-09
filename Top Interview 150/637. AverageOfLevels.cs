//637. Average of Levels in Binary Tree
//9 June 2025

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
    public IList<double> AverageOfLevels(TreeNode root) {
        IList<double> result = [];

        if(root == null) return result;

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count != 0)
        {
            int LevelSize = q.Count;
            double CurrentLevelSum = 0;

            for(int i=0; i<LevelSize; i++)
            {
                TreeNode node = q.Dequeue();
                CurrentLevelSum += node.val;

                if(node.left != null) q.Enqueue(node.left);
                if(node.right != null) q.Enqueue(node.right);
            }

            double CurrentLevelAvg = CurrentLevelSum / LevelSize;
            result.Add(CurrentLevelAvg);
        }

        return result;
    }
}
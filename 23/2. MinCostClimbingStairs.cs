//leetcode 746. Min Cost Climbing Stairs

public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        List<int> minCostReversed = [];
        int n = cost.Length;

        minCostReversed.Add(0);
        minCostReversed.Add(0);

        for(int i=n-1; i>=0; i--)
        {
            int currCost = cost[i] + Math.Min(minCostReversed[n-i], minCostReversed[n-i-1]);
            minCostReversed.Add(currCost);
        }

        return Math.Min(minCostReversed[n], minCostReversed[n+1]);
    }
}
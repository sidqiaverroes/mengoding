//1920. Build Array From Permutation
//6 May 2025

public class Solution {
    public int[] BuildArray(int[] nums) {
        int n = nums.Length;
        int[] ans = new int[n];

        for(int i=0; i<n; i++)
        {
            ans[i] = nums[nums[i]];
        }

        return ans;
    }
}
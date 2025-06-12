//3423. Maximum Difference Between Adjacent Elements in a Circular Array
//12 June 2025

public class Solution {
    public int MaxAdjacentDistance(int[] nums) {
        int n = nums.Length - 1;
        int max = Math.Abs(nums[n] - nums[0]);

        for (int i = 0; i < n; i++)
        {            
            max = Math.Max(Math.Abs(nums[i] - nums[i + 1]), max);
        }

        return max;
    }
}
//2016. Maximum Difference Between Increasing Elements
//16 June 2025

public class Solution
{
    public int MaximumDifference(int[] nums)
    {
        int left = nums[0];
        int max = -1;

        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[j] > left) max = Math.Max(max, nums[j] - left);
            else left = nums[j];
        }

        return max;
    }
}
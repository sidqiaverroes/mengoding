// leetcode 3105. Longest Strictly Increasing or Strictly Decreasing Subarray

public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        if(nums.Length == 1) return 1;

        int ans = 1;

        int count = 1;
        bool IsIncrease = nums[0] < nums[1];

        for(int i=1; i<nums.Length; i++)
        {
            if(nums[i-1] == nums[i])
            {
                count = 1;
                continue;
            }

            if(IsIncrease)
            {
                if(nums[i-1] < nums[i]) 
                {
                    count++;
                }
                else
                {
                    count = 2;
                    IsIncrease = false;
                }
            }
            else
            {
                if(nums[i-1] > nums[i]) 
                {
                    count++;
                }
                else
                {
                    count = 2;
                    IsIncrease = true;
                }
            }

            ans = Math.Max(ans, count);
        }

        return ans;
    }
}
//2962. Count Subarrays Where Max Element Appears at Least K Times
//29 April 2025

public class Solution {
    public long CountSubarrays(int[] nums, int k) {
        long count = 0;
        int left = 0, maxCount = 0;

        int max = nums[0];
        for (int i = 1; i < nums.Length; i++) max = Math.Max(max, nums[i]);

        for(int right=0; right<nums.Length; right++)
        {
            if(nums[right] == max) maxCount++;

            while(maxCount == k)
            {
                count += nums.Length-right;
                if(nums[left] == max)
                {
                    maxCount--;
                }
                left++;
            }
        }

        return count;
    }
}
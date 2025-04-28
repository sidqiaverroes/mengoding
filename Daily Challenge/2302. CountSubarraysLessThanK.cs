//2302. Count Subarrays With Score Less Than K
//28 April 2025

public class Solution {
    public long CountSubarrays(int[] nums, long k) {
        long count = 0, sum = 0;
        int left = 0;

        for(int right=0; right<nums.Length; right++)
        {
            sum += nums[right];
            while(sum*(right - left + 1) >= k)
            {
                sum -= nums[left++];
            }
            count += right-left+1;
        }

        return count;
    }
}
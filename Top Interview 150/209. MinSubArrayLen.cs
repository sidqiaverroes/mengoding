//209. Minimum Size Subarray Sum
//18 June 2025

public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int left = 0, right = 0;
        int n = nums.Length;

        int minLength = int.MaxValue;
        int sum = 0;
        while (right < n)
        {
            sum += nums[right++];
            while (left < n && sum >= target)
            {
                minLength = Math.Min(minLength, right - left);
                sum -= nums[left++];
            }
        }

        return minLength == int.MaxValue ? 0 : minLength;
    }
}
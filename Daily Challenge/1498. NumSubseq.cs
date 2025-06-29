//1498. Number of Subsequences That Satisfy the Given Sum Condition
//29 June 2025

public class Solution
{
    public int NumSubseq(int[] nums, int target)
    {
        Array.Sort(nums);

        int mod = 1000000007;
        int n = nums.Length;
        int ans = 0;

        int[] pow2 = new int[n];
        pow2[0] = 1;
        for (int i = 1; i < n; i++)
        {
            pow2[i] = (pow2[i - 1] * 2) % mod;
        }

        int left = 0, right = n - 1;
        while (left <= right)
        {
            if (nums[left] + nums[right] <= target)
            {
                ans = (ans + pow2[right - left]) % mod;
                left++;
            }
            else
            {
                right--;
            }
        }

        return ans;
    }
}
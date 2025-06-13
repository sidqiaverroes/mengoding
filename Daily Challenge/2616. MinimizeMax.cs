//2616. Minimize the Maximum Difference of Pairs
//13 June 2025

public class Solution
{
    public int MinimizeMax(int[] nums, int p)
    {
        Array.Sort(nums);
        int left = 0, right = nums[^1] - nums[0];
        while (left < right)
        {
            int mid = (right + left) / 2;
            int r = CountPairs(nums, mid);
            if (r >= p)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }
    int CountPairs(int[] nums, int diff)
    {
        int result = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i + 1] - nums[i] <= diff)
            {
                result++;
                i++;
            }
        }
        return result;
    }
}
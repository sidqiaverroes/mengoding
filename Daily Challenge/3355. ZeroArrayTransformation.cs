//3355. Zero Array Transformation I
//20 May 2025

public class Solution
{
    public bool IsZeroArray(int[] nums, int[][] queries)
    {
        int[] DiffArr = new int[nums.Length];
        DiffArr[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            DiffArr[i] = nums[i] - nums[i - 1];
        }

        for (int i = 0; i < queries.Length; i++)
        {
            int start = queries[i][0];
            int end = queries[i][1] + 1;

            DiffArr[start]--;
            if (end < DiffArr.Length) DiffArr[end]++;
        }

        nums[0] = DiffArr[0];
        if (nums[0] > 0) return false;
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] = nums[i - 1] + DiffArr[i];
            if (nums[i] > 0) return false;
        }

        return true;
    }
}
//2966. Divide Array Into Arrays With Max Difference
//18 June 2025

public class Solution
{
    public int[][] DivideArray(int[] nums, int k)
    {
        Array.Sort(nums);

        int n = nums.Length;

        int[][] res = new int[n / 3][];

        int resIndex = 0;
        for (int i = 0; i < n; i++)
        {
            if ((i + 1) % 3 == 0)
            {
                res[resIndex] = new int[3];
                res[resIndex][0] = nums[i - 2];
                res[resIndex][1] = nums[i - 1];
                res[resIndex][2] = nums[i];

                int gap1 = (res[resIndex][1] - res[resIndex][0]);
                int gap2 = (res[resIndex][2] - res[resIndex][1]);
                int gap3 = (res[resIndex][2] - res[resIndex][0]);

                if (gap1 > k || gap2 > k || gap3 > k) return [];

                resIndex++;
            }
        }

        return res;
    }
}
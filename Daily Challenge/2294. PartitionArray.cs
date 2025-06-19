//2294. Partition Array Such That Maximum Difference Is K
//19 June 2025
public class Solution
{
    public int PartitionArray(int[] nums, int k)
    {
        Array.Sort(nums);

        int Min = nums[0];
        int res = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] - Min > k)
            {
                Min = nums[i];
                res++;
            }
        }

        return res + 1;
    }
}
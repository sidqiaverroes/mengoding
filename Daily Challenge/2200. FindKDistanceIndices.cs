//2200. Find All K-Distant Indices in an Array
//25 June 2025

public class Solution
{
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        var res = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == key && Math.Abs(i - j) <= k)
                {
                    res.Add(i);
                    break;
                }
            }
        }

        return res;
    }
}
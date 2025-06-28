//2099. Find Subsequence of Length K With the Largest Sum
//28 June 2025

public class Solution
{
    public int[] MaxSubsequence(int[] nums, int k)
    {
        List<int> list = new List<int>(nums);
        int n = nums.Length - k;

        for (int i = 0; i < n; i++)
        {
            list.RemoveAt(list.IndexOf(list.Min()));
        }

        return list.ToArray();
    }
}
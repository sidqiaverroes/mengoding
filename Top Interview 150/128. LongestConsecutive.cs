//128. Longest Consecutive Sequence
//25 June 2025

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);

        int maxLength = 0;
        foreach (var n in set)
        {
            if (!set.Contains(n - 1))
            {
                int count = 1;
                int current = n;

                while (set.Contains(current + 1))
                {
                    current++;
                    count++;
                }

                maxLength = Math.Max(maxLength, count);
            }
        }

        return maxLength;
    }
}
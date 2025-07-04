//3307. Find the K-th Character in String Game II
//4 July 2025

public class Solution
{
    public char KthCharacter(long k, int[] operations)
    {
        int n = operations.Length;
        long[] lengths = new long[n + 1];
        lengths[0] = 1;
        for (int i = 0; i < n; i++)
        {
            lengths[i + 1] = lengths[i] * 2;
            if (lengths[i + 1] > k)
            {
                lengths[i + 1] = k;
            }
        }

        int shift = 0;
        for (int i = n - 1; i >= 0; i--)
        {
            long half = lengths[i];
            if (k > half)
            {
                k -= half;
                if (operations[i] == 1)
                {
                    shift++;
                }
            }
        }
        char result = (char)('a' + (shift % 26));
        return result;
    }
}
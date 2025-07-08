//1751. Maximum Number of Events That Can Be Attended II
//8 July 2025

class Solution
{
    public int MaxValue(int[][] events, int k)
    {
        Array.Sort(events, (a, b) => a[0] - b[0]);
        int n = events.Length;
        int[] next = new int[n];

        for (int i = 0; i < n; ++i)
        {
            int l = i + 1, r = n;
            while (l < r)
            {
                int m = (l + r) / 2;
                if (events[m][0] > events[i][1]) r = m;
                else l = m + 1;
            }
            next[i] = l;
        }

        int[] prev = new int[n + 1];
        for (int j = 1; j <= k; ++j)
        {
            int[] curr = new int[n + 1];
            for (int i = n - 1; i >= 0; --i)
            {
                curr[i] = Math.Max(curr[i + 1], events[i][2] + (next[i] < n ? prev[next[i]] : 0));
            }
            prev = curr;
        }

        return prev[0];
    }
}
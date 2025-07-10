//3440. Reschedule Meetings for Maximum Free Time II
//10 July 2025

public class Solution
{
    public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime)
    {
        int n = startTime.Length;
        int res = 0;

        int[] gaps = new int[n + 1];
        int lastEnd = 0;
        for (int i = 0; i < n; i++)
        {
            gaps[i] = startTime[i] - lastEnd;
            lastEnd = endTime[i];
        }
        gaps[n] = eventTime - lastEnd;

        int[] maxRight = new int[n + 1];
        for (int i = n - 1; i >= 0; i--)
            maxRight[i] = Math.Max(maxRight[i + 1], gaps[i + 1]);

        int maxLeft = 0;
        for (int i = 1; i <= n; i++)
        {
            int dur = endTime[i - 1] - startTime[i - 1];
            if (maxLeft >= dur || maxRight[i] >= dur)
                res = Math.Max(res, gaps[i - 1] + dur + gaps[i]);

            res = Math.Max(res, gaps[i - 1] + gaps[i]);
            maxLeft = Math.Max(maxLeft, gaps[i - 1]);
        }

        return res;
    }
}
//3439. Reschedule Meetings for Maximum Free Time I
//9 July 2025

public class Solution
{
    public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime)
    {
        int n = startTime.Length;
        int[] gap = new int[n + 1];

        //calculate gaps
        //start
        gap[0] = startTime[0];
        //mid
        for (int i = 1; i < n; i++)
        {
            gap[i] = startTime[i] - endTime[i - 1];
        }
        //end
        gap[n] = eventTime - endTime[n - 1];

        int max = 0, sum = 0;
        for (int i = 0; i <= n && i <= k; i++)
        {
            sum += gap[i];
        }
        max = Math.Max(max, sum);

        int l = 0, r = k;
        while (r < n)
        {
            sum -= gap[l++];
            sum += gap[++r];
            max = Math.Max(max, sum);
        }

        return max;
    }
}
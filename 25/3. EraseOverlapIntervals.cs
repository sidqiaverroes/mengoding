//leetcode 435. Non-overlapping Intervals

public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (x, y) => x[1].CompareTo(y[1]));
        
        int res = -1;

        int[] lastInterval = intervals[0];

        for(int i=0; i<intervals.Length; i++)
        {
            if(intervals[i][0] < lastInterval[1]) res++;
            else lastInterval = intervals[i];
        }

        return res;
    }
}
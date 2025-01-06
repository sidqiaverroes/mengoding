//leetcode 57. Insert Interval

public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> Result = [];
        int[] temp = newInterval; //store merging interval
        bool IsInserted = false;

        for(int i=0; i<intervals.Length; i++)
        {
            //overlapping
            if(temp[0] <= intervals[i][1] && temp[1] >= intervals[i][0])
            {
                temp = MergeInterval(temp, intervals[i]);
            }
            //not overlapping
            else
            {
                //if newInterval's location found add to result
                if(temp[1] < intervals[i][0] && !IsInserted)
                {
                    Result.Add(temp);
                    IsInserted = true;
                }

                Result.Add(intervals[i]);
            }
        }

        if(!IsInserted)
        {
            Result.Add(temp);
        }

        return Result.ToArray();
    }

    private int[] MergeInterval(int[] first, int[] second)
    {
        int start = Math.Min(first[0], second[0]);
        int end = Math.Max(first[1], second[1]);

        return [start, end];
    }
}
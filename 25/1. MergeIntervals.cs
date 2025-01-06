//leetcode 56. Merge Intervals

public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

        List<int[]> Result = [];
        int[] temp = intervals[0]; //store current merged interval

        for(int i=1; i<intervals.Length; i++)
        {
            if(intervals[i][0] <= temp[1]) //the i-th intervals is overlapping with temp
            {
                int end = intervals[i][1] > temp[1] ? intervals[i][1] : temp[1];
                temp[1] = end;
            }
            else // if not add temp and assign value of i-th intervals
            {
                Result.Add(temp);
                temp = intervals[i];
            }
        }
        //make sure add the last merged interval
        Result.Add(temp);

        return Result.ToArray();
    }
}
//leetcode 986. Interval List Intersections

public class Solution {
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList) {
        if(firstList.Length == 0 || secondList.Length == 0) return [];

        List<int[]> ans = [];

        int i = 0; // first index
        int j = 0; // second index

        while(i<firstList.Length && j<secondList.Length)
        {
            //if overlapping
            if(firstList[i][0] <= secondList[j][1] && firstList[i][1] >= secondList[j][0])
            {
                int start = Math.Max(firstList[i][0], secondList[j][0]);
                int end = Math.Min(firstList[i][1], secondList[j][1]);
                ans.Add([start,end]);
            }

            //move index
            if(firstList[i][1] < secondList[j][1]) i++;
            else j++;
        }

        return ans.ToArray();
    }
}
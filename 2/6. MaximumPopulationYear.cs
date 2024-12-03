//leetcode 1854: Maximum Population Year

public class Solution {
    public int MaximumPopulation(int[][] logs) {
        int pop = 0;
        int maxPop = 0;
        Dictionary<int,int> popDict = [];

        for(int i=1950; i<2051; i++)
        {
            int birthThisYear = 0;
            int deathThisYear = 0;

            for(int j=0; j<logs.Length; j++)
            {
                if(logs[j][0] <= i) birthThisYear++;
                if(logs[j][1] <= i) deathThisYear++;
            }

            int thisYearPop = birthThisYear - deathThisYear;
            if(!popDict.ContainsKey(thisYearPop)) popDict.Add(thisYearPop, i);
        }

        foreach(KeyValuePair<int,int> ele in popDict)
        {
            if(ele.Key > maxPop) maxPop = ele.Key;
        }

        return popDict[maxPop];

        // Dictionary<int, int> years = [];
        // int population = 0;
        // int maxPop = 0;
        // List<int> maxYears = [];

        // for(int i=0; i<logs.Length; i++)
        // {
        //     if(!years.ContainsKey(logs[i][0])) years.Add(logs[i][0], 1);
        //     if(!years.ContainsKey(logs[i][1])) years.Add(logs[i][1], 0);
        // }

        // var sorted = years.OrderBy(x => x.Key).ToList();

        // foreach(KeyValuePair<int,int> s in sorted)
        // {
        //     if(s.Value == 1)
        //     {
        //         population++;
        //         if(population > maxPop)
        //         {
        //             maxPop++;
        //             maxYears.Clear();
        //             maxYears.Add(s.Key);
        //         }
        //         else if(population == maxPop)
        //         {
        //             maxYears.Add(s.Key);
        //         }
        //     }
        //     else
        //     {
        //         population--;
        //     }
        // }
        // return maxYears[0];
    }
}
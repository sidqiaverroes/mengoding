//leetcode 118. Pascal's Triangle

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> list = [];
        
        for(int i=0; i<numRows; i++)
        {
            IList<int> row = [];
            row.Add(1);
            for(int j=1; j<i; j++)
            {
                int sum = list[i-1][j-1] + list[i-1][j];
                row.Add(sum);
            }
            if(i!=0) row.Add(1);
            list.Add(row);
        }

        return list;
    }
}
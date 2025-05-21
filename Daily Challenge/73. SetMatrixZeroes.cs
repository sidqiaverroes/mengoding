//73. Set Matrix Zeroes
//21 May 2025

public class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        int m = matrix.Length; //row
        int n = matrix[0].Length; //col

        HashSet<int> RowToSet = [];
        HashSet<int> ColToSet = [];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int x = matrix[i][j];
                if (x == 0)
                {
                    RowToSet.Add(i);
                    ColToSet.Add(j);
                }
            }
        }

        foreach (var row in RowToSet)
        {
            for (int i = 0; i < n; i++)
            {
                matrix[row][i] = 0;
            }
        }

        foreach (var col in ColToSet)
        {
            for (int i = 0; i < m; i++)
            {
                matrix[i][col] = 0;
            }
        }
    }
}
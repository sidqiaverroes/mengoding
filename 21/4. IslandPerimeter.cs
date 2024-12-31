//leetcode 463. Island Perimeter

public class Solution {
    public int IslandPerimeter(int[][] grid) {
        if(grid.Length == 0) return 0;

        int m = grid.Length; //row length
        int n = grid[0].Length; //col length

        int y = 0; //row index (y axis), to move vertically
        int x = 0; //col index (x axis), to move horizontally

        //find the first land
        for(int i=0; i<m; i++)
        {
            for(int j=0; j<n; j++)
            {
                if(grid[i][j] == 1)
                {
                    y = i;
                    x = j;
                    break;
                }
            }
        }

        int res = 0;
        res = Perimeter(grid, y, x, m, n, res);

        return res;
    }

    private int Perimeter(int[][] grid, int y, int x, int m, int n, int count)
    {
        int val = grid[y][x];
        if(val == 1) grid[y][x] = 2;
        else
        {
            if(val == 0) count++;
            return count;
        }

        //down
        if(y+1 < m)
        {
            count = Perimeter(grid, y+1, x, m, n, count);
        }
        else count++;
        //right
        if(x+1 < n)
        {
            count = Perimeter(grid, y, x+1, m, n, count);
        }
        else count++;
        //up
        if(y-1 >= 0)
        {
            count = Perimeter(grid, y-1, x, m, n, count);
        }
        else count++;
        //left
        if(x-1 >= 0)
        {
            count = Perimeter(grid, y, x-1, m, n, count);
        }
        else count++;

        return count;
    }
}
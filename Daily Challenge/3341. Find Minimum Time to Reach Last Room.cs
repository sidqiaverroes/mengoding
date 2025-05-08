// 3341. Find Minimum Time to Reach Last Room I

public class Solution {
    public int[][] directions = new int[][] {new int[2]{0,1}, new int[2] {0,-1}, new int[2] {1,0}, new int[2] {-1,0}};

    public int MinTimeToReach(int[][] moveTime) {
        int m = moveTime.Length, n = moveTime[0].Length;
        int[][] dp = new int[m][];
        for(int i=0; i<m; i++) dp[i] = new int[n];

        PriorityQueue<(int, int), int> qu = new();
        qu.Enqueue((0,0), moveTime[0][0]);

        while(qu.Count>0){
            var (r,c) = qu.Dequeue();
            if (r==m-1 && c ==n-1) break;
            foreach (var el in directions)
            {
                var newR = r + el[0];
                var newC = c + el[1];
                if (newR>=0 && newR < m && newC >= 0 && newC < n && dp[newR][newC]==0)
                {
                    int time = Math.Max(moveTime[newR][newC] + 1, dp[r][c] + 1);
                    dp[newR][newC] = time;
                    qu.Enqueue((newR,newC), time);
                }
            }
        }
        return dp[m-1][n-1];
    }
}

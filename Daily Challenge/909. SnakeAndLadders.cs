//909. Snakes and Ladders
//31 May 2025

public class Solution {
    public int SnakesAndLadders(int[][] board) {
        int n = board.Length;

        int[] min_rolls = Enumerable.Repeat(-1, n*n+1).ToArray();
        min_rolls[1] = 0;

        Queue q = new Queue();
        q.Enqueue(1);

        while(q.Count != 0)
        {
            int x = (int)q.Dequeue();
            for(int i=1; i<=6 && x+i <= n*n; i++)
            {
                int t = x+i, row = (t-1)/n, col = (t-1)%n; //target
                int v = board[n-1-row][(row%2 == 1) ? (n-1-col) : col]; //value
                int y = v > 0 ? v : t; //next coordinate

                if(y == n*n) return min_rolls[x] + 1;

                if(min_rolls[y] == -1)
                {
                    min_rolls[y] = min_rolls[x] + 1;
                    q.Enqueue(y);
                }
            }
        }

        return -1;
    }
}
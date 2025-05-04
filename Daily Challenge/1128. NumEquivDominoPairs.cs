//1128. Number of Equivalent Domino Pairs
//4 May 2025

public class Solution {
    public int NumEquivDominoPairs(int[][] dominoes) {
        Dictionary<(int,int), int> seenDominoes = [];
        int res = 0;

        for(int i=0; i<dominoes.Length; i++)
        {
            int a = Math.Min(dominoes[i][0], dominoes[i][1]);
            int b = Math.Max(dominoes[i][0], dominoes[i][1]);
            var key = (a, b);

            if(seenDominoes.ContainsKey(key))
            {
                res += seenDominoes[key]++;
            }
            else
            {
                seenDominoes.Add(key, 1);
            }
        }

        return res;
    }
}
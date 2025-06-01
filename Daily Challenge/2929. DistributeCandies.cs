//2929. Distribute Candies Among Children II
//1 June 2025

public class Solution {
    public long DistributeCandies(int n, int limit) {
        long res = 0;
        for(int a = Math.Max(0, n-2*limit); a <= Math.Min(n, limit); a++)
        {
            int b = Math.Min(limit, n-a) - Math.Max(0, n-a-limit) + 1;
            res += Math.Max(0, b);
        }

        return res;
    }
}
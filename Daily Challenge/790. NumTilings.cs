//790. Domino and Tromino Tiling
//5 May 2025

public class Solution {
    public int NumTilings(int n) {
        //A[N] = A[N-1] * 2 + A[N-3]
        const int MOD = 1_000_000_007;

        if (n == 0) return 0;
        if (n == 1) return 1;
        if (n == 2) return 2;
        if (n == 3) return 5;

        long a = 1; // dp[1]
        long b = 2; // dp[2]
        long c = 5; // dp[3]

        for (int i = 4; i <= n; i++) {
            long temp = (2 * c % MOD + a) % MOD;
            a = b;
            b = c;
            c = temp;
        }

        return (int)c;
    }
}

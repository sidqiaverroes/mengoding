//3405. Count the Number of Arrays with K Matching Adjacent Elements
//17 June 2025

public class Solution
{
    const int MOD = 1_000_000_007;
    const int MX = 100000;
    static long[] fact = new long[MX];
    static long[] invFact = new long[MX];

    long qpow(long x, int n)
    {
        long res = 1;
        while (n > 0)
        {
            if ((n & 1) == 1)
            {
                res = res * x % MOD;
            }
            x = x * x % MOD;
            n >>= 1;
        }
        return res;
    }

    void init()
    {
        if (fact[0] != 0)
        {
            return;
        }
        fact[0] = 1;
        for (int i = 1; i < MX; i++)
        {
            fact[i] = fact[i - 1] * i % MOD;
        }
        invFact[MX - 1] = qpow(fact[MX - 1], MOD - 2);
        for (int i = MX - 1; i > 0; i--)
        {
            invFact[i - 1] = invFact[i] * i % MOD;
        }
    }

    long comb(int n, int m)
    {
        return fact[n] * invFact[m] % MOD * invFact[n - m] % MOD;
    }

    public int CountGoodArrays(int n, int m, int k)
    {
        init();
        return (int)(comb(n - 1, k) * m % MOD * qpow(m - 1, n - k - 1) % MOD);
    }
}
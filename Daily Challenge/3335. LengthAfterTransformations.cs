//3335. Total Characters in String After Transformations I
//13 May 2025

public class Solution {
    public int LengthAfterTransformations(string s, int t) {
        const int MOD = 1_000_000_007;

        long[] freq = new long[26]; //0 = a, 25 = z

        foreach(var c in s)
        {
            int index = c - 'a';
            freq[index]++;
        }

        for(int i=0; i<t; i++)
        {
            long last = freq[25];
            for(int j=25; j>0; j--)
            {
                freq[j] = freq[j-1]%MOD;
            }
            freq[0] = last%MOD;
            freq[1] += last%MOD;
        }

        long res = 0;

        foreach(var f in freq)
        {
            res = (res + (f % MOD)) % MOD;
        }

        return (int)res;
    }
}
//leetcode 338. Counting Bits

public class Solution {
    public int[] CountBits(int n) {
        List<int> res = [];
        res.Add(0);

        int Offset = 1;

        for(int i=1; i<=n; i++)
        {
            if(i == Offset*2)
            {
                Offset = i;
            }

            res.Add(1 + res[i-Offset]);
        }

        return res.ToArray();

        // 0, 
        // 1, 
        // 1, 2, 
        // 1, 2, 2, 3, 
        // 1, 2, 2, 3, 2, 3, 3, 4, 1, 2, 2, 3, 2, 3, 3, 4, 2, 3, 3, 4, 3, 4, 4, 5
        //                        
        
        // 0 --> 0 = 0
        // 1 --> 1 = 1
        // --
        // 2 --> 10 = 1
        // 3 --> 11 = 2
        // --
        // 4 --> 100 = 1
        // 5 --> 101 = 2
        // 6 --> 110 = 2
        // 7 --> 111 = 3
        // --
        // 8 --> 1000 = 1
        // 9 --> 1001 = 2
        // 10 --> 1010 = 2
        // 11 --> 1011 = 3
        // 12 --> 1100 = 2
        // 13 --> 1101 = 3
        // 14 --> 1110 = 3
        // 15 --> 1111 = 4
        // --
        // 16 --> 10000 = 1
        // 17 --> 10001 = 2
        // 18 --> 10010 = 2
        // 19 --> 10011 = 3
        // 20 --> 10100 = 2
        // 21 --> 10101 = 3
        // 22 --> 10110 = 3
        // 23 --> 10111 = 4
        // 24 --> 11000 = 2
        // 25 --> 11001 = 3
        // 26 --> 11010 = 3
        // 27 --> 11011 = 4
        // 28 --> 11100 = 3
        // 29 --> 11101 = 4
        // 30 --> 11110 = 4
        // 31 --> 11111 = 5
        // -- 
        // 32 --> 100000 = 1
        // 33 --> 100001 = 2
        // 34 --> 100010 = 2
        // 35 --> 100011 = 3
        // 36 --> 100100 = 2
        // 37 --> 100101 = 3
        // 38 --> 100110 = 3
        // 39 --> 100111 = 4
        // 40 --> 101000 = 2
        // 41 --> 101001 = 3
        // 42 --> 101010 = 3
        // 43 --> 101011 = 4
        // 44 --> 101100 = 3
        // 45 --> 101101 = 4
        // 46 --> 101110 = 4
        // 47 --> 101111 = 5
        // 48 --> 110000 = 2
        // 49 -->
        // 50 -->
    }
}

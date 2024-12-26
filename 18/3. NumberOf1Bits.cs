// leetcode 191. Number of 1 Bits

public class Solution {
    public int HammingWeight(int n) {
        //This solution came up after i watched youtube video about hamming weight
        int res = 0;

        while(n!=0)
        {
            // a new thing that i get is the binary operation '&' and bit manipulation 
            n = n & (n-1);
            res++;
        }

        return res;
    }

    //this will have constant O(32) bcs int is 32 bit
}
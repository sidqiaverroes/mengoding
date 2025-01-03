//leetcode 461. Hamming Distance

public class Solution {
    public int HammingDistance(int x, int y) {
        int z = x^y;

        int count = 0;
        while(z!=0)
        {
            if(z%2==1)
            {
                count++;
            }

            z >>= 1;
        }

        return count;
    }
}
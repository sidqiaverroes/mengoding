//leetcode 70. Climbing Stairs

public class Solution {
    public int ClimbStairs(int n) {
        if(n == 0) return 0;
        if(n == 1) return 1;
        if(n == 2) return 2;
        if(n == 3) return 3;
        
        int prev = 2;
        int curr = 3;

        for(int i=4; i<=n; i++)
        {
            int temp = curr;
            curr += prev;
            prev = temp;
        }

        return curr;
    }
}
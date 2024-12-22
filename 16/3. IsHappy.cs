//leetcode 202. Happy Number

public class Solution {
    public bool IsHappy(int n) {
        if(n < 9)
        {
            if(n==1 || n==7) return true;
            else return false;
        }

        int res = 0;
        while(n>0)
        {
            res += (n%10) * (n%10);
            n = n/10;
        };

        return IsHappy(res);
    }
}
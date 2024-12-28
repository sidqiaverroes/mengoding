// leetcode 367. Valid Perfect Square

public class Solution {
    public bool IsPerfectSquare(int num) {
        if(num == 0 || num == 1) return true;
        if(num == 2 || num == 3) return false;
        
        int l = 0;
        int r = 46340;

        if(r*r == num) return true;

        while(l<=r)
        {
            int mid = l + (r-l)/2;
            int sqr = mid*mid;

            if(sqr == num) return true;

            if(sqr > num)
            {
                r = mid-1;
            }

            if(sqr < num)
            {
                l = mid+1;
            }
        }

        return false;
    }
}
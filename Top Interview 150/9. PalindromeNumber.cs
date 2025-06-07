//9. Palindrome Number
//7 June 2025

public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0) return false;

        int div = 1;
        while(x >= 10 * div && div < 100000001)
        {
            div *= 10;
        }

        while(x>0)
        {
            int right = x%10;
            int left = x/div;

            if(left != right) return false;

            x = x%div;
            x = x/10;
            div = div/100;
        }

        return true;
    }
}
//leetcode 258. Add Digits

public class Solution {
    public int AddDigits(int num) {
        if(num < 10) return num;

        int res = 0;
        while(num > 0)
        {
            res += num%10;
            num = num/10;
        }

        return AddDigits(res);
    }
}
//leetcode 69. Sqrt(x)

//Brute Force
public class Solution {
    public int MySqrt(int x) {
        int i = 0;
        while(i*i <= x && i <= 46340)
        {
            i++;
        }

        return i-1;
    }
}

//Binary Search
public class Solution {
    public int MySqrt(int x) {
        if(x == 0) return 0;

        int left = 1;
        int right = x;

        while(left <= right)
        {
            int mid = left + (right-left) / 2;
            int sqrt = x/mid;

            if(sqrt == mid) return mid;
            else if(sqrt < mid) // the mid is too high
            {
                right = mid-1;
            }
            else // the mid is too low
            {
                left = mid+1;
            }
        }

        return right;
    }
}
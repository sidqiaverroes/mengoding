//2918. Minimum Equal Sum of Two Arrays After Replacing Zeros
//10 May 2025

public class Solution {
    public long MinSum(int[] nums1, int[] nums2) {
        long sum1 = 0, sum2 = 0;
        long zero1 = 0, zero2 = 0;

        foreach (int i in nums1)
        {
            sum1 += i;
            if (i == 0)
            {
                sum1++;
                zero1++;
            }
        }

        foreach (int i in nums2)
        {
            sum2 += i;
            if (i == 0)
            {
                sum2++;
                zero2++;
            }
        }

        if ((zero1 == 0 && sum2 > sum1) || (zero2 == 0 && sum1 > sum2))
        {
            return -1;
        }

        return Math.Max(sum1, sum2);
    }
}
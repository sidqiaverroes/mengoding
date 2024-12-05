//leetcode 1588: Sum of All Odd Length Subarrays

public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        //My origin solution
        int n = arr.Length;
        int res = 0;
        int step = 0;

        while(step<n)
        {
            int l = 0;
            while(l<n-step)
            {
                int r=l+step;
                for(int j=l; j<=r; j++)
                {
                    res += arr[j];
                }
                l++;
            }
            step+=2;
        }
        
        return res;
    }
}
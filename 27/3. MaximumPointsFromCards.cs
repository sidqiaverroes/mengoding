//leetcode 1423. Maximum Points You Can Obtain from Cards

public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
        int ans = int.MinValue;
        int n = cardPoints.Length;
        int lSum = 0, rSum = 0;

        //sum k indices array from the right
        for(int i=n-k; i<n; i++)
        {
            rSum += cardPoints[i];
        }
        
        ans = Math.Max(ans, rSum);

        //move window (window is a sub array that not summed) to the right
        for(int i=0; i<k; i++)
        {
            lSum += cardPoints[i];
            rSum -= cardPoints[n-k+i];
            int sum = lSum + rSum;
            ans = Math.Max(ans, sum);
        }

        return ans;
    }
}
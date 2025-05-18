//122. Best Time to Buy and Sell Stock II
//18 May 2025

public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int start = prices[0];
        
        for(int i=0; i<prices.Length; i++)
        {
            if(start<prices[i])
            {
                maxProfit+= prices[i]-start;
            }
            start = prices[i];
        }

        return maxProfit;
    }
}
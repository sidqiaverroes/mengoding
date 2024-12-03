//leetcode: Best Time to Buy and Sell Stock Solution
public class Solution {
    public int MaxProfit(int[] prices) {
        int result = 0;

        int lowPrice = prices[0];
        int highPrice = prices[0];
        
        for(int i = 0; i < prices.Length; i++)
        {
            if(prices[i] < lowPrice)
            {
                lowPrice = prices[i];
                highPrice = 0;
            }
            else if(prices[i] > highPrice)
            {
                highPrice = prices[i];
                int gap = highPrice - lowPrice;
                if(result < gap) result = gap;
            }
        }

        return result;
    }
}
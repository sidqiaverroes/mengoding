//leetcode 11. Container With Most Water

public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;

        int i = 0;
        int j = height.Length-1;

        while(i<j)
        {
            int y = Math.Min(height[i], height[j]);
            int x = j - i;
            int area = x*y;
            maxArea = Math.Max(maxArea, area);

            if(height[i] < height[j]) i++;
            else j--;
        }

        return maxArea;
    }
}
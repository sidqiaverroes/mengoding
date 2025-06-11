//42. Trapping Rain Water
//11 June 2025

public class Solution {
    public int Trap(int[] height) {
        int left = 0, right = height.Length-1;
        int total = 0;

        int lmax = 0, rmax = 0;

        while(left<right)
        {
            if(height[left] <= height[right])
            {
                if(height[left] < lmax)
                {
                    total += lmax - height[left];
                }
                else lmax = height[left];

                left++;
            }
            else if(height[left] > height[right])
            {
                if(height[right] < rmax)
                {
                    total += rmax - height[right];
                }
                else rmax = height[right];

                right--;
            }
        }

        return total;
    }
}
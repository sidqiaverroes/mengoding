//75. Sort Colors
//17 May 2025

public class Solution {
    public void SortColors(int[] nums) {
        int[] colorMap = new int[3];

        for(int i=0; i<nums.Length; i++)
        {
            switch(nums[i])
            {
                case 0:
                    colorMap[0]++;
                    break;
                case 1: 
                    colorMap[1]++;
                    break;
                case 2:
                    colorMap[2]++;
                    break;
            }
        }

        int index = 0;
        int val = 0;
        foreach(var color in colorMap)
        {
            for(int i=0; i<color; i++)
            {
                nums[index] = val;
                index++;
            }
            val++;
        }
    }
}
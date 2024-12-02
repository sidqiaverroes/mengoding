//leetcode: Squares of Sorted Array

public class Solution {
    public int[] SortedSquares(int[] nums) {
        //My original solution
        // for(int i = 0; i < nums.Length ; i++)
        // {
        //     nums[i] = nums[i]*nums[i];
        // }

        // Array.Sort(nums);

        // return nums;

        //Alternative solution
        int n = nums.Length;
        int[] result = new int[n];
        int left = 0;
        int right = n-1;
        int index = n-1;

        while(left <= right)
        {
            int leftSquare = nums[left] * nums[left];
            int rightSquare = nums[right] * nums[right];

            if(leftSquare > rightSquare)
            {
                result[index] = leftSquare;
                left++;
            }
            else
            {
                result[index] = rightSquare;
                right--;
            }
            index--;
        }
        
        return result;
    }
}
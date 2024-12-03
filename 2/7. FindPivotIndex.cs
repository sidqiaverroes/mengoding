//leetcode 724: Find Pivot Index

public class Solution {
    public int PivotIndex(int[] nums) {

        for(int i=0; i<nums.Length; i++)
        {
            int sumRight = 0; 
            int sumLeft = 0;

            if(i != nums.Length)
            {
                for(int j=i+1; j<nums.Length; j++)
                {
                    sumRight += nums[j];
                }
            }

            if(i != 0)
            {
                for(int k=i-1; k>=0; k--)
                {
                    sumLeft += nums[k];
                }
            }
            
            if(sumRight == sumLeft) return i;
        }

        return -1;

        // int leftSum = 0;
        // int rightSum = 0;

        // int l = 0;
        // int r = nums.Length-1;

        // int ans = -1;

        // if(nums[l] > nums[r])
        // {
        //     rightSum += nums[r];
        //     r--;
        // }
        // else
        // {
        //     leftSum += nums[l];
        //     l++;
        // }

        // while(l<r && leftSum != rightSum)
        // {
        //     if(leftSum > rightSum)
        //     {
        //         rightSum += nums[r];
        //         r--;
        //     }
        //     else
        //     {
        //         leftSum += nums[l];
        //         l++;
        //     }

        //     if(leftSum == rightSum)
        //     {
        //         ans = l;
        //         break;
        //     }
        // }

        // return ans;
    }
}
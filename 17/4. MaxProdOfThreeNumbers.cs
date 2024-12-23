//leetcode 628. Maximum Product of Three Numbers

public class Solution {
    public int MaximumProduct(int[] nums) {
        Array.Sort(nums);

        int prod1 = nums[0] * nums[1] * nums[nums.Length-1];
        int prod2 = nums[nums.Length-1] * nums[nums.Length-2] * nums[nums.Length-3];
        
        return Math.Max(prod1, prod2);
    }
}

//Alternate faster but more LOC
public class Solution {
    public int MaximumProduct(int[] nums) {
        int Max1 = int.MinValue;
        int Max2 = int.MinValue;
        int Max3 = int.MinValue;
        int Min1 = int.MaxValue;
        int Min2 = int.MaxValue;

        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] > Max1)
            {
                Max3 = Max2;
                Max2 = Max1;
                Max1 = nums[i];
            }
            else if(nums[i] > Max2)
            {
                Max3 = Max2;
                Max2 = nums[i];
            }
            else if(nums[i] > Max3)
            {
                Max3 = nums[i];
            }

            if(nums[i] < Min1)
            {
                Min2 = Min1;
                Min1 = nums[i];
            }
            else if(nums[i] < Min2)
            {
                Min2 = nums[i];
            }
        }

        int Prod1 = Min1 * Min2 * Max1;
        int Prod2 = Max1 * Max2 * Max3;

        return Math.Max(Prod1, Prod2);
    }
    
}
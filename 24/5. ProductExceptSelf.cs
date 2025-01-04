//leetcode 238. Product of Array Except Self

public class Solution {
    
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n]; // Initializes all elements to 0 by default
        Array.Fill(result, 1);     // Fills the array with 1

        int currentPrefix = 1;
        int currentSuffix = 1;
        for(int i=0; i<n; i++)
        {
            result[i] = result[i] * currentPrefix;
            result[n-1-i] = result[n-1-i] * currentSuffix;

            currentPrefix = currentPrefix * nums[i];
            currentSuffix = currentSuffix * nums[n-1-i];
        }

        return result;
    }
}

// public int[] ProductExceptSelf(int[] nums) {
//         List<int> result = [];
//         result.Add(1);

//         //compute prefix
//         for(int i=1; i<nums.Length; i++)
//         {
//             result.Add(nums[i-1] * result[i-1]);
//         }

//         //compute suffix
//         int currentSuffix = 1;
//         for(int i=nums.Length-1; i>=0; i--)
//         {
//             result[i] = result[i] * currentSuffix;
//             currentSuffix = nums[i] * currentSuffix;
//         }

//         return result.ToArray();
//     }
//leetcode 268. Missing Number

public class Solution {
    //My initial solution, i think its O(2N)
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        int[] arr = new int[n+1];

        for(int i=0; i<n; i++)
        {
            arr[nums[i]] = 1;
        }

        for(int i=0; i<n; i++)
        {
            if(arr[i]==0) return i;
        }

        return n;
    }

    //Alternative using bit manipulation and XOR operation
    public int MissingNumber(int[] nums) {
        int res = nums.Length;

        for(int i=0; i<nums.Length; i++)
        {
            res = res^i^nums[i];
        }

        return res;
    }

    //Alternative using basic math
    public int MissingNumber(int[] nums) {
        int n = nums.Length+1;
        int Expected_Sum = n*(n-1)/2; //using formula S(n)

        int sum = 0;
        for(int i=0; i<n-1; i++)
        {
            sum += nums[i];
        }

        return Expected_Sum - sum;
    }
}
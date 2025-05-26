//45. Jump Game II
//25 May 2025

public class Solution {
    public int Jump(int[] nums) {
        int n = nums.Length;
        int[] minJumpsToEnd = new int[n];

        minJumpsToEnd[n-1] = 0;
        for(int i=n-2; i>=0; i--)
        {
            if(nums[i] == 0)
            {
                minJumpsToEnd[i] = int.MaxValue;
                continue;
            }
            minJumpsToEnd[i] = minJumpInRange(minJumpsToEnd, i+1, i+nums[i]);
        }

        return minJumpsToEnd[0];
    }

    private int minJumpInRange(int[] minJumpsToEnd, int start, int end)
    {
        if(end > minJumpsToEnd.Length-1) end = minJumpsToEnd.Length-1;
        int minJump = minJumpsToEnd[end];
        for(int i=start; i<=end; i++)
        {
            minJump = Math.Min(minJumpsToEnd[i], minJump);
        }

        return minJump == int.MaxValue ? minJump : minJump+1;
    }
}

// Optimal Solution
// public class Solution {
//     public int Jump(int[] nums) {
//         int jumps = 0;
//         int currentEnd = 0;
//         int farthest = 0;

//         for (int i = 0; i < nums.Length - 1; i++) {
//             farthest = Math.Max(farthest, i + nums[i]);

//             // If we've reached the end of the current jump range
//             if (i == currentEnd) {
//                 jumps++;
//                 currentEnd = farthest;
//             }
//             Console.WriteLine($"Jumps: {jumps}, currentEnd: {currentEnd}, farthest: {farthest}");
//         }

//         return jumps;
//     }
// }

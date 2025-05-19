//3024. Type of Triangle
//19 May 2025

public class Solution {
    public string TriangleType(int[] nums) {
        int firstSecond = nums[0] + nums[1];
        int firstThird = nums[0] + nums[2];
        int secondThird = nums[2] + nums[1];

        bool IsTriangle = (firstSecond > nums[2]) && (firstThird > nums[1]) && (secondThird > nums[0]);

        if(!IsTriangle) return "none";

        if(firstSecond == firstThird && 
            firstThird == secondThird && 
            firstSecond == secondThird) return "equilateral";
        
        if(firstSecond == firstThird ||
            firstThird == secondThird ||
            firstSecond == secondThird) return "isosceles";

        return "scalene";
    }
}
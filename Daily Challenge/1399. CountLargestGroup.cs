//1399. Count Largest Group
//23 April 2025

public class Solution {
    public int CountLargestGroup(int n) {
        int[] GroupMap = new int[36];

        int maxCount = 0;
        int count = 0;
        int x = 1;
        while(x<=n)
        {
            int sum = x;
            sum = DigitSum(sum);
            GroupMap[sum-1]++;

            if(maxCount < GroupMap[sum-1])
            {
                maxCount = GroupMap[sum-1];
                count = 1;
            }
            else if (GroupMap[sum-1] == maxCount) count++;

            x++;
        }

        return count;
    }

    private int DigitSum(int x)
    {
        int sum = 0;
        while(x>0)
        {
            sum += x%10;
            x /= 10;
        }

        return sum;
    }
}
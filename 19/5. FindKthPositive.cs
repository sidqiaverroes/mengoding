// leetcode 1539. Kth Missing Positive Number

public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        int count = 0;
        int i = 0;
        int n = 1;

        while(count < k)
        {
            if(i<arr.Length)
            {
                if(arr[i] == n)
                {
                    i++;
                }
                else
                {
                    count++;
                }
            }
            else
            {
                count++;
            }
            n++;
        }

        return n-1;
    }
}
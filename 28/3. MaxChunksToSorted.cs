//leetcode 769. Max Chunks To Make Sorted

public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        int chunk = 0;
        int max = arr[0];
        for(int i = 0; i<arr.Length; i++)
        {
            max = Math.Max(arr[i], max);            
            if(max == i) chunk++;
        }

        return chunk;
    }
}
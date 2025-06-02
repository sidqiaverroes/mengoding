//135. Candy
//2 June 2025

public class Solution {
    public int Candy(int[] ratings) {
        int[] arr = new int[ratings.Length];
        Array.Fill(arr,1);

        for(int i=1; i<ratings.Length; i++)
        {
            if(ratings[i] > ratings[i-1]) arr[i] = arr[i-1]+1;
        }

        for(int i=ratings.Length-2; i >= 0; i--)
        {
            if(ratings[i] > ratings[i+1]) arr[i] = Math.Max(arr[i], arr[i+1]+1);
        }

        int res = 0;
        foreach(var a in arr) res += a;

        return res;
    }
}
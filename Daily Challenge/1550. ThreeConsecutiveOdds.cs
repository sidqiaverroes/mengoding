//1550. Three Consecutive Odds
//11 May 2025

public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        int chain = 0;

        for(int i=0; i<arr.Length; i++)
        {
            if(arr[i]%2 != 0)
            {
                chain++;
                if(chain == 3) return true;
            }
            else chain = 0;
        }

        return false;
    }
}
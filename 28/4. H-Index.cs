//leetcode 274. H-Index

public class Solution {
    public int HIndex(int[] citations) {
        int[] countArray = new int [1001];

        for(int i=0; i<citations.Length; i++)
        {
            for(int j=0; j<=citations[i]; j++)
            {
                countArray[j]++;
            }
        }

        int res = 0;

        for(int i=0; i<countArray.Length; i++)
        {
            if(countArray[i]>=i) res = i;
        }

        return res;

    }
}
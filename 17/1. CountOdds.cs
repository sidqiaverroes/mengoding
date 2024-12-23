//leetcode 1523. Count Odd Numbers in an Interval Range

public class Solution {
    public int CountOdds(int low, int high) {
        int res = high-low;

        if(low%2==0 && high%2==0)
        {
            res=res;
        }
        else if(low%2!=0 && high%2!=0)
        {
            res+=2;
        }
        else
        {
            res+=1;
        }

        return res/2;

        //0 11 = 6 //11, 11 --> 11+1 / 2
        //1 11 = 6 //12, 10 --> 10+2 / 2
        //0 12 = 6 //12, 12 --> 12 / 2
        //1 12 = 6 //13, 11 --> 11+1 / 2

        //2 21 = 10 //23, 19 --> 19+1 / 2
        //3 21 = 10 //24, 18 --> 18+2 / 2
        //2 22 = 10 //24, 20 --> 20 / 2
        //3 22 = 10 //25, 19 --> 19+1 / 2
    }
}
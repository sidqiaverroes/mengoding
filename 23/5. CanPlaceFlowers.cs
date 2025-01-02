//leetcode 605. Can Place Flowers

public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        //my first solution
        if(n == 0) return true;

        if(flowerbed.Length == 1)
        {
            if(flowerbed[0] == 0) return n <= 1;
            else return false;
        }

        if(n > (flowerbed.Length/2)+1) return false;

        int countPlace = 0;
        HashSet<int> mappedIndices = [];

        for(int i=0; i<flowerbed.Length; i++)
        {
            if(flowerbed[i] == 0)
            {
                bool IsPlace = false;

                if(i == 0) 
                {
                    IsPlace = flowerbed[i+1] == 0 && !mappedIndices.Contains(i-1);
                }
                else if( i == flowerbed.Length-1) 
                {
                    IsPlace = flowerbed[i-1] == 0 && !mappedIndices.Contains(i-1);
                }
                else
                {
                    IsPlace = flowerbed[i-1] == 0 && flowerbed[i+1] == 0 && !mappedIndices.Contains(i-1);
                }

                if(IsPlace)
                {
                    countPlace++;
                    mappedIndices.Add(i);
                }
            }
        }

        return n <= countPlace;
    }

    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        //another approach
        int len = flowerbed.Length;

        for(int i=0; i<len; i++)
        {
            bool Left = i == 0 || flowerbed[i-1] == 0;
            bool Right = i == len-1 || flowerbed[i+1] == 0;

            if(Left && Right && flowerbed[i] == 0)
            {
                flowerbed[i] = 1;
                n--;
            }
        }

        return n <= 0;
    }
}
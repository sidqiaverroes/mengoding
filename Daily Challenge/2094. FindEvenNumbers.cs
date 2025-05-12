//2094. Finding 3-Digit Even Numbers
//12 May 2025

public class Solution {
    public int[] FindEvenNumbers(int[] digits) {
        
        Dictionary<int, int> digitCount = [];

        foreach(var d in digits)
        {
            if(!digitCount.ContainsKey(d)) digitCount.Add(d, 0);
            digitCount[d]++;
        }

        List<int> res = [];

        for(int i=100; i<1000; i++)
        {
            if(i%2!=0) continue;

            int third = i%10;
            int second = i/10%10;
            int first = i/100;

            Dictionary<int, int> map = [];

            if(digitCount.ContainsKey(first))
            {
                if(!map.ContainsKey(first)) map.Add(first, digitCount[first]);
            }
            else continue;

            if(digitCount.ContainsKey(second))
            {
                if(!map.ContainsKey(second)) map.Add(second, digitCount[second]);
            }
            else continue;

            if(digitCount.ContainsKey(third))
            {
                if(!map.ContainsKey(third)) map.Add(third, digitCount[third]);
            }
            else continue;

            if(map[first] != 0) map[first]--;
            else continue;
            if(map[second] != 0) map[second]--;
            else continue;
            if(map[third] != 0) map[third]--;
            else continue;

            res.Add(i);
        }

        return res.ToArray();
    }
}
//66. Plus One
//8 June 2025

using System.Collections.Generic;

public class Solution {
    public int[] PlusOne(int[] digits) {
        bool isTrue = false;
        var digits2 = new List<int>();

        for(int i = digits.Length-1; i >= 0; i--)
        {
            if(i == digits.Length-1)
            {
                if(digits[i] == 9)
                {
                    digits2.Add(0);
                    if(i == 0) digits2.Add(1);
                    isTrue = true;
                }   
                else digits2.Add(digits[i]+1);
            }
            else if(isTrue)
            {
                if(digits[i] == 9)
                {
                    digits2.Add(0);
                    if(i == 0) digits2.Add(1);
                    isTrue = true;
                }
                else
                {
                    digits2.Add(digits[i]+1);
                    isTrue = false;
                }
            }
            else
            {
                digits2.Add(digits[i]);
            }
        }
        var arr = digits2.ToArray();
        Array.Reverse(arr);
        return arr;
    }
}
//12. Integer to Roman
//29 May 2025

public class Solution {
    public string IntToRoman(int num) {
        List<string> ans = [];
        int n = num;
        int degree = 0;

        while(n>0)
        {
            int lastNum = n % 10;
            ans.Add(Convert(lastNum, degree));

            n = n/10;
            degree++;
        }

        ans.Reverse();

        return string.Join("", ans);
    }

    private string Convert(int n, int degree)
    {
        var Roman = new Dictionary <int, List<string>>()
        {
            {0, new List<string> (){"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"} },
            {1, new List<string> (){"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"} },
            {2, new List<string> (){"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"} },
            {3, new List<string> (){"", "M", "MM", "MMM"} }
        };

        return Roman[degree][n];
    }
}
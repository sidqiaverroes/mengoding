//leetcode 409. Longest Palindrome

public class Solution {
    public int LongestPalindrome(string s) {
        Dictionary<char, int> map = [];

        foreach(var a in s)
        {
            if(map.ContainsKey(a))
            {
                map[a]++;
            }
            else
            {
                map.Add(a, 1);
            }
        }

        int res = 0;
        bool IsOdd = false;

        foreach(KeyValuePair<char, int> kvp in map)
        {
            if(kvp.Value % 2 == 0) res += kvp.Value;
            else
            {
                res += kvp.Value - 1;
                IsOdd = true;
            }
        }

        return IsOdd ? res + 1 : res;
    }
}
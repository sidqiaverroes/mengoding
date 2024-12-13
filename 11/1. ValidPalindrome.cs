//leetcode 125. Valid Palindrome

using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        string sentence = string.Join("", Regex.Split(s.ToLower(), @"[^a-zA-Z0-9]+"));
        string[] words = sentence.ToCharArray().Select(c => c.ToString()).ToArray();

        int l = 0;
        int r = words.Length-1;

        while(l <= r)
        {
            if(words[l] != words[r])
            {
                return false;
            }

            l++;
            r--;
        }
        
        return true;
    }
}

//another aproach without regex
public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0;
        int r = s.Length-1;

        while(l < r)
        {
            while(l < r && !char.IsLetterOrDigit(s[l])) l++;
            while(l < r && !char.IsLetterOrDigit(s[r])) r--;

            if(char.ToLower(s[l]) != char.ToLower(s[r]))
            {
                return false;
            }

            l++;
            r--;
        }
        
        return true;
    }
}
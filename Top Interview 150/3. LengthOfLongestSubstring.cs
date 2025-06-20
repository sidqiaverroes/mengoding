//3. Longest Substring Without Repeating Characters
//20 June 2025

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> seen = new HashSet<char>();
        int left = 0, maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (seen.Contains(s[right]))
            {
                seen.Remove(s[left]);
                left++;
            }

            seen.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
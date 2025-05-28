//28. Find the Index of the First Occurrence in a String
//28 May 2025

public class Solution {
    public int StrStr(string haystack, string needle) {
        if(haystack.Length < needle.Length) return -1;
        for(int i=0; i<haystack.Length; i++)
        {
            if(haystack[i] == needle[0])
            {
                int j = 0;
                while(i+j < haystack.Length && j < needle.Length)
                {
                    if(haystack[i+j] != needle[j]) break;
                    j++;
                }
                if(j == needle.Length) return i;
            }
        }

        return -1;
    }
}
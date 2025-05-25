//2131. Longest Palindrome by Concatenating Two Letter Words
//25 may 2025

public class Solution {
    public int LongestPalindrome(string[] words) {
        Dictionary<string, int> wordCount = [];

        foreach(var w in words)
        {
            if(!wordCount.ContainsKey(w)) wordCount.Add(w, 0);
            wordCount[w]++;
        }

        int res = 0;
        int longestOddSameWordCount = 0;
        HashSet<string> addedWord = [];

        foreach(var kvp in wordCount)
        {
            //already added to the result
            if(addedWord.Contains(kvp.Key)) continue;

            //check if both chars in the word are the same
            bool IsSame = kvp.Key[0] == kvp.Key[1];
            if(IsSame)
            {
                if(kvp.Value%2==0)
                {
                    res += kvp.Value * 2;
                    addedWord.Add(kvp.Key);
                }
                else
                {
                    if(kvp.Value >= longestOddSameWordCount)
                    {
                        if(longestOddSameWordCount!=0) res += (longestOddSameWordCount - 1) * 2;
                        longestOddSameWordCount = kvp.Value;
                    }
                    else res += (kvp.Value - 1) * 2;
                    
                }
                continue;
            }   
            
            //process the word with different chars
            string currentWordReversed = $"{kvp.Key[1]}{kvp.Key[0]}";
            if(wordCount.ContainsKey(currentWordReversed))
            {
                res += Math.Min(kvp.Value, wordCount[currentWordReversed]) * 4;
                addedWord.Add(kvp.Key);
                addedWord.Add(currentWordReversed);   
            }
        }

        res += longestOddSameWordCount * 2;


        return res;
    }
}
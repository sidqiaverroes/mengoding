//3442. Maximum Difference Between Even and Odd Frequency I
//10 June 2025

public class Solution {
    public int MaxDifference(string s) {
        int[] freq = new int[26];
        Array.Fill(freq, int.MaxValue);
        int evenMin = int.MaxValue, oddMax = int.MinValue;

        foreach(char c in s){
            if(freq[c-'a'] == int.MaxValue) 
                freq[c-'a'] = 0;

            freq[c-'a']++;
        }

        for(int i=0; i<26; i++){
            if(freq[i] == int.MaxValue) continue;

            if((freq[i]&1) == 0){
                evenMin = Math.Min(evenMin, freq[i]);
            }
            else{
                oddMax = Math.Max(oddMax, freq[i]);
            }
        }


        return oddMax - evenMin;
    }
}
// Leetcode: 567. Permutation in String

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;

        Dictionary<char, int> s1Map = new Dictionary<char, int>(); //map the s1

        foreach(var s in s1)
        {
            if(!s1Map.ContainsKey(s))
            {
                s1Map[s] = 0;
            }
            s1Map[s]++;
        }

        //map the first window
        for(int i=0; i<s1.Length; i++)
        {
            if(s1Map.ContainsKey(s2[i]))
            {
                s1Map[s2[i]]--;
            }
        }

        if(IsValid(s1Map))
        {
            return true;
        }

        //move the window
        int left = 0;
        for(int i=s1.Length; i<s2.Length; i++)
        {
            //right edge of window
            if(s1Map.ContainsKey(s2[i]))
            {
                s1Map[s2[i]]--;
            }

            //left edge of window
            if(s1Map.ContainsKey(s2[left]))
            {
                s1Map[s2[left]]++;
            }
            
            if(IsValid(s1Map))
            {
                return true;
            }

            left++;
        }

        return false;
    }

    private bool IsValid(Dictionary<char, int> dict)
    {
        foreach(var d in dict)
        {
            if(d.Value > 0)
            {
                return false;
            }
        }
        
        return true;
    }
}
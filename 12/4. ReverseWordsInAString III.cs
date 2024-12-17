//leetcode 557. Reverse Words in a String III

public class Solution {
    public string ReverseWords(string s) {
        var arrWords = s.Split(" ");
        List<string> res = [];

        foreach(var word in arrWords)
        {  
            res.Add(ReverseString(word));
        }

        return string.Join(" ", res.ToArray());
    }

    private string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();

        int l = 0;
        int r = charArray.Length-1;

        while(l<r)
        {
            char temp = charArray[l];
            charArray[l] = charArray[r];
            charArray[r] = temp;

            l++;
            r--;
        }

        string res = new string(charArray);

        return res;
    }
}
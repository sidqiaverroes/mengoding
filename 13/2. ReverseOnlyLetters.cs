//leetcode 917. Reverse Only Letters

public class Solution {
    public string ReverseOnlyLetters(string s) {
        int l = 0;
        int r = s.Length-1;

        char[] charArray = s.ToCharArray();

        while(l<r)
        {
            while(!Char.IsLetter(charArray[l]) && l<r)
            {
                l++;
            }

            while(!Char.IsLetter(charArray[r]) && l<r)
            {
                r--;
            }

            char temp = charArray[l];
            charArray[l] = charArray[r];
            charArray[r] = temp;
            l++;
            r--;
        }

        return string.Join("", charArray);
    }
}
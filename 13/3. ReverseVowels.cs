//leetcode 345. Reverse Vowels of a String

public class Solution {
    public string ReverseVowels(string s) {
        List<char> vowels = new() {'a', 'i', 'u', 'e', 'o', 'A', 'I', 'U', 'E', 'O'};
        char[] charArray = s.ToCharArray();
        int l = 0;
        int r = s.Length-1;

        while(l<r)
        {
            while(l<r && !vowels.Any(v => v == charArray[l])) l++;
            while(l<r && !vowels.Any(v => v == charArray[r])) r--;

            char temp = charArray[l];
            charArray[l] = charArray[r];
            charArray[r] = temp;

            l++;
            r--;
        }

        return String.Join("", charArray);
    }
}
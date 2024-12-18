//leetcode 1047. Remove All Adjacent Duplicates In String

public class Solution {
    public string RemoveDuplicates(string s) {
        if(s.Length < 2) return s;

        if(s.Length == 2)
        {
            if(s[0] == s[1]) return "";
            else return s;
        }

        int index = 0;
        string myString = s;
        while(index < myString.Length-1)
        {
            if(myString[index] == myString[index+1])
            {
                myString = Remove(myString, index);
                index = 0;
            }
            else
            {
                index++;
            }
        }

        return myString;

    }

    private string Remove(string s, int index)
    {
        string res = s.Substring(0, index) + s.Substring(index+2);

        return res;
    }
}
//3403. Find the Lexicographically Largest String From the Box I
//4 June 2025

public class Solution {
    public string AnswerString(string word, int numFriends) {
        int range = word.Length - numFriends + 1;
        int left = 0;
        List<string> parts = [];

        while(left+range < word.Length)
        {
            string part = word.Substring(left, range);
            parts.Add(part);

            left++;
        }

        do {
            string lastPart = word.Substring(left);
            parts.Add(lastPart);
            left++;
        } while(left < word.Length && numFriends != 1);

        parts.Sort();

        return parts.Last();
    }
}
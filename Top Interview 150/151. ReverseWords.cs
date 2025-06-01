//151. Reverse Words in a String
//1 June 2025

public class Solution {
    public string ReverseWords(string s) {
        List<string> res = s.Split(new char[0], StringSplitOptions.RemoveEmptyEntries)
                                .Reverse().ToList<string>();

        return string.Join(" ", res);
    }
}
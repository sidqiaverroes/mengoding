//2434. Using a Robot to Print the Lexicographically Smallest String
//6 June 2025

public class Solution {
    public string RobotWithString(string s) {
        int n = s.Length;
        char[] sArray = s.ToCharArray();
        char[] minSuffix = new char[n];
        minSuffix[n - 1] = sArray[n - 1];
        for (int i = n - 2; i >= 0; i--) {
            minSuffix[i] = sArray[i] < minSuffix[i + 1] ? sArray[i] : minSuffix[i + 1];
        }
        Stack<char> stack = new Stack<char>();
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < n; i++) {
            stack.Push(sArray[i]);

            while (stack.Count > 0 && (i == n - 1 || stack.Peek() <= minSuffix[i + 1])) {
                result.Append(stack.Pop());
            }
        }
        while (stack.Count > 0) {
            result.Append(stack.Pop());
        }

        return result.ToString();
    }
}
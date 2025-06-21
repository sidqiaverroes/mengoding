//67. Add binary
//21 June 2025

public class Solution {
    public string AddBinary(string a, string b) {
        
        // Determine longer/shorter of the strings
        var longest = a.Length >= b.Length ? a : b;
        var shortest = a.Length < b.Length ? a : b;
        var longerLength = longest.Length;
        var shorterLength = shortest.Length;

        // Prepare output to longer of the strings prefixed by a possible leading '1'
        var resultChars = new char[longerLength + 1];
        resultChars[0] = '1';

        var carry = 0; // 1 if carried from previous digit, else 0
        var ones = 0; // count of '1' chars at this position, including any carried digits

        for(var i = 1; i <= longerLength; ++i) {
            ones = carry;

            ones += longest[^i] - '0';
            if(i <= shorterLength)
                ones += shortest[^i] - '0';

            resultChars[^i] = ones % 2 == 1 ? '1' : '0'; // straight odd/even determination
            carry = ones > 1 ? 1 : 0;
        }

        return new string(resultChars[(1-carry)..]);
    }
}
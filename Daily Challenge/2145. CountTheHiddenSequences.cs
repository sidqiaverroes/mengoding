//2145. Count the Hidden Sequences
//21 April 2025

public class Solution {
    public int NumberOfArrays(int[] differences, int lower, int upper) {
        long current = 0;
        long min = 0, max = 0;

        foreach (var diff in differences) {
            current += diff;
            min = Math.Min(min, current);
            max = Math.Max(max, current);
        }

        long availableRange = upper - lower;
        long requiredRange = max - min;

        long result = availableRange - requiredRange + 1;

        return result < 0 ? 0 : (int)result;
    }
}

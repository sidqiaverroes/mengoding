//1298. Maximum Candies You Can Get from Boxes
//3 June 2025

public class Solution {
    public int MaxCandies(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int[] initialBoxes) {
        int n = status.Length;
        int res = 0;

        bool[] hasBox = new bool[n];
        bool[] hasKey = new bool[n];
        bool[] opened = new bool[n];

        foreach (var box in initialBoxes) {
            hasBox[box] = true;
        }

        bool progress = true;

        while (progress) {
            progress = false;
            for (int i = 0; i < n; i++) {
                if (hasBox[i] && (status[i] == 1 || hasKey[i]) && !opened[i]) {
                    // Open box
                    opened[i] = true;
                    res += candies[i];
                    progress = true;

                    foreach (var k in keys[i]) {
                        hasKey[k] = true;
                    }

                    foreach (var cb in containedBoxes[i]) {
                        hasBox[cb] = true;
                    }
                }
            }
        }

        return res;
    }
}

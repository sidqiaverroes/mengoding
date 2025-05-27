//134. Gas Station
//27 May 2025

public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int totalTank = 0;
        int currentTank = 0;
        int startIndex = 0;

        for (int i = 0; i < gas.Length; i++) {
            int diff = gas[i] - cost[i];
            totalTank += diff;
            currentTank += diff;

            // If we can't reach station i+1 from the current start, move start forward
            if (currentTank < 0) {
                startIndex = i + 1;
                currentTank = 0;
            }
        }

        return totalTank >= 0 ? startIndex : -1;
    }
}
//781. Rabbits in Forest
//20 April 2025

public class Solution {
    public int NumRabbits(int[] answers) {
        Dictionary<int, int> GroupMap = []; //maps the Value with the number of Appearance <val, num>

        foreach(var ans in answers)
        {
            if(!GroupMap.ContainsKey(ans)) GroupMap[ans] = 0;
            GroupMap[ans]++;
        }

        int res = 0;
        foreach(KeyValuePair<int, int> ele in GroupMap)
        {
            if(ele.Key == 0) res+= ele.Value;
            else
            {
                int factor = ele.Key+1;

                int numOfGroup = ele.Value/factor;
                if(ele.Value%factor != 0) numOfGroup++;

                res += factor*numOfGroup;
                
            }
        }

        return res;
    }
}

// Rabbit Grouping Problem

// Explanation

// Remember, not all rabbits in the forest are answering.
// The minimum number of rabbits is not necessarily n (the number of answers).
// The question appears straightforward, but it's a little bit tricky.

// Hint

// Handle 0 differently from other elements.

// For other elements:
// Assume the array is:
// [2, 1, 2, 2, 2, 2, 2, 2, 1, 1]
// Count the occurrences:
// 2 occurs 7 times
// 1 occurs 3 times
// Use a grouping factor defined as element + 1.

// Example Calculation
// For 2:
// Grouping factor = 2 + 1 = 3
// Group into sets of 3: (2,2,2)(2,2,2)(2)
// So we need 3 groups ⇒ Answer = 3 * 3 = 9

// For 1:
// Grouping factor = 1 + 1 = 2
// Group into sets of 2: (1,1)(1)
// So we need 2 groups ⇒ Answer = 2 * 2 = 4

// Final Answer
// Total minimum number of rabbits = 9 (for 2s) + 4 (for 1s) = 13
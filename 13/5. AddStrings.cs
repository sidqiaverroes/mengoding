//leetcode 415. Add Strings

public class Solution {
    public string AddStrings(string num1, string num2) {
        Dictionary<char, int> numMap = new()
        {
            {'1', 1},
            {'2', 2},
            {'3', 3},
            {'4', 4},
            {'5', 5},
            {'6', 6},
            {'7', 7},
            {'8', 8},
            {'9', 9},
            {'0', 0},
        };

        List<int> res = [];
        char[] num1Array = num1.ToCharArray();
        char[] num2Array = num2.ToCharArray();

        int Index1 = num1Array.Length-1;
        int Index2 = num2Array.Length-1;

        int buffer = 0;

        while(true)
        {
            if(Index1 < 0 && Index2 <0 && buffer == 0) break;

            int addRes = 0;

            if(Index1 >= 0 && Index2 >= 0)
            {
                addRes = Add(numMap[num1Array[Index1]], numMap[num2Array[Index2]], buffer);
            }
            else if(Index1 < 0 && Index2 >=0)
            {
                addRes = Add(0, numMap[num2Array[Index2]], buffer);
            }
            else if(Index2 < 0 && Index1 >=0)
            {
                addRes = Add(numMap[num1Array[Index1]], 0, buffer);
            }
            else
            {
                addRes = buffer;
            }
            
            if(addRes < 10)
            {
                res.Add(addRes);
                buffer = 0;
            }
            else
            {
                res.Add(addRes%10);
                buffer = 1;
            }

            Index1--;
            Index2--;
        }

        res = ReverseIntList(res);

        return String.Join("", res.ToArray());
    }

    private int Add(int num1, int num2, int buffer)
    {
        return num1+num2+buffer;
    }

    private List<int> ReverseIntList(List<int> arr)
    {
        int l = 0;
        int r = arr.Count-1;
        
        while(l<r)
        {
            int temp = arr[l];
            arr[l] = arr[r];
            arr[r] = temp;

            l++;
            r--;
        }

        return arr;
    }
}
//2566. Maximum Difference by Remapping a Digit
//14 June 2025

public class Solution
{
    public int MinMaxDifference(int num)
    {
        string stringNum = num.ToString();
        int[] numArray = new int[stringNum.Length];

        int index = 0;
        foreach (var s in stringNum)
        {
            numArray[index] = s - '0';
            index++;
        }

        int maxValue = int.MinValue;
        int minValue = int.MaxValue;

        for (int i = 0; i < 10; i++)
        {
            int sumMax = 0;
            int sumMin = 0;
            foreach (var n in numArray)
            {
                sumMax *= 10;
                sumMin *= 10;
                if (n == i)
                {
                    sumMax += 9;
                    sumMin += 0;
                }
                else
                {
                    sumMax += n;
                    sumMin += n;
                }
            }
            maxValue = Math.Max(maxValue, sumMax);
            minValue = Math.Min(minValue, sumMin);
        }

        return maxValue - minValue;

    }
}
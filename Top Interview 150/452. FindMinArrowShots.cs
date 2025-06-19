//452. Minimum Number of Arrows to Burst Balloons
//19 June 2025

public class Solution
{
    public int FindMinArrowShots(int[][] points)
    {
        Array.Sort(points, (x, y) => x[1].CompareTo(y[1]));

        int arrow_pos = points[0][1];
        int arrows = 1;

        foreach (var p in points)
        {
            int x_start = p[0];
            int x_end = p[1];
            if (x_start > arrow_pos)
            {
                arrow_pos = x_end;
                arrows++;
            }
        }

        return arrows;
    }
}
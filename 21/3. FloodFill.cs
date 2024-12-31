//leetcode 733. Flood Fill

public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if(image.Length == 0) return image;

        int val = image[sr][sc]; //reference value
        
        if(val == color) return image;

        int m = image.Length; //row length
        int n = image[0].Length; //col length

        image = Fill(image, sr, sc, color, val, m, n);

        return image;
    }

    private int[][] Fill(int[][] image, int sr, int sc, int color, int val, int m, int n)
    {
        if(image[sr][sc] == val) image[sr][sc] = color;
        else return image;

        //down
        if(sr+1 < m)
        {
            image = Fill(image, sr+1, sc, color, val, m, n);
        }
        //right
        if(sc+1 < n)
        {
            image = Fill(image, sr, sc+1, color, val, m, n);
        }
        //up
        if(sr-1 >= 0)
        {
            image = Fill(image, sr-1, sc, color, val, m, n);
        }
        //left
        if(sc-1 >= 0)
        {
            image = Fill(image, sr, sc-1, color, val, m, n);
        }

        return image;
    }
}
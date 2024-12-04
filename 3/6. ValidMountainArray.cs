//leetcode 941: Valid Mountain Array

public class Solution {
    public bool ValidMountainArray(int[] arr) {
        //My original solution
        if(arr.Length<3) return false;
        
        int n = arr.Length;
        int r = n-2;
        int l = 1;

        while(l<n-1)
        {
            if(arr[l]>arr[l-1])
            {
                l++;
            }
            else
            {
                break;
            }
        }

        while(r>0)
        {
            if(arr[r]>arr[r+1])
            {
                r--;
            }
            else
            {
                break;
            }
        }

        return l-1==r+1;
    }
}
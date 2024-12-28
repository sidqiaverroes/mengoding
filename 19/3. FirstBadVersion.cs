//leetcode 278. First Bad Version

/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {

        bool current = IsBadVersion(n);
        bool prev = IsBadVersion(n-1);

        if(!prev && current) return n;

        //Binary Search
        int l = 1;
        int r = n;

        while(l<=r)
        {
            int mid = l + (r-l)/2;

            bool cur = IsBadVersion(mid);
            bool pre = IsBadVersion(mid-1);

            if(!pre && cur) return mid;

            if(cur)
            {
                r = mid-1;
            }
            if(!cur)
            {
                l = mid+1;
            }
        }

        return 0;
    }
}
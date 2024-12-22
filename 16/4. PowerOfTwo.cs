//leetcode 231. Power of Two

public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n == 1) return true;
        if(n == 0) return false; // zero
        if(n%2 != 0) return false; //odd numbers

        return IsPowerOfTwo(n/2);
    }
}
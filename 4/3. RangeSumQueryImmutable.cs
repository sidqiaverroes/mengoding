//leetcode 303: Range Sum Query - Immutable

public class NumArray {
    //My origin solution
    private int[] nums;

    public NumArray(int[] nums) {
        this.nums = nums;
    }
    
    public int SumRange(int left, int right) {
        int res = 0;

        for(int i=left; i<=right; i++)
        {
            res += nums[i];
        }

        return res;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */
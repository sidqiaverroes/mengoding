// leetcode 703. Kth Largest Element in a Stream

public class KthLargest {
    public int k;
    List<int> list;

    public KthLargest(int k, int[] nums) {
        this.k = k;
        this.list = new List<int>(nums);
        list.Sort();
    }
    
    public int Add(int val) {
        int index = list.BinarySearch(val);
        if(index<0) index = ~index;
        list.Insert(index, val);

        return list[list.Count-k];
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
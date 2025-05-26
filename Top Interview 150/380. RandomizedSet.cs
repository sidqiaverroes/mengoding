//380. Insert Delete GetRandom O(1)
//26 May 2025

public class RandomizedSet {

    private Dictionary<int, int> dict; //map val with the index of list
    private List<int> list;
    private Random rand;

    public RandomizedSet() {
        dict = new Dictionary<int,int>();
        list = new List<int>();
        rand = new Random();
    }
    
    public bool Insert(int val) {
        if(dict.ContainsKey(val)) return false;
        dict.Add(val, dict.Count());
        list.Add(val);
        return true;
    }
    
    public bool Remove(int val) {
        if (!dict.ContainsKey(val)) return false;

        int index = dict[val];
        int lastVal = list[^1]; // list[list.Count - 1]

        // Swap val with lastVal
        list[index] = lastVal;
        dict[lastVal] = index;

        // Remove last
        list.RemoveAt(list.Count - 1);
        dict.Remove(val);
        return true;
    }
    
    public int GetRandom() {
        return list[rand.Next(dict.Count())];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
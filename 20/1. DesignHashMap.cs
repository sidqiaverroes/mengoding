//leetcode 706. Design HashMap

public class MyHashMap {
    Dictionary<int, int> dict;

    public MyHashMap() {
        this.dict = new Dictionary<int,int>();
    }
    
    public void Put(int key, int value) {  
        if(dict.ContainsKey(key))
        {
            dict[key] = value;
        }
        else
        {
            dict.Add(key, value);
        }
    }
    
    public int Get(int key) {
        if(dict.ContainsKey(key)) return dict[key];

        return -1;
    }
    
    public void Remove(int key) {
        dict.Remove(key);
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
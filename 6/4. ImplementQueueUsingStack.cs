//leetcode 232: Implement Queue using Stacks

public class MyQueue {

    private List<int> stack;

    public MyQueue(List<int> stack = null) {
        this.stack = stack ?? new List<int>(); // Initialize with an empty list if null
    }
    
    public void Push(int x) {
        stack.Add(x);
    }
    
    public int Pop() {
        int x = stack[0];
        stack.RemoveAt(0);

        return x;
    }
    
    public int Peek() {
        return stack[0];
    }
    
    public bool Empty() {
        return !stack.Any();
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
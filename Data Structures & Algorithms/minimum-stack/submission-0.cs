public class MinStack {

    private List<int> stack;
    private List<int> minStack;
    public MinStack() 
    {   
        this.stack = new List<int>();
        this.minStack = new List<int>();
    }
    
    public void Push(int val) 
    {
        stack.Add(val);
        if (minStack.Count == 0 || val <= GetMin())
        {
            minStack.Add(val);
        }
    }
    
    public void Pop() 
    {
        int current = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);

        if (current == GetMin())
        {
            minStack.RemoveAt(minStack.Count - 1);
        }
    }
    
    public int Top() 
    {
        return stack[stack.Count - 1];
    }
    
    public int GetMin() 
    {
        return minStack[minStack.Count - 1];
    }
}

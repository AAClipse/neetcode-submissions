public class Solution {
    public int EvalRPN(string[] tokens) 
    {
        Stack<string> stack = new Stack<string>(); 
        foreach (string str in tokens)
        {
            if (str != "+" && str != "-" && str != "*" && str != "/")
            {
                stack.Push(str);
            }
            else
            {
                int b = int.Parse(stack.Pop());
                int a = int.Parse(stack.Pop());
                if (str == "+") stack.Push((a + b).ToString());
                if (str == "-") stack.Push((a - b).ToString());
                if (str == "*") stack.Push((a * b).ToString());
                if (str == "/") stack.Push((a / b).ToString());
            }
        }
        return int.Parse(stack.Pop());
    }
}

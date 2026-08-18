public class Solution {
    public bool IsValid(string s) 
    {
        Stack<char> stack = new Stack<char>();
        foreach (char bracket in s)
        {
            if (bracket == '(' || bracket == '[' || bracket == '{')
            {
                stack.Push(bracket);
            }
            else
            {
                if (stack.Count == 0) return false;

                char current = stack.Pop();

                if (current == '('  && bracket != ')') return false;
                if (current == '['  && bracket != ']') return false;
                if (current == '{'  && bracket != '}') return false;

            }
        }
        if (stack.Count != 0) return false;
        else return true;
    }
}

public class Solution {
    public int LargestRectangleArea(int[] heights) 
    {
        Stack<int> stack = new Stack<int>();
        int max = 0;
        for (int i = 0; i <= heights.Length; i++)
        {
            int cur;
            if (i == heights.Length) cur = 0;
            else cur = heights[i];
            while (stack.Count() > 0 && cur < heights[stack.Peek()])
            {
                int right = i;
                int left;
                int current = stack.Pop();
                if (stack.Count == 0) left = -1;
                else left = stack.Peek();
                
        
                int answer = (right - left - 1) * heights[current];
                if (answer > max) max = answer;
            }
            stack.Push(i);
        }
        return max;
        
    }
}

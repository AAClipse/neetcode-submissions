public class Solution {
    public int MaxArea(int[] heights) 
    {
        int max = 0;
        int left = 0;
        int right = heights.Length - 1;
        int leftMax = 0;
        int rightMax = 0;

        while(left < right)
        {
            int leftHeight = heights[left];
            int rightHeight = heights[right];
            if (leftHeight < leftMax) left++;
            else if (rightHeight < rightMax) right--;
            else
            {
                int water = (right - left) * Math.Min(leftHeight, rightHeight);
                if (water > max) max = water;
                leftMax = leftHeight;
                rightMax = rightHeight;

                if (leftHeight < rightHeight) left++;
                else if (leftHeight > rightHeight) right--;
                else right--;
            }
        }
        return max;
    }
}

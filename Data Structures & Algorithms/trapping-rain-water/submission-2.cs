public class Solution {
    public int Trap(int[] height) 
    {
        int left = 0;
        int leftMax = height[0];
        int right = height.Length - 1;
        int rightMax = height[height.Length - 1];
        int water = 0;
        while (left < right)
        {
            if (leftMax < rightMax)
            {
                left++;
                if (height[left] < leftMax)
                {
                    water += leftMax - height[left];
                }
                else 
                {
                    leftMax = height[left];
                }
            }
            else
            {
                right--;
                if (height[right] < rightMax) 
                {
                    water += rightMax - height[right];
                }
                else
                {
                    rightMax = height[right];
                }
            }
        }
        return water;
    }
}

public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] output = new int[nums.Length];
        
        int[] left = new int[nums.Length];
        int[] right = new int[nums.Length];

        left[0] = 1;
        for (int i = 1; i < left.Length; i++)
        {
            left[i] = left[i - 1] * nums[i - 1];
        }

        right[right.Length - 1] = 1;
        for (int i = output.Length - 2; i >= 0; i--)
        {
            right[i] = right[i + 1] * nums[i + 1];
        }

        for (int i = 0; i < output.Length; i++)
        {
            output[i] = left[i] * right[i];
        }

        return output;
    }
}

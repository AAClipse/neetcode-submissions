public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
          HashSet<int> faced = new HashSet<int>();
          for (int i = 0; i < nums.Length; i++)
          {
            if (!faced.Contains(nums[i]))
            {
                faced.Add(nums[i]);
            }
            else
            {
                return true;
            }
          }
          return false;
    }
}
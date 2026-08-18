public class Solution {
    public List<List<int>> ThreeSum(int[] nums) 
    {
        Array.Sort(nums);
        
        var answer = new List<List<int>>();

        var faced = new HashSet<(int, int, int)>();

        for (int i = 0; i < nums.Length - 2; i++) {
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0) {
                    var triplet = (nums[i], nums[left], nums[right]);

                    if (!faced.Contains(triplet)) {
                        faced.Add(triplet);
                        answer.Add(new List<int> { nums[i], nums[left], nums[right] });
                    }

                    left++;
                    right--;
                } 
                else if (sum > 0) {
                    right--;
                } 
                else {
                    left++;
                }
            }
        }

        return answer;
    }
}

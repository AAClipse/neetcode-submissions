public class Solution {
    public int FindDuplicate(int[] nums) {
        int fast = nums[nums[0]];
        int slow = nums[0];
        while (fast != slow){
            fast = nums[nums[fast]];
            slow = nums[slow];
        }
        slow = 0;
        while (fast != slow){
            fast = nums[fast];
            slow = nums[slow];
        }
        return fast;
    }
}

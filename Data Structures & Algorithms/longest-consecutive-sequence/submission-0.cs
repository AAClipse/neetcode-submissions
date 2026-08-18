public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        if (nums.Length == 0) return 0;
        HashSet<int> faced = new HashSet<int>();
        int currentStreak = 0;
        int maxStreak = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            faced.Add(nums[i]);
        }

        foreach(int num in faced)
        {
            if (faced.Contains(num - 1)) continue;

            currentStreak = 1;
            int i = 1;
            while (faced.Contains(num + i))
            {
                currentStreak++;
                i++;
            }
            if (currentStreak > maxStreak) maxStreak = currentStreak;
        }
        return maxStreak;
    }
}

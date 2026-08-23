public class Solution {
    public bool CheckInclusion(string s1, string s2)
    {
        if (s2.Length < s1.Length) return false;
        int[] faced1 = new int[26];
        foreach (char a in s1)
        {
            faced1[a - 'a']++;
        }
        int[] faced2 = new int[26];
        int left = 0;
        int right = 0;
        while (right <= s2.Length)
        {
            if (right < s1.Length)
            {
                faced2[s2[right] - 'a']++;
                right++;
            }
            else
            {
                if (faced1.AsSpan().SequenceEqual(faced2))
                {
                    return true;
                }
                if (right == s2.Length) break;

                faced2[s2[right] - 'a']++;
                right++;
                faced2[s2[left] - 'a']--;
                left++;
            }
        }
        return false;
    }
}

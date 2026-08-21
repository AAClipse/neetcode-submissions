public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        if (s.Length == 0) return 0;
        else if (s.Length == 1) return 1;

        HashSet<char> faced = new HashSet<char>();
        int left = 0;
        int right = 1;
        faced.Add(s[left]);
        int counter = 1;
        int max = 1;
        while (right < s.Length)
        {
            if (faced.Contains(s[right]))
            {
                while (faced.Contains(s[right]))
                {
                    faced.Remove(s[left]);
                    left++;
                    counter--;
                }
                faced.Add(s[right]);
                right++;
                counter++;
            }
            else
            {
                faced.Add(s[right]);
                counter++;
                right++;
                if (counter > max) max = counter;
            }
        }
        return max;
    }
}

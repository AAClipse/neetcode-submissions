public class Solution {
     public int CharacterReplacement(string s, int k)
    {
        int left = 0;
        int right = 0;
        int[] arr = new int[26];
        int maxfreq = 0;
        int max = 0;


        while (right < s.Length)
        {
            arr[s[right] - 'A']++;
            if (arr[s[right] - 'A'] > maxfreq) maxfreq = arr[s[right] - 'A'];

            if (right - left + 1 - maxfreq <= k)
            {
                int currentMax = right - left + 1;
                if (currentMax > max) max = currentMax;
                right++;
            }
            else
            {
                arr[s[right] - 'A']--;
                arr[s[left] - 'A']--;
                left++;
                maxfreq = arr.Max();
            }
        }
        return max;
    }
}

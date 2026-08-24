public class Solution {
    public string MinWindow(string s, string t) 
    {
        if (s == null || t == null || s.Length < t.Length) 
        {
            return "";
        }

        var goal = new Dictionary<char, int>();
        foreach (char a in t)
        {
            goal[a] = goal.GetValueOrDefault(a, 0) + 1;
        }
        var window = new Dictionary<char, int>();

        int goalMatches = goal.Count;
        int matches = 0;

        int minLen = 100001;
        int mini = 0;
        int left = 0;

        for (int right = 0; right < s.Length; right++)
        {
            if (goal.ContainsKey(s[right]))
            {
                window[s[right]] = window.GetValueOrDefault(s[right], 0) + 1;

                if (window[s[right]] == goal[s[right]]) matches++;
            }

            while (matches == goalMatches)
            {
                int currentLen = right - left + 1;
                if (currentLen < minLen)
                {
                    minLen = currentLen;
                    mini = left;
                }
                if (goal.ContainsKey(s[left]))
                {
                    if (window[s[left]] == goal[s[left]]) matches--;
                    window[s[left]]--;
                }
                left++;
            }
        }
        if (minLen == 100001) return "";
        string answer = s.Substring(mini, minLen);
        return answer;
    }
}

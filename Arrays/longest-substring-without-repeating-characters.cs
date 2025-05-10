//https://leetcode.com/problems/longest-substring-without-repeating-characters

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0) return 0;
        IDictionary<char, int> map = new Dictionary<char, int>();
        HashSet<char> set = new HashSet<char>();
        int left = 0;
        int right = 0;
        int longest = 1;

        while (right < s.Length)
        {
            if (map.ContainsKey(s[right]))
                left = Math.Max(map[s[right]] + 1, left);
            map[s[right]] = right;
            longest = Math.Max(longest, right - left + 1);
            right++;
        }
        return longest;
    }
}
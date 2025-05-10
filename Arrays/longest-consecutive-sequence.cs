//https://leetcode.com/problems/longest-consecutive-sequence/

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
            set.Add(nums[i]);

        int longest = 1;
        foreach (var item in set)
        {
            if (!set.Contains(item - 1))
            {
                int count = 1;
                int x = item;
                while (set.Contains(x + 1))
                {
                    x++;
                    count++;
                }
                longest = Math.Max(longest, count);
            }
        }

        return longest;
    }
}
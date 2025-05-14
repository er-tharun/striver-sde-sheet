//https://leetcode.com/problems/remove-duplicates-from-sorted-array/

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int n = nums.Length;
        var set = new HashSet<int>();
        for (int i = 0; i < n; i++)
        {
            set.Add(nums[i]);
        }
        int itr = 0;
        foreach (var item in set)
        {
            nums[itr++] = item;
        }

        return set.Count;
    }
}
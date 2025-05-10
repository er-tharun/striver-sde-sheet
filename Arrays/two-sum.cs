//https://leetcode.com/problems/two-sum

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        IDictionary<int, int> dict = new Dictionary<int, int>();
        int[] ans = { -1, -1 };
        for (int i = 0; i < nums.Length; i++)
        {
            int ValueToCheckInDict = target - nums[i];
            if (dict.ContainsKey(ValueToCheckInDict))
            {
                ans[0] = dict[ValueToCheckInDict];
                ans[1] = i;
                return ans;
            }
            if (!dict.ContainsKey(nums[i]))
                dict.Add(nums[i], i);
        }

        return ans;
    }
}
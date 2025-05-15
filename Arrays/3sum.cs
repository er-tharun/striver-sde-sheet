//https://leetcode.com/problems/3sum/

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();
        int n = nums.Length;
        Array.Sort(nums);
        for (int i = 0; i < n; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            for (int j = i + 1; j < n; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                int k = j + 1;
                while (k < n)
                {
                    int sum = nums[i] + nums[j];
                    sum += nums[k];
                    if (sum == 0)
                        result.Add(new List<int> { nums[i], nums[j], nums[k] });
                    k++;
                    while (k < n && nums[k] == nums[k - 1]) k++;
                }
            }
        }
        return result;
    }
}
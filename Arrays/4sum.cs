//https://leetcode.com/problems/4sum/

public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        int n = nums.Length;
        var result = new List<IList<int>>();
        Array.Sort(nums);
        for (int i = 0; i < n; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            for (int j = i + 1; j < n; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                int k = j + 1;
                int l = n - 1;
                while (k < l)
                {
                    int sum = nums[i] + nums[j];
                    sum += nums[k];
                    sum += nums[l];
                    Console.WriteLine(sum);
                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[k], nums[l] });
                        k++;
                        l--;
                        while (k < l && nums[k] == nums[k - 1])
                            k++;
                        while (k < l && nums[l] == nums[l + 1])
                            l--;
                    }
                    else if (sum < target)
                        k++;
                    else
                        l--;

                }
            }
        }


        return result;
    }
}

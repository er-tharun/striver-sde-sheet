//https://leetcode.com/problems/maximum-subarray/

public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int sum = 0;
        int maxi = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (sum > maxi)
                maxi = sum;
            if (sum < 0)
                sum = 0;
        }
        return maxi;
    }
}
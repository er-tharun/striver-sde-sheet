//https://leetcode.com/problems/max-consecutive-ones/

public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int result = 0;
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
                count++;
            else
                count = 0;
            result = Math.Max(result, count);
        }
        return result;
    }
}
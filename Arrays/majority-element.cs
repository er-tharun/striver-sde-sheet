//https://leetcode.com/problems/majority-element

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int element = int.MinValue;
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (count == 0)
            {
                element = nums[i];
                count++;
            }
            else
            {
                if (nums[i] == element)
                    count++;
                else
                    count--;
            }
        }
        return element;
    }
}
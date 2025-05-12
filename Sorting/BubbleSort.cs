public class Solution
{
    public int[] SortArray(int[] nums)
    {
        //Bubble Sort
        //
        int n = nums.Length;
        for (int i = n - 1; i > -0; i--)
        {
            for (int j = 0; j <= i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                    (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
            }
        }
        return nums;
    }
}
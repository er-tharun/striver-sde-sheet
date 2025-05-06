//https://leetcode.com/problems/sort-colors/

public class Solution
{
    public void SortColors(int[] nums)
    {

        int low = 0, mid = 0, high = nums.Length - 1;

        while (mid <= high)
        {
            if (nums[mid] == 0)
            {
                Swap(mid, low, nums);
                low++;
                mid++;
            }
            else if (nums[mid] == 1)
            {
                mid++;
            }
            else
            {
                Swap(mid, high, nums);
                high--;
            }
        }

    }

    public static void Swap(int first, int second, int[] nums)
    {
        int temp = nums[first];
        nums[first] = nums[second];
        nums[second] = temp;
    }
}
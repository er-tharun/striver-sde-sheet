//

public class Solution
{
    public int[] SortArray(int[] nums)
    {
        //Insertion Sort
        //Sent an element and insert into correct place
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            int j = i;
            while (j > 0 && nums[j - 1] > nums[j])
            {
                (nums[j], nums[j - 1]) = (nums[j - 1], nums[j]);
                j--;
            }
        }
        return nums;
    }
}
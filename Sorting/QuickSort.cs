public class Solution
{
    public int[] SortArray(int[] nums)
    {
        //Quick Sort
        QuickSort(nums, 0, nums.Length - 1);
        return nums;
    }

    public static void QuickSort(int[] nums, int low, int high)
    {
        if (low < high)
        {
            int pIndex = GetPartitionIndex(nums, low, high);
            QuickSort(nums, low, pIndex - 1);
            QuickSort(nums, pIndex + 1, high);
        }
    }

    public static int GetPartitionIndex(int[] nums, int low, int high)
    {
        int pivot = nums[low];
        int i = low;
        int j = high;

        while (i < j)
        {
            while (nums[i] <= pivot && i < high) i++;
            while (nums[j] > pivot && j > low) j--;

            if (i < j)
                (nums[i], nums[j]) = (nums[j], nums[i]);
        }

        (nums[low], nums[j]) = (nums[j], nums[low]);
        return j;
    }
}
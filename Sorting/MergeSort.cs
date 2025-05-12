public class Solution
{
    public int[] SortArray(int[] nums)
    {
        //Merge Sort
        //Divide & Conquer
        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }

    public static void MergeSort(int[] nums, int low, int high)
    {
        if (low >= high) return;
        int mid = (low + high) / 2;
        MergeSort(nums, low, mid);
        MergeSort(nums, mid + 1, high);
        MergeArray(nums, low, mid, high);
    }

    public static void MergeArray(int[] nums, int low, int mid, int high)
    {
        int i = low;
        int j = mid + 1;
        var tempList = new List<int>();

        while (i <= mid && j <= high)
        {
            if (nums[i] <= nums[j])
            {
                tempList.Add(nums[i]);
                i++;
            }
            else
            {
                tempList.Add(nums[j]);
                j++;
            }
        }

        while (i <= mid)
        {
            tempList.Add(nums[i]);
            i++;
        }
        while (j <= high)
        {
            tempList.Add(nums[j]);
            j++;
        }

        for (int k = low; k <= high; k++)
            nums[k] = tempList[k - low];
    }
}
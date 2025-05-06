//https://leetcode.com/problems/next-permutation/

public class Solution {
    public void NextPermutation(int[] nums) {
        int index = -1;
        int n = nums.Length;
        for(int i = n-2; i>=0;i--) {
            if(nums[i] < nums[i+1])
            {
                index = i;
                break;
            }
        }

        if(index == -1)
        {
            Array.Reverse(nums);
            return;
        }

        for(int i = n-1; i>index;i--) {
            if(nums[i] > nums[index]) {
                Swap(i, index, nums);
                break;
            }
        }
        Array.Sort(nums, index+1, n-1-index);
    }

    public static void Swap(int first, int second, int[] nums)
    {
        int temp = nums[first];
        nums[first] = nums[second];
        nums[second] = temp;
    }
}
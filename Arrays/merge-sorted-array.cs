//https://leetcode.com/problems/merge-sorted-array/

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int len = nums1.Length;
        for (int i = 0; i < n; i++)
        {
            nums1[(m) + i] = nums2[i];
        }

        Array.Sort(nums1);
        /*int left = m-1, right = 0;

        while(left >=0 && right < n)
        {
            if(nums1[left] > nums2[right])
            {
                Swap(left,right,num1,nums2);
                left--;
                right++;
            }
            else
                break;
        }

        Array.Sort(nums1);
        Array.sort(nums2);*/
    }
}
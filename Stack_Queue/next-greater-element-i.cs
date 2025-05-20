//https://leetcode.com/problems/next-greater-element-i/

public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        int[] nge = new int[nums1.Length];
        Stack<int> stack = new Stack<int>();
        int n = nums2.Length;
        int[] tempNge = new int[nums2.Length];
        for (int i = n - 1; i >= 0; i--)
        {
            if (stack.Count == 0)
                tempNge[i] = -1;
            else
            {
                if (stack.Peek() <= nums2[i])
                    while (stack.Count != 0 && stack.Peek() <= nums2[i]) stack.Pop();
                tempNge[i] = stack.Count == 0 ? -1 : stack.Peek();
            }
            stack.Push(nums2[i]);
        }

        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (nums1[i] == nums2[j])
                {
                    nge[i] = tempNge[j];
                    break;
                }
            }
        }

        return nge;
    }
}
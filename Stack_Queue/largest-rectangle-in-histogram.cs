//https://leetcode.com/problems/largest-rectangle-in-histogram

public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        Stack<int> stack = new Stack<int>();
        int maxArea = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            while (stack.Count != 0 && heights[stack.Peek()] > heights[i])
            {
                int element = stack.Peek();
                stack.Pop();
                int nse = i;
                int pse = stack.Count == 0 ? -1 : stack.Peek();
                maxArea = Math.Max(maxArea, heights[element] * (nse - pse - 1));
            }
            stack.Push(i);
        }

        while (stack.Count != 0)
        {
            int nse = heights.Length;
            int element = stack.Peek();
            stack.Pop();
            int pse = stack.Count == 0 ? -1 : stack.Peek();
            maxArea = Math.Max(maxArea, heights[element] * (nse - pse - 1));
        }
        return maxArea;
    }
}
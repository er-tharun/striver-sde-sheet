//https://leetcode.com/problems/pascals-triangle

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        var result = new List<IList<int>>();
        for (int i = 0; i < numRows; i++)
        {
            var temp = new List<int>();
            temp.Add(1);
            for (int j = 1; j <= i; j++)
            {
                temp.Add(GetCombination(i, j));
            }
            result.Add(temp);
        }
        return result;
    }

    public static int GetCombination(int n, int r)
    {
        int result = 1;
        for (int i = 1; i <= r; i++)
        {
            result *= n;
            result /= i;
            n--;
        }
        return result;
    }
}
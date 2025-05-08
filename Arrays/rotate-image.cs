//https://leetcode.com/problems/rotate-image/

public class Solution
{
    public void Rotate(int[][] matrix)
    {
        int row = matrix.Length;
        int column = matrix[0].Length;

        for (int i = 0; i < row; i++)
        {
            for (int j = i + 1; j < column; j++)
            {
                var temp = matrix[j][i];
                matrix[j][i] = matrix[i][j];
                matrix[i][j] = temp;
            }
        }

        for (int i = 0; i < row; i++)
        {
            Array.Reverse(matrix[i]);
        }
    }
}
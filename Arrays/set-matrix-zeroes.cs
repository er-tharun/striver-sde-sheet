//https://leetcode.com/problems/set-matrix-zeroes/

public class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        //row[n] = matrix[..][0];
        //col[n] = matrix[0][..];
        int col0 = 1;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    matrix[i][0] = 0;
                    if (j == 0)
                        col0 = 0;
                    else
                        matrix[0][j] = 0;
                }
            }
        }

        for (int i = 1; i < matrix.Length; i++)
        {
            for (int j = 1; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] != 0)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }

        if (matrix[0][0] == 0)
        {
            for (int i = 0; i < matrix[0].Length; i++)
            {
                matrix[0][i] = 0;
            }
        }

        if (col0 == 0)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][0] = 0;
            }
        }
    }
}
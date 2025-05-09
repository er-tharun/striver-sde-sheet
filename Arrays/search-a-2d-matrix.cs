//https://leetcode.com/problems/search-a-2d-matrix/

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int low = 0;
        int high = (matrix.Length * matrix[0].Length) - 1;
        int element = matrix[0].Length;

        while(low <= high)
        {
            int mid = (low+high)/2;
            int row = mid/element;
            int col = mid%element;
            if(matrix[row][col] == target)
                return true;
            else if(matrix[row][col] < target)
                low = mid+1;
            else
                high = mid-1;
        }
        return false;
    }
}
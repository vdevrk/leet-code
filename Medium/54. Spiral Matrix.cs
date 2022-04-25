public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        
        int m = matrix.Length;
        int n = matrix[0].Length;
        int left = 0, right = n - 1, top = 0, bottom = m - 1;
        int total = m * n;
        List<int> spiral = new List<int>();
        while(spiral.Count() < total)
        {
            for(int i = left; i <= right && spiral.Count() < total; i++)
                spiral.Add(matrix[top][i]);
            top++;
            for(int i = top; i <= bottom && spiral.Count() < total; i++)
                spiral.Add(matrix[i][right]);
            right--;
            for(int i = right; i >= left && spiral.Count() < total; i--)
                spiral.Add(matrix[bottom][i]);
            bottom--;
            for(int i = bottom; i >= top && spiral.Count() < total; i--)
                spiral.Add(matrix[i][left]);
            left++;
            
		}
        return spiral;
    }
    }

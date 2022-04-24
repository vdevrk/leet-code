public class Solution {
    public int DiagonalSum(int[][] mat) {
        
        int sum = 0;
        for (int i = 0; i< mat.Length; ++i){
            sum+=mat[i][i];
            mat[i][i] = 0;// just that even if the element is added it wont be of effect when the number of elemenst in the matrix is odd
            sum+=mat[i][mat.Length-1-i];
        }   
        return sum;
    }
}

/*public class Solution {
    public int DiagonalSum(int[][] mat) {
        
        int sum = 0, n = mat.Length;
        
        for(int i = 0; i < n; i++)
        {
            sum += mat[i][i] + mat[i][n - 1 - i];
        }
        
        return n % 2 == 0? sum : sum - mat[n / 2][n / 2];
    }
}*/
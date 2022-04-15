public class Solution {
   /* public int[][] MatrixReshape(int[][] mat, int r, int c) {
        
        
        if((r*c) !=(mat.Length*mat[0].Length))
           return mat;
           
        int [][] output= new int[r][];
      for(int i=0;i<r;i++)
          output[i]=new int[c];
        
        int a=0,b=0;
        for(int i=0;i<mat.Length;i++)
        {
            for(int j=0;j<mat[i].Length;j++)
            {
               if (a < r)
                    {
                        if (b < c)
                        {
                            output[a][b++] = mat[i][j];
                       
                        }
                        else
                        {
                               a++;
                               b = 0;
                               output[a][b++] = mat[i][j];

                        }
                    }
            }
        }
        return output;
    }*/
      public int[][] MatrixReshape(int[][] nums, int r, int c)
        {
            int[][] res = new int[r][];
            int n = nums.Length;
            int m = nums[0].Length;

            if (n * m != r * c)
            {
                return nums;
            }

            int idx = 0;
          /* for(int i = 0; i < r; i++) 
               //this loop is because i cant just declare int [][] transpose = new int[m][n]... c# things
        {
            result[i] = new int[c];
        }  int[,] array = new int[4, 2];*/

            for (int i = 0; i < r; i++)
            {
                res[i] = new int[c];
                for (int j = 0; j < c; j++)
                {
                    int oldRow = idx / m;
                    int oldCol = idx % m;

                    res[i][j] = nums[oldRow][oldCol];
                    idx++;
                }
            }

            return res;
        }
}
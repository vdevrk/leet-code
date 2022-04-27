public class Solution {
    public int CoinChange(int[] coins, int amount)
        {
            if (amount == 0)
                return 0;
           
            int[][] t = new int[coins.Length + 1][];
          
         for (int i = 0; i<coins.Length+1; i++)
            {
                t[i] = new int[amount + 1];
            }
        //Solution using DP Top Down approach.
        
        //Initialisation of First row and first column of the matrix
        for(int i=0;i<coins.Length+1;i++)
        for(int j=0;j<amount+1;j++)
        {
         if(j==0)
            t[i][j]=0;
         if(i==0)
             t[i][j]=int.MaxValue-1;
        }
        //Initialisation of second row and  of the matrix
       for(int j=1;j<amount+1;j++)
        {
            if(j%coins[0]==0)
                t[1][j]=j/coins[0];
            else
                t[1][j]=int.MaxValue-1;
        }
        //Fill the remaining column of the matrix with code.This is unbounded knapsack problem
        for(int i=1;i<coins.Length+1;i++)
        for(int j=1;j<amount+1;j++)   
        {
            if(coins[i - 1]<=j)
            {
                t[i][j]=Math.Min(t[i - 1][j] , 1+t[i][j - coins[i - 1]]);
            }
            else
                t[i][j]=t[i - 1][j];
                
        }
        if( t[coins.Length][amount]==int.MaxValue-1)
            return -1;
        return t[coins.Length][amount];
        
    }
    
    
    
}
    

public class Solution {
    public int MaxProfit(int[] prices) {
        int min=int.MaxValue;
        int maxprofit=0;
        for(int i=0;i<prices.Length;i++)
        {
            if(prices[i]<min)
                min=prices[i];
            if (maxprofit< prices[i]-min)
                maxprofit=prices[i]-min;
        }
        return maxprofit;
    }
}
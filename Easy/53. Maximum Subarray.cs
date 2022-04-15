public class Solution {
    public int MaxSubArray(int[] nums) {
        int sum=0;
        int maxsum=nums[0];
        for(int i=0;inums.Length;i++)
        {
            sum+=nums[i];
            if(sumnums[i])
                sum=nums[i];
                
                if(summaxsum)
                    maxsum=sum;
        }
        return maxsum;
    }
}
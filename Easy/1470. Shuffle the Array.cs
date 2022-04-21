public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int [] yArray = new int[n];
        int[] outputArray = new int[2*n];
        int j=0;
        for(int i=n;i<(2*n);i++)
        {
            yArray[j++]=nums[i];
            
            
        }
        j=0;
        for(int i=0;i<n;i++)
        {
            outputArray[j++]=nums[i];
            outputArray[j++]=yArray[i];
        }
        return outputArray;
    }
    
   /* public int[] Shuffle(int[] nums, int n) {
     
        if(nums == null || nums.Length == 0)
            return nums;
        
        int[] res = new int[2 * n];
        int idx1 = 0, idx2 = n;
        
        for(int i = 0; i < 2 * n; i++)
        {
            if(i % 2 == 0)
                res[i] = nums[idx1++];
            else
                res[i] = nums[idx2++];
        }
        
        return res;
    }*/
}
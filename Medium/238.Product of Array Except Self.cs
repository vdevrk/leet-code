public class Solution {
   public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];
        
        for (int i = 0; i < res.Length; i++)
            res[i] = 1; // use 1 instead of 0 so it can be multipled
        
        //Calculate the product of numbers that is left to the current number
        int left = 1;
        for (int i = 0; i < nums.Length; i++) {
            res[i] =  res[i]*left;
            left =left*nums[i];
        }
        //Calculate the product of numbers that is right to the current number
        int right = 1;
        for (int i = nums.Length-1; i >= 0; i--) {
            res[i] = res[i]* right;
            right =right* nums[i];
        }
        
        return res;
    }
}
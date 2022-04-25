public class Solution {
    public void MoveZeroes(int[] nums) {
        if(nums.Length==1)
            return;
        
        int j=0,i=0;
        while(i<nums.Length)
        {
          if(nums[i]!=0)
          {
              nums[j++]=nums[i];
             
          }
            i++;
        }
        while(j < nums.Length)
		{
			nums[j] = 0;
			j++;
		}
    }
}
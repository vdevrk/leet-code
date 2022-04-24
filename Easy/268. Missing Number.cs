public class Solution {
    public int MissingNumber(int[] nums) {
        
        int n=nums.Length;
       Array.Sort(nums);
        for(int i=0;i<n;i++)
        {
            if(nums[i]!=i)
                return i;
            
        }
        return n;
        
    }      
}
/* Other methods to solve the solution
the sum of numbers of 1 through n: (n*(n+1))/2
using the formula we can find the missing number by subtracting the sum of elements from nums array/vector with the number found with this formula.
In other words, (n*(n+1))/2 - sum*/
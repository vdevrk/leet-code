public class Solution {
    public int[] SortedSquares(int[] nums) {
        
      /*  int [] squaredArray = new int[nums.Length];
        
        for(int i=0;i<nums.Length;i++)
        {
            squaredArray[i]=nums[i]*nums[i];
        }
         Array.Sort(squaredArray);
        return squaredArray; }*/
        
        int[] squaredArray = new int[nums.Length];
		int l = 0;
		int r = nums.Length - 1;

		for(int i=0; i<nums.Length; i++){
			nums[i] = nums[i]*nums[i]; 
		}

/*Since the input array is in increasing order chances that last number in array have the hight square or any number which is negative
at the starting of the input array can be largest.Hence on creating the new array place the greater element in the last position.*/
		for(int i=nums.Length-1; i>=0; i--){            

		   if(nums[l] >= nums[r]){
			   squaredArray[i] = nums[l];
			   l++;
		   }else{
			   squaredArray[i] = nums[r];
			   r--;
		   }
		}

		return squaredArray;
	}
        
    
}
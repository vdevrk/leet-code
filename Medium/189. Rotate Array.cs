public class Solution {
    public void Rotate(int[] nums, int k) {
        
        /*int length=nums.Length;
        List<int> a= new List<int>(nums);
        while(k>0)
        {
            a.Insert(0,a.Last());
            a.RemoveAt(length);
            k--;
            
        }
         for(int i=0; i<a.ToArray().Length; i++) {
            nums[i] = a[i];
        }*/
       // Array.Copy(a.ToArray(),nums,length);
    
        if(nums == null || nums.Length < 2)
            return;
        
        k %= nums.Length;        
        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1); 
    }
    
    public void Reverse(int[] nums, int left, int right)
    {
        while(left < right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
            left++;
            right--;
        }
    }

    
    
}
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
      /*for(int i=0;i<n;i++)
      {
          nums1[m]=nums2[i];
          m+=1;
      }
    Array.Sort(nums1);
          
    */
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;
        
        while(i >= 0 && j >= 0){
            if(nums1[i] > nums2[j]){
                nums1[k] = nums1[i];
                i--;
            }else{
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }

        while(j >= 0){
            nums1[k] = nums2[j];
            k--;
            j--;
        }
        //No need to check i>=0 as all numbers will be there in first array
         while (i >=0) 
            nums1[k--] = nums1[i--];
}
}
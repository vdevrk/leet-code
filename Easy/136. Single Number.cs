public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int,int> dic= new Dictionary<int,int>();
        
        for(int i=0;i<nums.Length;i++)
        {
            if(!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i],1);
            }
            else
            {
                dic[nums[i]]+=1;
            }    
        }
        int key=dic.FirstOrDefault(x=>x.Value==1).Key;
        return key;
    }
}
public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> dic=new  Dictionary<int,int>();
        
        for(int i=0;i<nums.Length;i++)
        {
            if(!dic.ContainsKey(nums[i]))
                dic.Add(nums[i],1);
            else
                dic[nums[i]]=dic[nums[i]]+1;
            
        }
		/*foreach(var keys in dic.Keys )
        {
             if ((int)dic[keys] > nums.Length / 2)
                    return (int)keys;
        }
        return -1
		*/
        int maxValue=dic.Values.Max();
        int key=dic.FirstOrDefault(x=>x.Value==maxValue).Key;
        return key;
    }
	
}
/*Baylor Moore" majority vote algrithm
This simple solution is an implementation of the "Baylor Moore" majority vote algrithm. The basic idea is to maintain a count for a given initial element. We increment that count if we encounter the same element and we decrement it we get a different element, when the count reaches zero, we update it to the newer element because this essentially means the the initial major element did not repeat itself sufficient times.

public int MajorityElement(int[] nums) {
    int major = nums[0];
    int count = 1;
    for(int i = 1; i < nums.Length; i++){
        if(count == 0){
            major = nums[i];
            count++;
        }else{
            if(major == nums[i]){
                count++;
            }else{
                count--;
            }
        }
    }
    return major;
}
*/
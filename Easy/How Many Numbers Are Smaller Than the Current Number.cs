//Brute Force Solution 1

public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int count=0;
        int [] res= new int[nums.Length];
        for(int i=0;i<nums.Length;i++)
        {count=0;
            
        for(int j=0;j<nums.Length;j++)
        {
            if(i!=j)
            {
                if(nums[i]>nums[j])
                    count++;
            }
        }
            res[i]=count;
        }
       return res; 
    }
}
//Sorted array method Solution 2
public class Solution {
List<int> lists = new List<int>(nums);
        lists.Sort();
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i = 0; i<lists.Count; i++)
        {
            if (!map.ContainsKey(lists[i]))
                map.Add(lists[i],i);
        }
        
        int[] output = new int[nums.Length];
        
        for(int i = 0; i< nums.Length; i++)
        {
             output[i] = map[nums[i]];
        }
        return output;
}	
		
/* Frequency count Method O(n)*/
 public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] freq = new int[101], result = new int[nums.Length];

            foreach (var num in nums)
                freq[num]++;

            for (int i = 0; i <= 100; i++)
            {
                if (i == 0)
                {
                    freq[i] = freq[i];

                }
                else
                    freq[i] = freq[i] + freq[i - 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    result[i] = 0;
                else
                    result[i]= freq[nums[i] - 1];
            }
            return result;
        }
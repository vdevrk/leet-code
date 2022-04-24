 
 public class Solution {
    public int MaxProduct(int[] nums) {
        int[] arraySubtractedbyByOne= nums.Select(x=>x-1).ToArray();
        int maxNumber= arraySubtractedbyByOne.Max();
        int numIndex = Array.IndexOf(arraySubtractedbyByOne, maxNumber);
        
        arraySubtractedbyByOne = arraySubtractedbyByOne.
            Where((val ,idx) => idx != numIndex).ToArray();
        int seconMaxNumber=arraySubtractedbyByOne.Max();
        
        return maxNumber*seconMaxNumber;
    }
}
 /*int max1 = Int32.MinValue, max2 = Int32.MinValue;
        foreach(var num in nums)
        {
            if(num >= max1)
            {
                max2 = max1;
                max1 = num;
            }
            else if(num > max2)
                max2 = num;
        }
        
        return (max1 - 1) * (max2 - 1);*/
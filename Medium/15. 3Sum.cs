/*3 sum .Same code can handle N sum for a given target .Just change the input parameters while calling KSum_Recursion*/
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> result=new List<IList<int>>();
        if(nums== null ||nums.Length<3)
            return result;
        
        Array.Sort(nums);
        return KSum_Recursion(nums, 0, 3, 0);  
    }
     public static IList<IList<int>> KSum_Recursion(int[] nums, int index, int k, int target)
    {
      List<IList<int>> kList = null;
      if (k == 2)
      {
        kList = TwoSum(nums, index, nums.Length - 1, target);
        return kList;
      }

      kList = new List<IList<int>>();
      for (int i = index; i < nums.Length - k + 1; i++)
      {
        //Recursive call to KSum with k-1
        var temp = KSum_Recursion(nums, i + 1, k - 1, target - nums[i]);
        if (temp != null && temp.Count > 0)
        {
          /************************************************************************/
          //Add the number which called KSum with k-1
          //For example if -2 called KSum_Recursion(k=2 & target=2)
          //KSum_Recursion(k=2 & target=2) would come back with [[1, 1], [0, 2]]
          //We would update those list such that they become [[-2, 1, 1], [-2, 0 ,2]]
          /************************************************************************/
          foreach (var sumList in temp)
          {
            sumList.Insert(0, nums[i]);
          }

          kList.AddRange((List<IList<int>>)temp);
        }

        //Ignore duplicates
        //Remember array is sorted
        while (i < nums.Length - 1 && nums[i] == nums[i + 1])
          i++;

      }
      return kList;
    }

    /************************************************************************/
    //Two sum approach using 2 pointer algorithm
    //Add the 2 numbers from those pointers
    //  If sum is less than target then do left++
    //  else If sum is greater than target then do right--
    /************************************************************************/
    public static List<IList<int>> TwoSum(int[] nums, int left, int right, int target)
    {
      var twosumList = new List<IList<int>>();
      while (left < right)
      {
        var sum = nums[left] + nums[right];
        if (sum < target)
          left++;
        else if (sum > target)
          right--;
        else
        {
          var temp = new List<int>{nums[left], nums[right] };
          twosumList.Add(temp);

          //Handle duplicate combinations
          //Remember array is sorted
          while (left < right && nums[left] == nums[left + 1])
            left++;

          //Handle duplicate combinations
          //Remember array is sorted
          while (left < right && nums[right] == nums[right - 1])
            right--;

          left++;
          right--;
        }
      }

      return twosumList;
    }
  
}
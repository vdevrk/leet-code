public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        var hash=new HashSet<int>();
    foreach (int item in nums)
        if (!hash.Add(item)) return true;
    return false;
       // return hash.Count!=nums.Length;
    }
}
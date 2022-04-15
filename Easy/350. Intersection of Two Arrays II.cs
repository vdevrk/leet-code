public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        int m=nums1.Length;
        int n=nums2.Length;
        List<int> l=new List<int>();
        if (m>n)
        {
            List <int>first= nums1.ToList();
            for(int i=0;i<n;i++)
            {
                if(first.Contains(nums2[i]))
                {  l.Add(nums2[i]);
                 first.Remove(nums2[i]);
                }
                
            }
        }
        else {
            List <int>first= nums2.ToList();
            for(int i=0;i<m;i++)
            {
                if(first.Contains(nums1[i]))
                {
                    l.Add(nums1[i]);
                    first.Remove(nums1[i]);
                }
            }
        }
        return l.ToArray();
    }
}
public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        HashSet<char> hash = new HashSet<char>();
        if (string.IsNullOrEmpty(s))
            return 0;
        
        int max = 1;
        int start=0,i = 0;
        while( i < s.Length)
         {
            if (!hash.Contains(s[i]))
                {
                    hash.Add(s[i]);
                    i++;

                    if (max < hash.Count)
                        max = hash.Count;
                }

                else
                {
                        hash.Clear();
                        start++;
                        i = start;
                }
        }
         return max;
    }
    
}
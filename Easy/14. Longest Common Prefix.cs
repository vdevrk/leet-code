public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        int j,minLen=strs[0].Length;
        string first=strs[0];
        foreach(var word in strs)
        {
            j=0;
            while(j<first.Length && j<word.Length && first[j]==word[j])
             j++;
            minLen=Math.Min(minLen,j);               
        }        
        return first.Substring(0,minLen) ;
    }
}
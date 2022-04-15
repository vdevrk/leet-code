public class Solution {
    public int FirstUniqChar(string s) {
     
        
        var charAndCount = new int[256];

        foreach (var c in s) {
            charAndCount[c]++;
        }

        for (int i = 0; i < s.Length; i++) {
            if (charAndCount[s[i]] == 1) {
                return i;
            }
        }
        return -1;
    }
}
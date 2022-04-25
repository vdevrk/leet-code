public class Solution {
    public bool CheckIfPangram(string sentence) {
        if(sentence.Length<26)
            return false;
        var charCount = new int[256];
        foreach(var c in sentence)
        {
            charCount[c]++;
        }
       //ASCII values for alphates lowercase 97-122 
        for(int i=97;i<=122;i++)
        {
            if(charCount[i]==0)
                return false;
        }
        return true;
    }
}

/*  if(sentence.Length < 26)
            return false;
        
        int[] freq = new int[26];
        foreach(var c in sentence)
            freq[c - 'a']++;
        
        foreach(var f in freq)
        {
            if(f == 0)
                return false;
        }
        
        return true; */
public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if(s.Length!=t.Length)
            return false;
       /* Time exceeded 
       foreach(var c in t)
       { 
           if(!(t.Count(x=>x==c)== s.Count(y=>y==c)))
           return false;
       }
        return true;*/
          var charAndCount = new int[256];
        foreach (var c in t) {
            charAndCount[c]++;
        }

        foreach (var c in s) {
            charAndCount[c]--;
        }
        
        for(int i=0;i<charAndCount.Length;i++)    
            if (charAndCount[i] != 0) {
                return false;
            }
        return true;
        
     //using linq makes slow ??  var result = charAndCount.Any(c => c != 0);
        
      //  return !result; 
        
    }
}
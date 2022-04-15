public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
      /* foreach(var c in ransomNote)
       { 
           if(!(magazine.Count(x=>x==c)>= ransomNote.Count(y=>y==c)))
           return false;
       }
        return true;*/
         var charAndCount = new int[256];
        foreach (var c in magazine) {
            charAndCount[c]++;
        }

        foreach (var c in ransomNote) {
            charAndCount[c]--;

            if (charAndCount[c] < 0) {
                return false;
            }
        }

        return true;
    }
}
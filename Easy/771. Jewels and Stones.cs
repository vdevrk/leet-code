public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
      
        HashSet<char> jewel = new HashSet<char>(jewels);
        //Look up Hashset is o(1)
      /*    List<char> jewel= new  List<char>();
       for(int i=0;i<jewels.Length;i++)
       {
           jewel.Add(jewels[i]);
           
       }*/
        int jewelCount=0;
        for(int i=0;i<stones.Length;i++)
       {
          if(jewel.Contains(stones[i]))
              jewelCount++;
           
       }
        return jewelCount;
        
    }
}
public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
		//int maxCandies = candies.Max();
        int maxofCandies=candies[0];
        for(int i=1;i<candies.Length;i++)
        {
            if(maxofCandies<candies[i])
                maxofCandies=candies[i];
        }
        List<bool> returnList= new List<bool>();
         int totalCandieswithKid;
        for(int i=0;i<candies.Length;i++)
        {
             totalCandieswithKid=candies[i]+extraCandies;
            
            if(totalCandieswithKid>=maxofCandies)
                returnList.Add(true);
            else
                returnList.Add(false);
            
        }
        return returnList;
        
        
    }
}
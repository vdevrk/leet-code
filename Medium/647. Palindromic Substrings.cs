public class Solution {
	/*Brute Force*/
	/*ToDo: Solve using DP*/
    public int CountSubstrings(string s) {
        int countOfPalindromicStrings=0;
        
        String strToCompare,revStrToCompare;
       
        for(int i=0;i<s.Length;i++)
        {
            for(int j=1;j<=s.Length-i;j++)
            
            { strToCompare=s.Substring(i,j);
             if(!string.IsNullOrEmpty(strToCompare))
             {
              var result=strToCompare.ToCharArray();
              Array.Reverse(result);
              revStrToCompare=new String(result);
              if(strToCompare ==revStrToCompare)
                 countOfPalindromicStrings++; 
             }
            }
              
        }
        return countOfPalindromicStrings;
            
    }
}
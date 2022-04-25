/*Brute Force Approach results in time limit exceeded for long strings*/
public class Solution {
    /*public string LongestPalindrome(string s) {
       
        
        string strToCompare,revStrToCompare,finalResult="";
        int max=0;
       
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
              {
                  if(max<strToCompare.Length)
                  {
                      max=strToCompare.Length;
                      finalResult=strToCompare;
                  }
                  
              }
             }
            }
              
        }
        return finalResult; 
    }*/
	
	public string LongestPalindrome(string s) {
        
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }
        
        string result = string.Empty;
        StringBuilder longestPalindrome = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            longestPalindrome.Clear();
            longestPalindrome.Append(s[i]);
            Palindrome(s, i - 1, i + 1, longestPalindrome);
            if (longestPalindrome.Length > result.Length)
            {
                result = longestPalindrome.ToString();
            }
            
            longestPalindrome.Clear();
            Palindrome(s, i - 1, i, longestPalindrome);
            if (longestPalindrome.Length > result.Length)
            {
                result = longestPalindrome.ToString();
            }
        }
        
        return result;
    }
    
    public void Palindrome(string s, int left, int right, StringBuilder newString)
    {
        if (left < 0 || right >= s.Length)
        {
            return;
        }
        
        while(left >= 0 && right < s.Length && s[left] == s[right])
        {
            newString.Insert(0, s[left]);
            newString.Append(s[right]);
            left -= 1;
            right += 1;
        }
    }
}
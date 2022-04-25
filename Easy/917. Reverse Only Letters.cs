public class Solution {
   
        
       public string ReverseOnlyLetters(string s)
        {
            List<char> letters = new List<char>();
            Dictionary<int, char> specialChar = new Dictionary<int, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                {
                    letters.Add(s[i]);
                    
                }

                else if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    letters.Add(s[i]);
                   
                }

                else
                    
               specialChar.Add(i,s[i]);
            }

            letters.Reverse();
            StringBuilder sb = new StringBuilder(s.Length);
            int letterIdx = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (specialChar.ContainsKey(i))
                {
                    sb.Append(specialChar[i]);
                   
                }
               else
                sb.Append(letters[letterIdx++]);
            }

            return sb.ToString();
        }
    }

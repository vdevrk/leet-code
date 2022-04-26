//Brute Force but gives TLE error
public class Solution {
    public int MaxArea(int[] height) {
        
        int maxArea=-1;
        int area;
        for(int i=0;i<height.Length;i++)
        {
            for(int j=i;j<height.Length;j++)
            {
                if(i!=j)
                {
                if(height[i]<=height[j])
                {
                    area= Math.Abs((j-i))*height[i];
                    
                }
                else
                { 
                    area=Math.Abs((j-i))*height[j];
                    
                }
                    if(maxArea < area)
                        maxArea=area;
                }
                
            }
        }
        return maxArea;
    }
}
//Efficinet method

  public int MaxArea(int[] height) {
        
       
        int max=0;
        int left=0;
        int right=height.Length-1;
        
        while(left<right){
            if(height[left]<height[right]){
                var area = Math.Min(height[right],height[left]) * (right-left);
                max = Math.Max(max,area);
                left++;
            }else{
                var area = Math.Min(height[right],height[left]) * (right-left);
                max = Math.Max(max,area);
                right--;
            }
        }
        
        return max;
        
    }
    }

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        
        var result= new List<IList<int>>();
        List<int> previousRow= new List<int>();
        
        previousRow.Add(1);
        result.Add(previousRow);
      
      
        for(int i=1;i<numRows;i++)        
        {
            var currentRow = new List<int>();
            currentRow.Add(1);
            
            for(int j=0;j<previousRow.Count-1;j++)
            {
                currentRow.Add(previousRow[j]+previousRow[j+1]);
            }
            currentRow.Add(1);
            result.Add(currentRow);
            previousRow=currentRow;
        }
        return result;
    }
}
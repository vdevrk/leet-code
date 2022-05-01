public class Solution {
    public IList<string> GenerateParenthesis(int n)
        {
            IList<string> res = new List<string>();
            int open = n;//Holds the number of open brackets
            int close = n;//Holds the number of close brackets
            string output = "";
            Solve(open,close,output,res);
            return res;
        }

        private void Solve(int open, int close, string output, IList<string> res)
        {
            //Base condition.No brackets left to choose
            if(open==0 && close==0)
            {
                res.Add(output);
                return;
            }
            //Chosing open bracket option will always be present until open!=0
            if(open!=0)
            {
                string outputWithOpenBraces = output + "(";
                //Decrement open by 1 after using "(" in the output
                Solve(open-1, close, outputWithOpenBraces, res);
            }
            /*Close bracket can be chose only when close>open.I.e
            Some of the Open brackets are used and now we the have option for choosing close                   brackets. Close bracket cannot be chosen (else invalid parenthesis) until one of the               open brackets is used in the output*/
            if(close>open)
            {
                string outputWithClosedBraces = output + ")";
                //Decrement close by 1 after using ")" in the output
                Solve(open, close-1, outputWithClosedBraces, res);
            }
        }
}
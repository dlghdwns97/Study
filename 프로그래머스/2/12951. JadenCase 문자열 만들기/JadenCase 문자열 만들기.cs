using System;
using System.Text;

public class Solution {
    public string solution(string s) {
        char[] LowerArray = s.ToLower().ToCharArray();
        LowerArray[0] = char.ToUpper(LowerArray[0]);
        
        for (int i = 1; i < LowerArray.Length; i++)
        {
            if (LowerArray[i - 1] == ' ')
            {
                LowerArray[i] = char.ToUpper(LowerArray[i]);
            }
        }
        
        string answer = string.Join(string.Empty, LowerArray);
        return answer;
    }
}
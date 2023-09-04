using System;

public class Solution {
    public string solution(string s, int n) {
        char[] answer_array = s.ToCharArray();
        int[] x = new int[s.Length];
        
        for(int i = 0; i < s.Length; i++)
        {
            x[i] = Convert.ToInt32(answer_array[i]);
            if(x[i] > 64 && x[i] < 91)
            {
                x[i] = x[i] + n;
                if (x[i] > 90)
                {
                    x[i] -= 26;
                }
            }
            if(x[i] > 96 && x[i] < 123)
            {
                x[i] = x[i] + n;
                if (x[i] > 122)
                {
                    x[i] -= 26;
                }
            }
        }
        
        for(int i = 0; i < x.Length; i++)
        {
            answer_array[i] = Convert.ToChar(x[i]);
        }
        string answer = new string(answer_array);
        
        return answer;
    }
}